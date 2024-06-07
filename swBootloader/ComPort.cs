/**
 * @file ComPort.cs
 * @brief Управление com port-ом
 */
using System.IO.Ports;

namespace swBootloader
{
    public static class ComPort
    {
        public static SerialPort serialPort = new SerialPort();


        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] msg = new byte[1024]; // Массив для входящих сообщений
            serialPort.Read(msg, 0, msg.Length);
            msgHandler(msg);
        }

        /**@brief Обработчик входящих посылок*/
        public static void msgHandler(byte[] msg)
        {
            switch (msg[3])
            {
                case AppConsts.CMD_WRITE_SOFTWARE:
                    Protocol.CMD_SoftWriteMCU(msg);
                    break;
                case AppConsts.CMD_BOOT_WHO_AM_I:
                    Protocol.CMD_BootWhoAmIMCU(msg);
                    break;
                case AppConsts.CMD_SOFT_WHO_AM_I:
                    Protocol.CMD_SoftWhoAmIMCU(msg);
                    break;
                default: break;
            }
        }


        /** @brief запуск com port-a в режим работы*/
        public static void ComPortStart(int readTimeout, int writeTimeout)
        {

            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.ReadTimeout = readTimeout;
                    serialPort.WriteTimeout = writeTimeout;
                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        StartForm.startForm.SendLog("-Открыт порт:" + StartForm.startForm.cboPort.Text);
                        StartForm.startForm.Btn_OpenPort.Enabled     = false;
                        StartForm.startForm.Btn_SettingsPort.Enabled = false;
                        StartForm.startForm.cboPort.Enabled          = false;
                        StartForm.startForm.Btn_BootInfo.Enabled     = true;
                        StartForm.startForm.Btn_SoftInfo.Enabled     = true;
                        StartForm.startForm.Btn_ChooseSW.Enabled     = true;
                        StartForm.startForm.Btn_ClosePort.Enabled    = true;
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    }
                }
                catch
                {
                    MessageBox.Show("Порт " + serialPort.PortName + " недоступен!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /** @brief Останов работы com port-а */
        public static void ComPortStop()
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                    if (!serialPort.IsOpen) 
                    {
                        StartForm.startForm.SendLog("Закрыт порт:" + StartForm.startForm.cboPort.Text);
                        StartForm.startForm.Btn_OpenPort.Enabled     = true;
                        StartForm.startForm.Btn_SettingsPort.Enabled = true;
                        StartForm.startForm.cboPort.Enabled          = true;
                        StartForm.startForm.Btn_BootInfo.Enabled     = false;
                        StartForm.startForm.Btn_SoftInfo.Enabled     = false;
                        StartForm.startForm.Btn_ChooseSW.Enabled     = false;
                        StartForm.startForm.Btn_ClosePort.Enabled    = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Порт " + serialPort.PortName + " недоступен!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void ComPortWrite(byte[] buffer, int offset, int size)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(buffer, 0, size);
            }
        }

    }
}
