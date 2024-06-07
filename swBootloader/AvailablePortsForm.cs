using System.IO.Ports;

namespace swBootloader
{
    public partial class AvailablePortsForm : Form
    {
        private readonly SettingsForm _settingForm;
        public AvailablePortsForm(SettingsForm settingForm)
        {
            InitializeComponent();
            _settingForm = settingForm;
            // Обновили доступные порты в листе
            string[] availablePorts = SerialPort.GetPortNames();
            listBox_AvailablePorts.Items.Clear();
            listBox_AvailablePorts.Items.AddRange(availablePorts);
            listBox_AvailablePorts.SelectedIndex = 0;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            _settingForm.cboPortName.Text = listBox_AvailablePorts.Items[listBox_AvailablePorts.SelectedIndex].ToString();
            Configurator.settings.PortName = listBox_AvailablePorts.Text;
            Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string[] availablePorts = SerialPort.GetPortNames();
            listBox_AvailablePorts.Items.Clear();
            listBox_AvailablePorts.Items.AddRange(availablePorts);
            listBox_AvailablePorts.SelectedIndex = 0;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
