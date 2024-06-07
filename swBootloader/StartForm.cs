using System.IO.Ports;
using static System.Net.Mime.MediaTypeNames;

namespace swBootloader
{
    public partial class StartForm : Form
    {
        public static StartForm startForm;

        public StartForm()
        {
            InitializeComponent();
            startForm = this;
        }

        /** @brief Форма загружается*/
        private void StartForm_Load(object sender, EventArgs e)
        {
            // Добавляем все возможные com порты
            for (int i = 1; i < 256; i++)
            {
                cboPort.Items.Add("COM" + i.ToString());
            }
            //Установка на порт из настроек
            int index = cboPort.FindString(Configurator.settings.PortName);
            cboPort.SelectedIndex = index;
        }

        /** @brief Нажата клавиша прошивки микроконтроллера*/
        private void Btn_WriteSW_Click(object sender, EventArgs e)
        {
            Protocol.CMD_SoftWrite(Configurator.settings.sourceFileName, 0);
        }

        /** @brief Нажата клавиша выбора прошивки*/
        private void Btn_ChooseSW_Click(object sender, EventArgs e)
        {
            openFileDialog_SW.InitialDirectory = Configurator.settings.sourceFileName;
            openFileDialog_SW.Filter = "Raw binary |*.enc";
            if (openFileDialog_SW.ShowDialog() == DialogResult.OK)
            {
                Configurator.settings.sourceFileName = openFileDialog_SW.FileName;
                SendLog("-Открыт файл прошивки");
                SendLog("-Адрес Файла:" + Configurator.settings.sourceFileName);
                Configurator.SaveSettingsToJSON(AppConsts.JSON_PATH); // Подсейвили новый путь 
                Btn_WriteSW.Enabled = true;
            }
        }

        /** @brief Нажата клавиша открытия порта*/
        private void Btn_OpenPort_Click(object sender, EventArgs e)
        {
            ComPort.ComPortStart(500, 500);
        }

        /** @brief Нажата клавиша закрытия порта*/
        private void Btn_ClosePort_Click(object sender, EventArgs e)
        {
            ComPort.ComPortStop();
        }

        /** "brief Нажата клавиша настроек порта*/
        private void Btn_SettingsPort_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        /** @brief Получение информации о приборе*/
        private void Btn_SoftInfo_Click(object sender, EventArgs e)
        {
            Protocol.CMD_SoftWhoAmI();
        }

        /** @brief Получение информации о бутлоадере*/
        private void BtnBootInfo_Click(object sender, EventArgs e)
        {
            Protocol.CMD_BootWhoAmI();
        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configurator.settings.PortName = cboPort.Text;
        }

        public void SendLog(string text)
        {
            Action action = () =>
            {
                ProcessList.Text += text + Environment.NewLine;
            };
            if (InvokeRequired)
            {
                Invoke(action);
            } 
            else
            {
                action();
            }
        }


    }
}
