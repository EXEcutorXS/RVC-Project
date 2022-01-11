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
            this.MessageList = new System.Windows.Forms.ListBox();
            this.LogField = new System.Windows.Forms.RichTextBox();
            this.DlcField = new System.Windows.Forms.NumericUpDown();
            this.PortNamesListField = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AutoConnectButton = new System.Windows.Forms.Button();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.ClearMessagesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NormalButton
            // 
            this.NormalButton.Location = new System.Drawing.Point(3, 3);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(93, 23);
            this.NormalButton.TabIndex = 0;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = true;
            this.NormalButton.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // LoopbackButton
            // 
            this.LoopbackButton.Location = new System.Drawing.Point(3, 32);
            this.LoopbackButton.Name = "LoopbackButton";
            this.LoopbackButton.Size = new System.Drawing.Size(93, 23);
            this.LoopbackButton.TabIndex = 1;
            this.LoopbackButton.Text = "Loopback";
            this.LoopbackButton.UseVisualStyleBackColor = true;
            this.LoopbackButton.Click += new System.EventHandler(this.LoopbackButton_Click);
            // 
            // SilentButton
            // 
            this.SilentButton.Location = new System.Drawing.Point(102, 3);
            this.SilentButton.Name = "SilentButton";
            this.SilentButton.Size = new System.Drawing.Size(93, 23);
            this.SilentButton.TabIndex = 2;
            this.SilentButton.Text = "Silent";
            this.SilentButton.UseVisualStyleBackColor = true;
            this.SilentButton.Click += new System.EventHandler(this.SilentButton_Click);
            // 
            // SilentLoopbackButton
            // 
            this.SilentLoopbackButton.Location = new System.Drawing.Point(102, 32);
            this.SilentLoopbackButton.Name = "SilentLoopbackButton";
            this.SilentLoopbackButton.Size = new System.Drawing.Size(93, 23);
            this.SilentLoopbackButton.TabIndex = 3;
            this.SilentLoopbackButton.Text = "Silent Loopback";
            this.SilentLoopbackButton.UseVisualStyleBackColor = true;
            this.SilentLoopbackButton.Click += new System.EventHandler(this.SilentLoopbackButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(24, 104);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(93, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DataField
            // 
            this.DataField.Location = new System.Drawing.Point(403, 105);
            this.DataField.Name = "DataField";
            this.DataField.Size = new System.Drawing.Size(137, 20);
            this.DataField.TabIndex = 6;
            this.DataField.Text = "001122334455667788";
            this.DataField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IdeField
            // 
            this.IdeField.AutoSize = true;
            this.IdeField.Checked = true;
            this.IdeField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IdeField.Location = new System.Drawing.Point(132, 107);
            this.IdeField.Name = "IdeField";
            this.IdeField.Size = new System.Drawing.Size(44, 17);
            this.IdeField.TabIndex = 7;
            this.IdeField.Text = "IDE";
            this.IdeField.UseVisualStyleBackColor = true;
            this.IdeField.CheckedChanged += new System.EventHandler(this.IdeField_CheckedChanged);
            // 
            // RtrField
            // 
            this.RtrField.AutoSize = true;
            this.RtrField.Location = new System.Drawing.Point(182, 107);
            this.RtrField.Name = "RtrField";
            this.RtrField.Size = new System.Drawing.Size(49, 17);
            this.RtrField.TabIndex = 8;
            this.RtrField.Text = "RTR";
            this.RtrField.UseVisualStyleBackColor = true;
            // 
            // IdField
            // 
            this.IdField.Hexadecimal = true;
            this.IdField.Location = new System.Drawing.Point(290, 105);
            this.IdField.Maximum = new decimal(new int[] {
            536870911,
            0,
            0,
            0});
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(107, 20);
            this.IdField.TabIndex = 9;
            this.IdField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IdField.Value = new decimal(new int[] {
            536870911,
            0,
            0,
            0});
            // 
            // SetBitrateButton
            // 
            this.SetBitrateButton.Location = new System.Drawing.Point(230, 73);
            this.SetBitrateButton.Name = "SetBitrateButton";
            this.SetBitrateButton.Size = new System.Drawing.Size(93, 23);
            this.SetBitrateButton.TabIndex = 10;
            this.SetBitrateButton.Text = "Set bitrate";
            this.SetBitrateButton.UseVisualStyleBackColor = true;
            this.SetBitrateButton.Click += new System.EventHandler(this.SetBitrateButton_Click);
            // 
            // BitrateField
            // 
            this.BitrateField.Location = new System.Drawing.Point(329, 76);
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
            this.button1.Location = new System.Drawing.Point(230, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Version";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VersionField
            // 
            this.VersionField.Location = new System.Drawing.Point(329, 44);
            this.VersionField.Name = "VersionField";
            this.VersionField.ReadOnly = true;
            this.VersionField.Size = new System.Drawing.Size(152, 20);
            this.VersionField.TabIndex = 13;
            this.VersionField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageList
            // 
            this.MessageList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageList.FormattingEnabled = true;
            this.MessageList.Location = new System.Drawing.Point(559, 12);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(644, 134);
            this.MessageList.TabIndex = 14;
            // 
            // LogField
            // 
            this.LogField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogField.Location = new System.Drawing.Point(0, 181);
            this.LogField.Name = "LogField";
            this.LogField.Size = new System.Drawing.Size(1203, 382);
            this.LogField.TabIndex = 15;
            this.LogField.Text = "";
            // 
            // DlcField
            // 
            this.DlcField.Location = new System.Drawing.Point(237, 105);
            this.DlcField.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DlcField.Name = "DlcField";
            this.DlcField.Size = new System.Drawing.Size(47, 20);
            this.DlcField.TabIndex = 16;
            this.DlcField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DlcField.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // PortNamesListField
            // 
            this.PortNamesListField.FormattingEnabled = true;
            this.PortNamesListField.Location = new System.Drawing.Point(132, 10);
            this.PortNamesListField.Name = "PortNamesListField";
            this.PortNamesListField.Size = new System.Drawing.Size(121, 21);
            this.PortNamesListField.TabIndex = 19;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(27, 10);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(99, 23);
            this.ConnectButton.TabIndex = 20;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(259, 8);
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
            this.panel1.Controls.Add(this.NormalButton);
            this.panel1.Controls.Add(this.LoopbackButton);
            this.panel1.Controls.Add(this.SilentButton);
            this.panel1.Controls.Add(this.SilentLoopbackButton);
            this.panel1.Location = new System.Drawing.Point(24, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 60);
            this.panel1.TabIndex = 22;
            // 
            // AutoConnectButton
            // 
            this.AutoConnectButton.Location = new System.Drawing.Point(364, 8);
            this.AutoConnectButton.Name = "AutoConnectButton";
            this.AutoConnectButton.Size = new System.Drawing.Size(99, 23);
            this.AutoConnectButton.TabIndex = 17;
            this.AutoConnectButton.Text = "AutoConnect";
            this.AutoConnectButton.UseVisualStyleBackColor = true;
            this.AutoConnectButton.Click += new System.EventHandler(this.AutoConnectButton_Click);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(1116, 152);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(75, 23);
            this.ClearLogButton.TabIndex = 23;
            this.ClearLogButton.Text = "Clear Log";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // ClearMessagesButton
            // 
            this.ClearMessagesButton.Location = new System.Drawing.Point(1016, 152);
            this.ClearMessagesButton.Name = "ClearMessagesButton";
            this.ClearMessagesButton.Size = new System.Drawing.Size(94, 23);
            this.ClearMessagesButton.TabIndex = 24;
            this.ClearMessagesButton.Text = "Clear Messages";
            this.ClearMessagesButton.UseVisualStyleBackColor = true;
            this.ClearMessagesButton.Click += new System.EventHandler(this.ClearMessagesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 563);
            this.Controls.Add(this.ClearMessagesButton);
            this.Controls.Add(this.ClearLogButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortNamesListField);
            this.Controls.Add(this.AutoConnectButton);
            this.Controls.Add(this.DlcField);
            this.Controls.Add(this.LogField);
            this.Controls.Add(this.MessageList);
            this.Controls.Add(this.VersionField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BitrateField);
            this.Controls.Add(this.SetBitrateButton);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.RtrField);
            this.Controls.Add(this.IdeField);
            this.Controls.Add(this.DataField);
            this.Controls.Add(this.SendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CAN Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox MessageList;
        private System.Windows.Forms.RichTextBox LogField;
        private System.Windows.Forms.NumericUpDown DlcField;
        private System.Windows.Forms.ComboBox PortNamesListField;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AutoConnectButton;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.Button ClearMessagesButton;
    }
}

