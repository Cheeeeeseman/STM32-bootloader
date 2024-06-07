/**
 * @file Configurator.cs
 * @brief Файл содержит конфигуратор для управления настройками
 */

using System.IO.Ports;
using System.Text.Json;

namespace swBootloader
{
    public static class Configurator
    {
        public static Settings settings;

        /** 
         * @brief Функция загрузки конфига в json file
         * @param[in] Путь до JSON файла с конфигой
         */
        public static void SaveSettingsToJSON(string path)
        {
            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { IncludeFields = true });
            File.WriteAllText(path, json);
        }

        /** 
         * @brief Функция загрузки конфига из json фала 
         * @param[in] Путь до JSON файла с конфигой
         */
        public static void LoadSettingsFromJSON(string path)
        {
            string Path = path;
            string jsonString = File.ReadAllText(path);
            try
            {
                settings = JsonSerializer.Deserialize<Settings>(jsonString, new JsonSerializerOptions { IncludeFields = true });
            } catch
            {
                SettingsSetDefaultValues();
            }
            
        }

        /** @brief Установка дефолтных значений настроек */
        private static void SettingsSetDefaultValues()
        {
            settings.PortName = "COM1";
            settings.BaudRate = 9600;
            settings.Parity   = Parity.None;
            settings.DataBits = 8;
            settings.StopBits = StopBits.One;
            settings.sourceFileName = "C://";
        }
    }
}
