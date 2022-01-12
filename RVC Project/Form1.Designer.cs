namespace RVC_Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NormalButton = new System.Windows.Forms.Button();
            this.LoopbackButton = new System.Windows.Forms.Button();
            this.SilentButton = new System.Windows.Forms.Button();
            this.SilentLoopbackButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.DataField = new System.Windows.Forms.TextBox();
            this.IdeField = new System.Windows.Forms.CheckBox();
            this.RtrField = new System.Windows.Forms.CheckBox();
            this.IdField = new System.Windows.Forms.NumericUpDown();
            this.SetBitrateButton = new System.Windows.Forms.Button();
            this.BitrateField = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.VersionField = new System.Windows.Forms.TextBox();
            this.CanMessageList = new System.Windows.Forms.ListBox();
            this.LogField = new System.Windows.Forms.RichTextBox();
            this.DlcField = new System.Windows.Forms.NumericUpDown();
            this.PortNamesListField = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.ClearMessagesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RvcSendButton = new System.Windows.Forms.Button();
            this.RvcDgnField = new System.Windows.Forms.NumericUpDown();
            this.RvcDataField = new System.Windows.Forms.TextBox();
            this.RvcMessageList = new System.Windows.Forms.ListBox();
            this.ClearRvcButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RvcSourceAdressField = new System.Windows.Forms.NumericUpDown();
            this.RvcPriorityField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RvcDgnField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcSourceAdressField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcPriorityField)).BeginInit();
            this.SuspendLayout();
            // 
            // NormalButton
            // 
            this.NormalButton.Location = new System.Drawing.Point(3, 27);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(93, 23);
            this.NormalButton.TabIndex = 0;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = true;
            this.NormalButton.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // LoopbackButton
            // 
            this.LoopbackButton.Location = new System.Drawing.Point(3, 56);
            this.LoopbackButton.Name = "LoopbackButton";
            this.LoopbackButton.Size = new System.Drawing.Size(93, 23);
            this.LoopbackButton.TabIndex = 1;
            this.LoopbackButton.Text = "Loopback";
            this.LoopbackButton.UseVisualStyleBackColor = true;
            this.LoopbackButton.Click += new System.EventHandler(this.LoopbackButton_Click);
            // 
            // SilentButton
            // 
            this.SilentButton.Location = new System.Drawing.Point(102, 27);
            this.SilentButton.Name = "SilentButton";
            this.SilentButton.Size = new System.Drawing.Size(93, 23);
            this.SilentButton.TabIndex = 2;
            this.SilentButton.Text = "Silent";
            this.SilentButton.UseVisualStyleBackColor = true;
            this.SilentButton.Click += new System.EventHandler(this.SilentButton_Click);
            // 
            // SilentLoopbackButton
            // 
            this.SilentLoopbackButton.Location = new System.Drawing.Point(102, 56);
            this.SilentLoopbackButton.Name = "SilentLoopbackButton";
            this.SilentLoopbackButton.Size = new System.Drawing.Size(93, 23);
            this.SilentLoopbackButton.TabIndex = 3;
            this.SilentLoopbackButton.Text = "Silent Loopback";
            this.SilentLoopbackButton.UseVisualStyleBackColor = true;
            this.SilentLoopbackButton.Click += new System.EventHandler(this.SilentLoopbackButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(66, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DataField
            // 
            this.DataField.Location = new System.Drawing.Point(350, 3);
            this.DataField.Name = "DataField";
            this.DataField.Size = new System.Drawing.Size(137, 20);
            this.DataField.TabIndex = 6;
            this.DataField.Text = "0011223344556677";
            this.DataField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.DataField, "Данные для передачи");
            // 
            // IdeField
            // 
            this.IdeField.AutoSize = true;
            this.IdeField.Checked = true;
            this.IdeField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IdeField.Location = new System.Drawing.Point(79, 5);
            this.IdeField.Name = "IdeField";
            this.IdeField.Size = new System.Drawing.Size(44, 17);
            this.IdeField.TabIndex = 7;
            this.IdeField.Text = "IDE";
            this.toolTip1.SetToolTip(this.IdeField, "Расширенный заголовок пакета");
            this.IdeField.UseVisualStyleBackColor = true;
            this.IdeField.CheckedChanged += new System.EventHandler(this.IdeField_CheckedChanged);
            // 
            // RtrField
            // 
            this.RtrField.AutoSize = true;
            this.RtrField.Location = new System.Drawing.Point(129, 5);
            this.RtrField.Name = "RtrField";
            this.RtrField.Size = new System.Drawing.Size(49, 17);
            this.RtrField.TabIndex = 8;
            this.RtrField.Text = "RTR";
            this.toolTip1.SetToolTip(this.RtrField, "Запрос DGN");
            this.RtrField.UseVisualStyleBackColor = true;
            // 
            // IdField
            // 
            this.IdField.Hexadecimal = true;
            this.IdField.Location = new System.Drawing.Point(237, 3);
            this.IdField.Maximum = new decimal(new int[] {
            536870911,
            0,
            0,
            0});
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(107, 20);
            this.IdField.TabIndex = 9;
            this.IdField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.IdField, "ID");
            this.IdField.Value = new decimal(new int[] {
            536870911,
            0,
            0,
            0});
            // 
            // SetBitrateButton
            // 
            this.SetBitrateButton.Location = new System.Drawing.Point(214, 73);
            this.SetBitrateButton.Name = "SetBitrateButton";
            this.SetBitrateButton.Size = new System.Drawing.Size(93, 23);
            this.SetBitrateButton.TabIndex = 10;
            this.SetBitrateButton.Text = "Set bitrate";
            this.SetBitrateButton.UseVisualStyleBackColor = true;
            this.SetBitrateButton.Click += new System.EventHandler(this.SetBitrateButton_Click);
            // 
            // BitrateField
            // 
            this.BitrateField.Location = new System.Drawing.Point(313, 74);
            this.BitrateField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BitrateField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BitrateField.Name = "BitrateField";
            this.BitrateField.Size = new System.Drawing.Size(68, 20);
            this.BitrateField.TabIndex = 11;
            this.BitrateField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BitrateField.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adapter Version";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VersionField
            // 
            this.VersionField.Location = new System.Drawing.Point(313, 45);
            this.VersionField.Name = "VersionField";
            this.VersionField.ReadOnly = true;
            this.VersionField.Size = new System.Drawing.Size(152, 20);
            this.VersionField.TabIndex = 13;
            this.VersionField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CanMessageList
            // 
            this.CanMessageList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CanMessageList.FormattingEnabled = true;
            this.CanMessageList.Location = new System.Drawing.Point(576, 12);
            this.CanMessageList.Name = "CanMessageList";
            this.CanMessageList.Size = new System.Drawing.Size(627, 186);
            this.CanMessageList.TabIndex = 14;
            this.toolTip1.SetToolTip(this.CanMessageList, "Перечень различных CAN сообщений");
            // 
            // LogField
            // 
            this.LogField.Location = new System.Drawing.Point(0, 206);
            this.LogField.Name = "LogField";
            this.LogField.Size = new System.Drawing.Size(570, 265);
            this.LogField.TabIndex = 15;
            this.LogField.Text = "";
            this.toolTip1.SetToolTip(this.LogField, "Лог работы адаптера");
            // 
            // DlcField
            // 
            this.DlcField.Location = new System.Drawing.Point(184, 3);
            this.DlcField.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DlcField.Name = "DlcField";
            this.DlcField.Size = new System.Drawing.Size(47, 20);
            this.DlcField.TabIndex = 16;
            this.DlcField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.DlcField, "Длина сообщения");
            this.DlcField.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // PortNamesListField
            // 
            this.PortNamesListField.FormattingEnabled = true;
            this.PortNamesListField.Location = new System.Drawing.Point(116, 10);
            this.PortNamesListField.Name = "PortNamesListField";
            this.PortNamesListField.Size = new System.Drawing.Size(121, 21);
            this.PortNamesListField.TabIndex = 19;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(11, 10);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(99, 23);
            this.ConnectButton.TabIndex = 20;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(243, 8);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(99, 23);
            this.RefreshButton.TabIndex = 21;
            this.RefreshButton.Text = "Refresh ports";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.NormalButton);
            this.panel1.Controls.Add(this.LoopbackButton);
            this.panel1.Controls.Add(this.SilentButton);
            this.panel1.Controls.Add(this.SilentLoopbackButton);
            this.panel1.Location = new System.Drawing.Point(8, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 85);
            this.panel1.TabIndex = 22;
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(428, 172);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(61, 23);
            this.ClearLogButton.TabIndex = 23;
            this.ClearLogButton.Text = "Clear Log";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // ClearMessagesButton
            // 
            this.ClearMessagesButton.Location = new System.Drawing.Point(501, 12);
            this.ClearMessagesButton.Name = "ClearMessagesButton";
            this.ClearMessagesButton.Size = new System.Drawing.Size(69, 23);
            this.ClearMessagesButton.TabIndex = 24;
            this.ClearMessagesButton.Text = "Clear CAN";
            this.ClearMessagesButton.UseVisualStyleBackColor = true;
            this.ClearMessagesButton.Click += new System.EventHandler(this.ClearMessagesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.SendButton);
            this.panel2.Controls.Add(this.IdeField);
            this.panel2.Controls.Add(this.RtrField);
            this.panel2.Controls.Add(this.DlcField);
            this.panel2.Controls.Add(this.IdField);
            this.panel2.Controls.Add(this.DataField);
            this.panel2.Location = new System.Drawing.Point(8, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 32);
            this.panel2.TabIndex = 25;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(3, 1);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(93, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(102, 0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(93, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.RvcPriorityField);
            this.panel3.Controls.Add(this.RvcSourceAdressField);
            this.panel3.Controls.Add(this.RvcSendButton);
            this.panel3.Controls.Add(this.RvcDgnField);
            this.panel3.Controls.Add(this.RvcDataField);
            this.panel3.Location = new System.Drawing.Point(8, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 32);
            this.panel3.TabIndex = 26;
            // 
            // RvcSendButton
            // 
            this.RvcSendButton.Location = new System.Drawing.Point(3, 2);
            this.RvcSendButton.Name = "RvcSendButton";
            this.RvcSendButton.Size = new System.Drawing.Size(66, 23);
            this.RvcSendButton.TabIndex = 4;
            this.RvcSendButton.Text = "Send RVC";
            this.RvcSendButton.UseVisualStyleBackColor = true;
            this.RvcSendButton.Click += new System.EventHandler(this.RvcSendButton_Click);
            // 
            // RvcDgnField
            // 
            this.RvcDgnField.Hexadecimal = true;
            this.RvcDgnField.Location = new System.Drawing.Point(129, 4);
            this.RvcDgnField.Maximum = new decimal(new int[] {
            131071,
            0,
            0,
            0});
            this.RvcDgnField.Name = "RvcDgnField";
            this.RvcDgnField.Size = new System.Drawing.Size(74, 20);
            this.RvcDgnField.TabIndex = 9;
            this.RvcDgnField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.RvcDgnField, "DGN");
            this.RvcDgnField.Value = new decimal(new int[] {
            131071,
            0,
            0,
            0});
            // 
            // RvcDataField
            // 
            this.RvcDataField.Location = new System.Drawing.Point(270, 3);
            this.RvcDataField.Name = "RvcDataField";
            this.RvcDataField.Size = new System.Drawing.Size(137, 20);
            this.RvcDataField.TabIndex = 6;
            this.RvcDataField.Text = "0011223344556677";
            this.RvcDataField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.RvcDataField, "Данные для передачи");
            // 
            // RvcMessageList
            // 
            this.RvcMessageList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RvcMessageList.FormattingEnabled = true;
            this.RvcMessageList.Location = new System.Drawing.Point(576, 206);
            this.RvcMessageList.Name = "RvcMessageList";
            this.RvcMessageList.Size = new System.Drawing.Size(627, 264);
            this.RvcMessageList.TabIndex = 27;
            this.toolTip1.SetToolTip(this.RvcMessageList, "Перечень различных RV-C сообщений");
            // 
            // ClearRvcButton
            // 
            this.ClearRvcButton.Location = new System.Drawing.Point(495, 173);
            this.ClearRvcButton.Name = "ClearRvcButton";
            this.ClearRvcButton.Size = new System.Drawing.Size(75, 23);
            this.ClearRvcButton.TabIndex = 28;
            this.ClearRvcButton.Text = "Clear RV-C";
            this.ClearRvcButton.UseVisualStyleBackColor = true;
            this.ClearRvcButton.Click += new System.EventHandler(this.ClearRvcButton_Click);
            // 
            // RvcSourceAdressField
            // 
            this.RvcSourceAdressField.Location = new System.Drawing.Point(209, 3);
            this.RvcSourceAdressField.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RvcSourceAdressField.Name = "RvcSourceAdressField";
            this.RvcSourceAdressField.Size = new System.Drawing.Size(55, 20);
            this.RvcSourceAdressField.TabIndex = 10;
            this.RvcSourceAdressField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.RvcSourceAdressField, "Source Adress");
            this.RvcSourceAdressField.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // RvcPriorityField
            // 
            this.RvcPriorityField.Location = new System.Drawing.Point(75, 3);
            this.RvcPriorityField.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.RvcPriorityField.Name = "RvcPriorityField";
            this.RvcPriorityField.Size = new System.Drawing.Size(48, 20);
            this.RvcPriorityField.TabIndex = 11;
            this.RvcPriorityField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.RvcPriorityField, "Приоритет сообщения");
            this.RvcPriorityField.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 477);
            this.Controls.Add(this.ClearRvcButton);
            this.Controls.Add(this.RvcMessageList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClearMessagesButton);
            this.Controls.Add(this.ClearLogButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortNamesListField);
            this.Controls.Add(this.LogField);
            this.Controls.Add(this.CanMessageList);
            this.Controls.Add(this.VersionField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BitrateField);
            this.Controls.Add(this.SetBitrateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CAN Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RvcDgnField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcSourceAdressField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcPriorityField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CanAdapter canAdapter;
        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Button LoopbackButton;
        private System.Windows.Forms.Button SilentButton;
        private System.Windows.Forms.Button SilentLoopbackButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox DataField;
        private System.Windows.Forms.CheckBox IdeField;
        private System.Windows.Forms.CheckBox RtrField;
        private System.Windows.Forms.NumericUpDown IdField;
        private System.Windows.Forms.Button SetBitrateButton;
        private System.Windows.Forms.NumericUpDown BitrateField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VersionField;
        private System.Windows.Forms.ListBox CanMessageList;
        private System.Windows.Forms.RichTextBox LogField;
        private System.Windows.Forms.NumericUpDown DlcField;
        private System.Windows.Forms.ComboBox PortNamesListField;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.Button ClearMessagesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RvcSendButton;
        private System.Windows.Forms.NumericUpDown RvcDgnField;
        private System.Windows.Forms.TextBox RvcDataField;
        private System.Windows.Forms.ListBox RvcMessageList;
        private System.Windows.Forms.Button ClearRvcButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown RvcSourceAdressField;
        private System.Windows.Forms.NumericUpDown RvcPriorityField;
    }
}

