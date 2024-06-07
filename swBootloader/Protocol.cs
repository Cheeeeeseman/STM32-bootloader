/** 
 * @file Protocol.cs
 * @brief Файл содержит протокол связи с микроконтроллером stm32
 */

using System.Text;

namespace swBootloader
{
    public static class Protocol
    {
        private static int errCnt { get; set; } // счетчик ошибок (если больше допустимого количества,то порт блочится)
        public static int errorCnt { get { return errCnt; }
            set
            {
                errCnt = value;
                if (errCnt == AppConsts.MAX_ERRORS_AMOUNT)
                {
                    StartForm.startForm.SendLog("-Превышено число допустимых ошибок!");
                    ComPort.ComPortStop();
                    errCnt = 0; // Сброс счетчика ошибок передачи данных
                    // Блочим все кнопки
                    StartForm.startForm.SendLog("Закрыт порт:" + StartForm.startForm.cboPort.Text); 
                }
            }
        } 
        public static ushort packetAmount = 0;  // Количество полных блоков прошивки 
        public static ushort packetNumber = 0;  // Номер текущего блока прошивки

        /** 
         * @brief Команда записи прошивки в контроллер
         * param[in] path - путь до прошивки
         *           packetNum - номер пакета
         */
        public static void CMD_SoftWrite(string path, int packetNum)
        {
            int len;    // Длина прочитанных данных
            byte[] bin = new byte[AppConsts.PACKET_DATA_MAX_SIZE];  // Временное хранилище для прошивки
            var packet = new List<byte>();  // пакет с данными 

            using (FileStream inStream = new FileStream(path, FileMode.Open, FileAccess.Read))   //создаем файловый поток на чтение/запись
            {
                inStream.Seek(packetNum * AppConsts.PACKET_DATA_MAX_SIZE, SeekOrigin.Begin);    // Откуда читаем текст
                packetAmount = (ushort)(inStream.Length / AppConsts.PACKET_DATA_MAX_SIZE);  // Размер данных
                if ((ushort)(inStream.Length % AppConsts.PACKET_DATA_MAX_SIZE) > 0) { packetAmount++; }
                len = inStream.Read(bin, 0, AppConsts.PACKET_DATA_MAX_SIZE);
            }
            // Формируем пакет с данными
            packet.Add(AppConsts.PACKET_HEADER);
            packet.AddRange(BitConverter.GetBytes((ushort)(len + 9))); // Добавляем код команды (CMD + размеры пакетов+ CRC)
            packet.Add(AppConsts.CMD_WRITE_SOFTWARE);
            packet.AddRange(BitConverter.GetBytes((ushort)packetAmount));
            packet.AddRange(BitConverter.GetBytes((ushort)packetNum));
            for (int i = 0; i < len; i++) { packet.Add(bin[i]); }
            uint crc = CRC32.CalculateCrc32(packet.ToArray());
            packet.AddRange(BitConverter.GetBytes(crc));
            byte[] array = packet.ToArray();
            ComPort.ComPortWrite(array, 0, array.Length);
        }

        /**
         * @brief Команда обработчик ответа от микроконтроллера
         * @param[in] msg - принятый ответ от контроллера
         */
        public static void CMD_SoftWriteMCU(byte[] msg)
        {
            uint crcCalc = CRC32.CalculateCrc32(msg, 8);  // 
            uint crcRead = BitConverter.ToUInt32(msg, 8); // Контрольная сумма 
            if (msg[4] == (byte)ERROR_T.NO_ERROR && (crcRead == crcCalc))
            {
                packetNumber++;
                if (packetNumber == packetAmount)
                {
                    StartForm.startForm.SendLog("-Прошивка записана в микроконтроллер");
                }  
                else
                {
                    CMD_SoftWrite(Configurator.settings.sourceFileName, packetNumber);
                }
            }
            else
            {
                StartForm.startForm.SendLog("-Ошибка передачи блока прошивки");
                errorCnt++;
                CMD_SoftWrite(Configurator.settings.sourceFileName, packetNumber); // Повторная передача блока
            }
        }
        //---------------------------------------------------------------------------------------

        /** @brief Запрос номера версии прошивки бутлоадера*/
        public static void CMD_BootWhoAmI()
        {
            int packetLen = AppConsts.PACK_SIZE_BOOT_WHO_AM_I; // длина всего пакета
            var packet    = new List<byte>(packetLen);
            // Формируем пакет
            packet.Add(AppConsts.PACKET_HEADER);
            packet.AddRange(BitConverter.GetBytes((ushort)(packetLen - 3)));
            packet.Add(AppConsts.CMD_BOOT_WHO_AM_I);
            uint crc = CRC32.CalculateCrc32(packet.ToArray());
            packet.AddRange(BitConverter.GetBytes(crc));
            byte[] array = packet.ToArray();
            ComPort.ComPortWrite(array, 0, packetLen);
        }

        /**
         * @brief Команда обработчик ответа от микроконтроллера
         * @param[in] msg - принятый ответ от контроллера
         */
        public static void CMD_BootWhoAmIMCU(byte[] msg)
        {
            string version;
            uint crcCalc = CRC32.CalculateCrc32(msg, 16);  // 
            uint crcRead = BitConverter.ToUInt32(msg, 16); // Контрольная сумма 
            if ((msg[4] == (byte)ERROR_T.NO_ERROR) && (crcRead == crcCalc))
            {
                version = Encoding.UTF8.GetString(msg, 8, 15);
                StartForm.startForm.SendLog("-Версия бутлоадера: " + version);
            }
            else
            {
                StartForm.startForm.SendLog("-Ошибка передачи версии бутлоадера");
                errorCnt++;
                CMD_BootWhoAmI(); // повторная посылка
            }
        }

        //---------------------------------------------------------------------------------------
        /** @brief Запрос номера версии прошивки команды*/
        public static void CMD_SoftWhoAmI()
        {
            int packetLen = AppConsts.PACK_SIZE_SOFT_WHO_AM_I; // длина всего пакета
            var packet    = new List<byte>(packetLen);
            // Формируем пакет
            packet.Add(AppConsts.PACKET_HEADER);
            packet.AddRange(BitConverter.GetBytes((ushort)(packetLen - 3)));
            packet.Add(AppConsts.CMD_SOFT_WHO_AM_I);
            uint crc = CRC32.CalculateCrc32(packet.ToArray());
            packet.AddRange(BitConverter.GetBytes(crc));
            byte[] array = packet.ToArray();
            ComPort.ComPortWrite(array, 0, packetLen);
        }

        /**
         * @brief Команда обработчик ответа от микроконтроллера
         * @param[in] msg - принятый ответ от контроллера
         */
        public static void CMD_SoftWhoAmIMCU(byte[] msg)
        {
            string version;
            uint crcCalc = CRC32.CalculateCrc32(msg, 16);
            uint crcRead = BitConverter.ToUInt32(msg, 16);
            if ((msg[4] == (byte)ERROR_T.NO_ERROR) && (crcRead == crcCalc))
            {
                version = Encoding.UTF8.GetString(msg, 8, 15);
                StartForm.startForm.SendLog("-Версия прошивки: " + version);
            }
            else
            {
                StartForm.startForm.SendLog("-Ошибка передачи версии прошивки");
                errorCnt++;
                CMD_SoftWhoAmI(); // повторная посылка
            }
        }


    }
}
