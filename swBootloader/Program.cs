/** 
 * @file Program.cs
 * @brief �������� ���� ���������
 */

namespace swBootloader
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            StartForm startForm = new StartForm();                   // ������� ��������� �����
            Configurator.LoadSettingsFromJSON(AppConsts.JSON_PATH);  // ���������� ���������            
            Application.Run(startForm);
        }
    }
}