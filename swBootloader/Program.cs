/** 
 * @file Program.cs
 * @brief Основной файл программы
 */

namespace swBootloader
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            StartForm startForm = new StartForm();                   // Создаем начальную форму
            Configurator.LoadSettingsFromJSON(AppConsts.JSON_PATH);  // Подгружаем настройки            
            Application.Run(startForm);
        }
    }
}