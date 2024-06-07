/**
 * @file Settings.cs
 * @brief Файл содержит описание основных настроек
 */

using System.IO.Ports;

namespace swBootloader
{
    public class Settings
    {
        private string? portName      { get; set; } // имя COM порта
        private int baudRate          { get; set; } // скорость работы
        private int dataBits          { get; set; } // количество данных
        private Parity parity         { get; set; } // контроль четности
        private StopBits stopBits     { get; set; } // количество стоповых битов
        public string? sourceFileName { get; set; } // имя файла

        public string? PortName  
        { 
            get { return portName; } 
            set
            { 
                portName = value;
                ComPort.serialPort.PortName = portName;
            } 
        }

        public int BaudRate
        {
            get { return baudRate; }
            set
            {
                baudRate = value;
                ComPort.serialPort.BaudRate = baudRate;
            }
        }
        public int DataBits
        {
            get { return dataBits; }
            set
            {
                dataBits = value;
                ComPort.serialPort.DataBits = dataBits;
            }
        }
        public Parity Parity
        {
            get { return parity; }
            set
            {
                parity = value;
                ComPort.serialPort.Parity = parity;
            }
        }
        public StopBits StopBits
        {
            get { return stopBits; }
            set
            {
                stopBits = value;
                ComPort.serialPort.StopBits = stopBits;
            }
        }
    }
}
