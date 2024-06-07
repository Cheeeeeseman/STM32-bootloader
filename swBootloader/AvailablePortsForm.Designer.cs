namespace swBootloader
{
    partial class AvailablePortsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailablePortsForm));
            Label_availablePorts = new Label();
            Btn_OK = new Button();
            Btn_Cancel = new Button();
            btn_Refresh = new Button();
            listBox_AvailablePorts = new ListBox();
            SuspendLayout();
            // 
            // Label_availablePorts
            // 
            Label_availablePorts.AutoSize = true;
            Label_availablePorts.Location = new Point(12, 9);
            Label_availablePorts.Name = "Label_availablePorts";
            Label_availablePorts.Size = new Size(82, 15);
            Label_availablePorts.TabIndex = 0;
            Label_availablePorts.Text = "Выбор порта:";
            // 
            // Btn_OK
            // 
            Btn_OK.Location = new Point(149, 27);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(75, 23);
            Btn_OK.TabIndex = 2;
            Btn_OK.Text = "OK";
            Btn_OK.UseVisualStyleBackColor = true;
            Btn_OK.Click += Btn_OK_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(149, 56);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(75, 23);
            Btn_Cancel.TabIndex = 3;
            Btn_Cancel.Text = "Отмена";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(149, 85);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(75, 23);
            btn_Refresh.TabIndex = 4;
            btn_Refresh.Text = "Обновить";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // listBox_AvailablePorts
            // 
            listBox_AvailablePorts.FormattingEnabled = true;
            listBox_AvailablePorts.ItemHeight = 15;
            listBox_AvailablePorts.Location = new Point(12, 27);
            listBox_AvailablePorts.Name = "listBox_AvailablePorts";
            listBox_AvailablePorts.Size = new Size(131, 169);
            listBox_AvailablePorts.TabIndex = 5;
            // 
            // AvailablePortsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(listBox_AvailablePorts);
            Controls.Add(btn_Refresh);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_OK);
            Controls.Add(Label_availablePorts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(250, 250);
            MinimumSize = new Size(250, 250);
            Name = "AvailablePortsForm";
            Text = "Последовательные порты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_availablePorts;
        private Button Btn_OK;
        private Button Btn_Cancel;
        private Button btn_Refresh;
        private TextBox TxtBx_AvailabalePorts;
        private ListBox listBox_AvailablePorts;
    }
}