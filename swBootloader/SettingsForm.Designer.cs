namespace swBootloader
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            Txt_Name = new Label();
            Txt_Speed = new Label();
            Txt_DataBits = new Label();
            Txt_Parity = new Label();
            txt_StopBits = new Label();
            cboPortName = new ComboBox();
            cboBaudRate = new ComboBox();
            cboDataBits = new ComboBox();
            cboParity = new ComboBox();
            cboStopBits = new ComboBox();
            Btn_OK = new Button();
            Btn_Close = new Button();
            Btn_availablePorts = new Button();
            SuspendLayout();
            // 
            // Txt_Name
            // 
            Txt_Name.AutoSize = true;
            Txt_Name.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Txt_Name.Location = new Point(89, 13);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(42, 21);
            Txt_Name.TabIndex = 0;
            Txt_Name.Text = "Имя:";
            // 
            // Txt_Speed
            // 
            Txt_Speed.AutoSize = true;
            Txt_Speed.Font = new Font("Segoe Print", 9F);
            Txt_Speed.Location = new Point(12, 43);
            Txt_Speed.Name = "Txt_Speed";
            Txt_Speed.Size = new Size(119, 21);
            Txt_Speed.TabIndex = 1;
            Txt_Speed.Text = "Скорость бит/с:";
            // 
            // Txt_DataBits
            // 
            Txt_DataBits.AutoSize = true;
            Txt_DataBits.Font = new Font("Segoe Print", 9F);
            Txt_DataBits.Location = new Point(33, 73);
            Txt_DataBits.Name = "Txt_DataBits";
            Txt_DataBits.Size = new Size(98, 21);
            Txt_DataBits.TabIndex = 2;
            Txt_DataBits.Text = "Биты данных:";
            // 
            // Txt_Parity
            // 
            Txt_Parity.AutoSize = true;
            Txt_Parity.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Txt_Parity.Location = new Point(50, 103);
            Txt_Parity.Name = "Txt_Parity";
            Txt_Parity.Size = new Size(81, 21);
            Txt_Parity.TabIndex = 3;
            Txt_Parity.Text = "Четность:";
            // 
            // txt_StopBits
            // 
            txt_StopBits.AutoSize = true;
            txt_StopBits.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txt_StopBits.Location = new Point(15, 129);
            txt_StopBits.Name = "txt_StopBits";
            txt_StopBits.Size = new Size(116, 21);
            txt_StopBits.TabIndex = 4;
            txt_StopBits.Text = "Стоповые биты:";
            // 
            // cboPortName
            // 
            cboPortName.FormattingEnabled = true;
            cboPortName.Location = new Point(147, 13);
            cboPortName.Name = "cboPortName";
            cboPortName.Size = new Size(121, 23);
            cboPortName.TabIndex = 5;
            // 
            // cboBaudRate
            // 
            cboBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBaudRate.FormattingEnabled = true;
            cboBaudRate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600" });
            cboBaudRate.Location = new Point(147, 41);
            cboBaudRate.Name = "cboBaudRate";
            cboBaudRate.Size = new Size(121, 23);
            cboBaudRate.TabIndex = 6;
            // 
            // cboDataBits
            // 
            cboDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDataBits.FormattingEnabled = true;
            cboDataBits.Items.AddRange(new object[] { "4", "5", "6", "7", "8" });
            cboDataBits.Location = new Point(147, 70);
            cboDataBits.Name = "cboDataBits";
            cboDataBits.Size = new Size(121, 23);
            cboDataBits.TabIndex = 7;
            // 
            // cboParity
            // 
            cboParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboParity.FormattingEnabled = true;
            cboParity.Items.AddRange(new object[] { "None", "Odd", "Even" });
            cboParity.Location = new Point(147, 101);
            cboParity.Name = "cboParity";
            cboParity.Size = new Size(121, 23);
            cboParity.TabIndex = 8;
            // 
            // cboStopBits
            // 
            cboStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStopBits.FormattingEnabled = true;
            cboStopBits.Items.AddRange(new object[] { "None", "One", "Two" });
            cboStopBits.Location = new Point(147, 129);
            cboStopBits.Name = "cboStopBits";
            cboStopBits.Size = new Size(121, 23);
            cboStopBits.TabIndex = 9;
            // 
            // Btn_OK
            // 
            Btn_OK.Location = new Point(147, 158);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(59, 23);
            Btn_OK.TabIndex = 10;
            Btn_OK.Text = "OK";
            Btn_OK.UseVisualStyleBackColor = true;
            Btn_OK.Click += Btn_OK_Click;
            // 
            // Btn_Close
            // 
            Btn_Close.Location = new Point(209, 158);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(59, 23);
            Btn_Close.TabIndex = 11;
            Btn_Close.Text = "Отмена";
            Btn_Close.UseVisualStyleBackColor = true;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // Btn_availablePorts
            // 
            Btn_availablePorts.BackColor = Color.LightGreen;
            Btn_availablePorts.Location = new Point(274, 11);
            Btn_availablePorts.Name = "Btn_availablePorts";
            Btn_availablePorts.Size = new Size(38, 23);
            Btn_availablePorts.TabIndex = 12;
            Btn_availablePorts.Text = "...";
            Btn_availablePorts.UseVisualStyleBackColor = false;
            Btn_availablePorts.Click += Btn_availablePorts_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(324, 191);
            Controls.Add(Btn_availablePorts);
            Controls.Add(Btn_Close);
            Controls.Add(Btn_OK);
            Controls.Add(cboStopBits);
            Controls.Add(cboParity);
            Controls.Add(cboDataBits);
            Controls.Add(cboBaudRate);
            Controls.Add(cboPortName);
            Controls.Add(txt_StopBits);
            Controls.Add(Txt_Parity);
            Controls.Add(Txt_DataBits);
            Controls.Add(Txt_Speed);
            Controls.Add(Txt_Name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(340, 230);
            MinimumSize = new Size(340, 230);
            Name = "SettingsForm";
            Text = "Настройка порта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Txt_Name;
        private Label Txt_Speed;
        private Label Txt_DataBits;
        private Label Txt_Parity;
        private Label txt_StopBits;
        public  ComboBox cboPortName;
        private ComboBox cboBaudRate;
        private ComboBox cboDataBits;
        private ComboBox cboParity;
        private ComboBox cboStopBits;
        private Button Btn_OK;
        private Button Btn_Close;
        private Button Btn_availablePorts;
    }
}