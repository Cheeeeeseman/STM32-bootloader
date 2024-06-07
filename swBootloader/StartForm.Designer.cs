namespace swBootloader
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            Btn_ChooseSW = new Button();
            Btn_WriteSW = new Button();
            ProcessList = new TextBox();
            progressBar1 = new ProgressBar();
            Txt_process = new Label();
            groupBox1 = new GroupBox();
            Btn_SettingsPort = new Button();
            Txt_port = new Label();
            Btn_ClosePort = new Button();
            cboPort = new ComboBox();
            Btn_OpenPort = new Button();
            Btn_BootInfo = new Button();
            Btn_SoftInfo = new Button();
            openFileDialog_SW = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_ChooseSW
            // 
            Btn_ChooseSW.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_ChooseSW.Enabled = false;
            Btn_ChooseSW.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Btn_ChooseSW.Location = new Point(220, 111);
            Btn_ChooseSW.Name = "Btn_ChooseSW";
            Btn_ChooseSW.Size = new Size(162, 50);
            Btn_ChooseSW.TabIndex = 0;
            Btn_ChooseSW.Text = "Выбрать прошивку";
            Btn_ChooseSW.UseVisualStyleBackColor = true;
            Btn_ChooseSW.Click += Btn_ChooseSW_Click;
            // 
            // Btn_WriteSW
            // 
            Btn_WriteSW.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_WriteSW.Enabled = false;
            Btn_WriteSW.Font = new Font("Segoe Print", 9F);
            Btn_WriteSW.Location = new Point(220, 167);
            Btn_WriteSW.Name = "Btn_WriteSW";
            Btn_WriteSW.Size = new Size(162, 50);
            Btn_WriteSW.TabIndex = 1;
            Btn_WriteSW.Text = "Прошить контроллер";
            Btn_WriteSW.UseVisualStyleBackColor = true;
            Btn_WriteSW.Click += Btn_WriteSW_Click;
            // 
            // ProcessList
            // 
            ProcessList.Font = new Font("Segoe Print", 9F);
            ProcessList.Location = new Point(12, 12);
            ProcessList.Multiline = true;
            ProcessList.Name = "ProcessList";
            ProcessList.ScrollBars = ScrollBars.Both;
            ProcessList.Size = new Size(192, 306);
            ProcessList.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(220, 295);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(162, 23);
            progressBar1.TabIndex = 4;
            // 
            // Txt_process
            // 
            Txt_process.AutoSize = true;
            Txt_process.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Txt_process.Location = new Point(220, 271);
            Txt_process.Name = "Txt_process";
            Txt_process.Size = new Size(59, 21);
            Txt_process.TabIndex = 5;
            Txt_process.Text = "Процесс";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_SettingsPort);
            groupBox1.Controls.Add(Txt_port);
            groupBox1.Controls.Add(Btn_ClosePort);
            groupBox1.Controls.Add(cboPort);
            groupBox1.Controls.Add(Btn_OpenPort);
            groupBox1.Location = new Point(220, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(169, 93);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "настройки порта";
            // 
            // Btn_SettingsPort
            // 
            Btn_SettingsPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_SettingsPort.Font = new Font("Segoe Print", 9F);
            Btn_SettingsPort.Image = (Image)resources.GetObject("Btn_SettingsPort.Image");
            Btn_SettingsPort.Location = new Point(130, 55);
            Btn_SettingsPort.Name = "Btn_SettingsPort";
            Btn_SettingsPort.Size = new Size(32, 32);
            Btn_SettingsPort.TabIndex = 9;
            Btn_SettingsPort.UseVisualStyleBackColor = true;
            Btn_SettingsPort.Click += Btn_SettingsPort_Click;
            // 
            // Txt_port
            // 
            Txt_port.AutoSize = true;
            Txt_port.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Txt_port.Location = new Point(8, 26);
            Txt_port.Name = "Txt_port";
            Txt_port.Size = new Size(41, 21);
            Txt_port.TabIndex = 3;
            Txt_port.Text = "Port:";
            // 
            // Btn_ClosePort
            // 
            Btn_ClosePort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_ClosePort.Enabled = false;
            Btn_ClosePort.Font = new Font("Segoe Print", 9F);
            Btn_ClosePort.Image = (Image)resources.GetObject("Btn_ClosePort.Image");
            Btn_ClosePort.Location = new Point(92, 55);
            Btn_ClosePort.Name = "Btn_ClosePort";
            Btn_ClosePort.Size = new Size(32, 32);
            Btn_ClosePort.TabIndex = 8;
            Btn_ClosePort.UseVisualStyleBackColor = true;
            Btn_ClosePort.Click += Btn_ClosePort_Click;
            // 
            // cboPort
            // 
            cboPort.FormattingEnabled = true;
            cboPort.Location = new Point(54, 26);
            cboPort.Name = "cboPort";
            cboPort.Size = new Size(108, 23);
            cboPort.TabIndex = 6;
            cboPort.SelectedIndexChanged += cboPort_SelectedIndexChanged;
            // 
            // Btn_OpenPort
            // 
            Btn_OpenPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_OpenPort.Font = new Font("Segoe Print", 9F);
            Btn_OpenPort.Image = (Image)resources.GetObject("Btn_OpenPort.Image");
            Btn_OpenPort.Location = new Point(54, 55);
            Btn_OpenPort.Name = "Btn_OpenPort";
            Btn_OpenPort.Size = new Size(32, 32);
            Btn_OpenPort.TabIndex = 7;
            Btn_OpenPort.UseVisualStyleBackColor = true;
            Btn_OpenPort.Click += Btn_OpenPort_Click;
            // 
            // Btn_BootInfo
            // 
            Btn_BootInfo.Enabled = false;
            Btn_BootInfo.Location = new Point(220, 223);
            Btn_BootInfo.Name = "Btn_BootInfo";
            Btn_BootInfo.Size = new Size(75, 23);
            Btn_BootInfo.TabIndex = 10;
            Btn_BootInfo.Text = "Boot Info";
            Btn_BootInfo.UseVisualStyleBackColor = true;
            Btn_BootInfo.Click += BtnBootInfo_Click;
            // 
            // Btn_SoftInfo
            // 
            Btn_SoftInfo.Enabled = false;
            Btn_SoftInfo.Location = new Point(307, 223);
            Btn_SoftInfo.Name = "Btn_SoftInfo";
            Btn_SoftInfo.Size = new Size(75, 23);
            Btn_SoftInfo.TabIndex = 11;
            Btn_SoftInfo.Text = "Soft Info";
            Btn_SoftInfo.UseVisualStyleBackColor = true;
            Btn_SoftInfo.Click += Btn_SoftInfo_Click;
            // 
            // openFileDialog_SW
            // 
            openFileDialog_SW.FileName = "openFileDialog1";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(394, 331);
            Controls.Add(Btn_SoftInfo);
            Controls.Add(Btn_BootInfo);
            Controls.Add(groupBox1);
            Controls.Add(Txt_process);
            Controls.Add(progressBar1);
            Controls.Add(ProcessList);
            Controls.Add(Btn_WriteSW);
            Controls.Add(Btn_ChooseSW);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(410, 370);
            MinimumSize = new Size(410, 370);
            Name = "StartForm";
            Text = "swBootloader";
            Load += StartForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button Btn_ChooseSW;
        public Button Btn_WriteSW;
        private TextBox ProcessList;
        private ProgressBar progressBar1;
        private Label Txt_process;
        private GroupBox groupBox1;
        public  ComboBox cboPort;
        public Button Btn_OpenPort;
        private Label Txt_port;
        public Button Btn_ClosePort;
        public Button Btn_SettingsPort;
        public Button Btn_BootInfo;
        public Button Btn_SoftInfo;
        private OpenFileDialog openFileDialog_SW;
    }
}
