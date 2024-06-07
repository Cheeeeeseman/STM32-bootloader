using System.IO.Ports;

namespace swBootloader
{
    public partial class SettingsForm : Form
    {
        private readonly StartForm _startForm;
        public SettingsForm(StartForm startForm)
        {
            InitializeComponent();
            _startForm = startForm;
            cboPortName.Text = Configurator.settings.PortName;
            cboBaudRate.Text = Convert.ToString(Configurator.settings.BaudRate);
            cboDataBits.Text = Convert.ToString(Configurator.settings.DataBits);
            cboParity.Text   = Convert.ToString(Configurator.settings.Parity);
            cboStopBits.Text = Convert.ToString(Configurator.settings.StopBits);

            // Добавляем все возможные com порты
            for (int i = 1; i < 256; i++)
            {
                cboPortName.Items.Add("COM" + i.ToString());
            }
            //Установка на порт из настроек
            int index = cboPortName.FindString(Configurator.settings.PortName);
            cboPortName.SelectedIndex = index;
        }


        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            Configurator.settings.PortName = cboPortName.Text;
            Configurator.settings.BaudRate = Convert.ToInt32(cboBaudRate.Text);
            Configurator.settings.DataBits = Convert.ToInt32(cboDataBits.Text);
            Configurator.settings.Parity   = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
            Configurator.settings.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
            Configurator.SaveSettingsToJSON(AppConsts.JSON_PATH); // @ASK
            _startForm.cboPort.Text = cboPortName.Text;
            Close();
        }

        private void Btn_availablePorts_Click(object sender, EventArgs e)
        {
            AvailablePortsForm availablePortsForm = new AvailablePortsForm(this);
            availablePortsForm.ShowDialog();
        }
    }
}
