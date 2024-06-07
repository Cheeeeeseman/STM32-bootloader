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

        /** @brief ����� �����������*/
        private void StartForm_Load(object sender, EventArgs e)
        {
            // ��������� ��� ��������� com �����
            for (int i = 1; i < 256; i++)
            {
                cboPort.Items.Add("COM" + i.ToString());
            }
            //��������� �� ���� �� ��������
            int index = cboPort.FindString(Configurator.settings.PortName);
            cboPort.SelectedIndex = index;
        }

        /** @brief ������ ������� �������� ����������������*/
        private void Btn_WriteSW_Click(object sender, EventArgs e)
        {
            Protocol.CMD_SoftWrite(Configurator.settings.sourceFileName, 0);
        }

        /** @brief ������ ������� ������ ��������*/
        private void Btn_ChooseSW_Click(object sender, EventArgs e)
        {
            openFileDialog_SW.InitialDirectory = Configurator.settings.sourceFileName;
            openFileDialog_SW.Filter = "Raw binary |*.enc";
            if (openFileDialog_SW.ShowDialog() == DialogResult.OK)
            {
                Configurator.settings.sourceFileName = openFileDialog_SW.FileName;
                SendLog("-������ ���� ��������");
                SendLog("-����� �����:" + Configurator.settings.sourceFileName);
                Configurator.SaveSettingsToJSON(AppConsts.JSON_PATH); // ���������� ����� ���� 
                Btn_WriteSW.Enabled = true;
            }
        }

        /** @brief ������ ������� �������� �����*/
        private void Btn_OpenPort_Click(object sender, EventArgs e)
        {
            ComPort.ComPortStart(500, 500);
        }

        /** @brief ������ ������� �������� �����*/
        private void Btn_ClosePort_Click(object sender, EventArgs e)
        {
            ComPort.ComPortStop();
        }

        /** "brief ������ ������� �������� �����*/
        private void Btn_SettingsPort_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        /** @brief ��������� ���������� � �������*/
        private void Btn_SoftInfo_Click(object sender, EventArgs e)
        {
            Protocol.CMD_SoftWhoAmI();
        }

        /** @brief ��������� ���������� � ����������*/
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
