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
            this.SelfReceptionButton = new System.Windows.Forms.Button();
            this.ListenButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.DataField = new System.Windows.Forms.TextBox();
            this.IdeField = new System.Windows.Forms.CheckBox();
            this.RtrField = new System.Windows.Forms.CheckBox();
            this.IdField = new System.Windows.Forms.NumericUpDown();
            this.CanMessageList = new System.Windows.Forms.ListBox();
            this.LogField = new System.Windows.Forms.RichTextBox();
            this.DlcField = new System.Windows.Forms.NumericUpDown();
            this.PortNamesListField = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.ClearMessagesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RvcPriorityField = new System.Windows.Forms.NumericUpDown();
            this.RvcSourceAdressField = new System.Windows.Forms.NumericUpDown();
            this.RvcSendButton = new System.Windows.Forms.Button();
            this.RvcDgnField = new System.Windows.Forms.NumericUpDown();
            this.RvcDataField = new System.Windows.Forms.TextBox();
            this.RvcMessageList = new System.Windows.Forms.ListBox();
            this.ClearRvcButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.VerboseInfoField = new System.Windows.Forms.RichTextBox();
            this.ParametersPanel = new System.Windows.Forms.Panel();
            this.DgnListComboBox = new System.Windows.Forms.ComboBox();
            this.WriteToLogCHeckBox = new System.Windows.Forms.CheckBox();
            this.SendRvcButton = new System.Windows.Forms.Button();
            this.RvcMessagePreview = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rvcPage = new System.Windows.Forms.TabPage();
            this.adverCanPAge = new System.Windows.Forms.TabPage();
            this.adversCanLogField = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RvcPriorityField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcSourceAdressField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcDgnField)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.rvcPage.SuspendLayout();
            this.adverCanPAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // NormalButton
            // 
            this.NormalButton.Location = new System.Drawing.Point(3, 4);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(93, 23);
            this.NormalButton.TabIndex = 0;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = true;
            this.NormalButton.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // SelfReceptionButton
            // 
            this.SelfReceptionButton.Location = new System.Drawing.Point(4, 31);
            this.SelfReceptionButton.Name = "SelfReceptionButton";
            this.SelfReceptionButton.Size = new System.Drawing.Size(93, 23);
            this.SelfReceptionButton.TabIndex = 1;
            this.SelfReceptionButton.Text = "Self Reception";
            this.SelfReceptionButton.UseVisualStyleBackColor = true;
            this.SelfReceptionButton.Click += new System.EventHandler(this.SelfReceptionButton_Click);
            // 
            // ListenButton
            // 
            this.ListenButton.Location = new System.Drawing.Point(100, 4);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(93, 23);
            this.ListenButton.TabIndex = 2;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(77, 23);
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
            this.DataField.TextChanged += new System.EventHandler(this.DataField_TextChanged);
            // 
            // IdeField
            // 
            this.IdeField.AutoSize = true;
            this.IdeField.Checked = true;
            this.IdeField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IdeField.Location = new System.Drawing.Point(88, 5);
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
            this.RtrField.Location = new System.Drawing.Point(133, 5);
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
            // CanMessageList
            // 
            this.CanMessageList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CanMessageList.FormattingEnabled = true;
            this.CanMessageList.ItemHeight = 16;
            this.CanMessageList.Location = new System.Drawing.Point(0, 210);
            this.CanMessageList.Name = "CanMessageList";
            this.CanMessageList.Size = new System.Drawing.Size(568, 356);
            this.CanMessageList.TabIndex = 14;
            this.toolTip1.SetToolTip(this.CanMessageList, "Перечень различных CAN сообщений");
            // 
            // LogField
            // 
            this.LogField.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogField.Location = new System.Drawing.Point(0, 569);
            this.LogField.Name = "LogField";
            this.LogField.Size = new System.Drawing.Size(570, 180);
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
            this.RefreshButton.Text = "Refresh port list";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.NormalButton);
            this.panel1.Controls.Add(this.SelfReceptionButton);
            this.panel1.Controls.Add(this.ListenButton);
            this.panel1.Location = new System.Drawing.Point(8, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 85);
            this.panel1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "125",
            "250",
            "500",
            "800",
            "1000"});
            this.comboBox1.Location = new System.Drawing.Point(3, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "250";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(100, 32);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(93, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(495, 68);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(75, 23);
            this.ClearLogButton.TabIndex = 23;
            this.ClearLogButton.Text = "Clear Log";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // ClearMessagesButton
            // 
            this.ClearMessagesButton.Location = new System.Drawing.Point(495, 10);
            this.ClearMessagesButton.Name = "ClearMessagesButton";
            this.ClearMessagesButton.Size = new System.Drawing.Size(75, 23);
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
            this.panel3.Size = new System.Drawing.Size(425, 32);
            this.panel3.TabIndex = 26;
            // 
            // RvcPriorityField
            // 
            this.RvcPriorityField.Location = new System.Drawing.Point(86, 3);
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
            // RvcSourceAdressField
            // 
            this.RvcSourceAdressField.Location = new System.Drawing.Point(220, 2);
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
            // RvcSendButton
            // 
            this.RvcSendButton.Location = new System.Drawing.Point(3, 2);
            this.RvcSendButton.Name = "RvcSendButton";
            this.RvcSendButton.Size = new System.Drawing.Size(77, 23);
            this.RvcSendButton.TabIndex = 4;
            this.RvcSendButton.Text = "Send RV-C";
            this.RvcSendButton.UseVisualStyleBackColor = true;
            this.RvcSendButton.Click += new System.EventHandler(this.RvcSendButton_Click);
            // 
            // RvcDgnField
            // 
            this.RvcDgnField.Hexadecimal = true;
            this.RvcDgnField.Location = new System.Drawing.Point(140, 3);
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
            this.RvcDataField.Location = new System.Drawing.Point(281, 2);
            this.RvcDataField.Name = "RvcDataField";
            this.RvcDataField.Size = new System.Drawing.Size(137, 20);
            this.RvcDataField.TabIndex = 6;
            this.RvcDataField.Text = "0011223344556677";
            this.RvcDataField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.RvcDataField, "Данные для передачи");
            this.RvcDataField.TextChanged += new System.EventHandler(this.RvcDataField_TextChanged);
            // 
            // RvcMessageList
            // 
            this.RvcMessageList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RvcMessageList.FormattingEnabled = true;
            this.RvcMessageList.ItemHeight = 16;
            this.RvcMessageList.Location = new System.Drawing.Point(3, 6);
            this.RvcMessageList.Name = "RvcMessageList";
            this.RvcMessageList.Size = new System.Drawing.Size(538, 708);
            this.RvcMessageList.TabIndex = 27;
            this.toolTip1.SetToolTip(this.RvcMessageList, "Перечень различных RV-C сообщений");
            this.RvcMessageList.SelectedIndexChanged += new System.EventHandler(this.RvcMessageList_SelectedIndexChanged);
            // 
            // ClearRvcButton
            // 
            this.ClearRvcButton.Location = new System.Drawing.Point(495, 39);
            this.ClearRvcButton.Name = "ClearRvcButton";
            this.ClearRvcButton.Size = new System.Drawing.Size(75, 23);
            this.ClearRvcButton.TabIndex = 28;
            this.ClearRvcButton.Text = "Clear RV-C";
            this.ClearRvcButton.UseVisualStyleBackColor = true;
            this.ClearRvcButton.Click += new System.EventHandler(this.ClearRvcButton_Click);
            // 
            // VerboseInfoField
            // 
            this.VerboseInfoField.Location = new System.Drawing.Point(547, 7);
            this.VerboseInfoField.Name = "VerboseInfoField";
            this.VerboseInfoField.ReadOnly = true;
            this.VerboseInfoField.Size = new System.Drawing.Size(496, 188);
            this.VerboseInfoField.TabIndex = 29;
            this.VerboseInfoField.Text = "";
            // 
            // ParametersPanel
            // 
            this.ParametersPanel.AutoScroll = true;
            this.ParametersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ParametersPanel.Location = new System.Drawing.Point(547, 254);
            this.ParametersPanel.Name = "ParametersPanel";
            this.ParametersPanel.Size = new System.Drawing.Size(496, 460);
            this.ParametersPanel.TabIndex = 30;
            // 
            // DgnListComboBox
            // 
            this.DgnListComboBox.FormattingEnabled = true;
            this.DgnListComboBox.Location = new System.Drawing.Point(547, 227);
            this.DgnListComboBox.Name = "DgnListComboBox";
            this.DgnListComboBox.Size = new System.Drawing.Size(441, 21);
            this.DgnListComboBox.TabIndex = 0;
            this.DgnListComboBox.SelectedIndexChanged += new System.EventHandler(this.DgnListComboBox_SelectedIndexChanged);
            // 
            // WriteToLogCHeckBox
            // 
            this.WriteToLogCHeckBox.AutoSize = true;
            this.WriteToLogCHeckBox.Location = new System.Drawing.Point(524, 183);
            this.WriteToLogCHeckBox.Name = "WriteToLogCHeckBox";
            this.WriteToLogCHeckBox.Size = new System.Drawing.Size(44, 17);
            this.WriteToLogCHeckBox.TabIndex = 31;
            this.WriteToLogCHeckBox.Text = "Log";
            this.WriteToLogCHeckBox.UseVisualStyleBackColor = true;
            // 
            // SendRvcButton
            // 
            this.SendRvcButton.Location = new System.Drawing.Point(994, 227);
            this.SendRvcButton.Name = "SendRvcButton";
            this.SendRvcButton.Size = new System.Drawing.Size(30, 23);
            this.SendRvcButton.TabIndex = 0;
            this.SendRvcButton.Text = "->";
            this.SendRvcButton.UseVisualStyleBackColor = true;
            this.SendRvcButton.Click += new System.EventHandler(this.SendRvcButton_Click);
            // 
            // RvcMessagePreview
            // 
            this.RvcMessagePreview.Location = new System.Drawing.Point(547, 201);
            this.RvcMessagePreview.Name = "RvcMessagePreview";
            this.RvcMessagePreview.Size = new System.Drawing.Size(477, 20);
            this.RvcMessagePreview.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.rvcPage);
            this.tabControl1.Controls.Add(this.adverCanPAge);
            this.tabControl1.Location = new System.Drawing.Point(587, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1057, 746);
            this.tabControl1.TabIndex = 33;
            // 
            // rvcPage
            // 
            this.rvcPage.Controls.Add(this.RvcMessageList);
            this.rvcPage.Controls.Add(this.SendRvcButton);
            this.rvcPage.Controls.Add(this.ParametersPanel);
            this.rvcPage.Controls.Add(this.RvcMessagePreview);
            this.rvcPage.Controls.Add(this.DgnListComboBox);
            this.rvcPage.Controls.Add(this.VerboseInfoField);
            this.rvcPage.Location = new System.Drawing.Point(4, 22);
            this.rvcPage.Name = "rvcPage";
            this.rvcPage.Padding = new System.Windows.Forms.Padding(3);
            this.rvcPage.Size = new System.Drawing.Size(1049, 720);
            this.rvcPage.TabIndex = 0;
            this.rvcPage.Text = "RV-C";
            this.rvcPage.UseVisualStyleBackColor = true;
            // 
            // adverCanPAge
            // 
            this.adverCanPAge.Controls.Add(this.listBox1);
            this.adverCanPAge.Controls.Add(this.adversCanLogField);
            this.adverCanPAge.Location = new System.Drawing.Point(4, 22);
            this.adverCanPAge.Name = "adverCanPAge";
            this.adverCanPAge.Padding = new System.Windows.Forms.Padding(3);
            this.adverCanPAge.Size = new System.Drawing.Size(1049, 720);
            this.adverCanPAge.TabIndex = 1;
            this.adverCanPAge.Text = "Advers CAN";
            this.adverCanPAge.UseVisualStyleBackColor = true;
            // 
            // adversCanLogField
            // 
            this.adversCanLogField.Location = new System.Drawing.Point(6, 330);
            this.adversCanLogField.Name = "adversCanLogField";
            this.adversCanLogField.Size = new System.Drawing.Size(1036, 384);
            this.adversCanLogField.TabIndex = 34;
            this.adversCanLogField.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1043, 316);
            this.listBox1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 761);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.WriteToLogCHeckBox);
            this.Controls.Add(this.ClearRvcButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CAN Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RvcPriorityField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcSourceAdressField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcDgnField)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.rvcPage.ResumeLayout(false);
            this.rvcPage.PerformLayout();
            this.adverCanPAge.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CanAdapter canAdapter;
        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Button SelfReceptionButton;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox DataField;
        private System.Windows.Forms.CheckBox IdeField;
        private System.Windows.Forms.CheckBox RtrField;
        private System.Windows.Forms.NumericUpDown IdField;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RvcSendButton;
        private System.Windows.Forms.NumericUpDown RvcDgnField;
        private System.Windows.Forms.TextBox RvcDataField;
        private System.Windows.Forms.ListBox RvcMessageList;
        private System.Windows.Forms.Button ClearRvcButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown RvcSourceAdressField;
        private System.Windows.Forms.NumericUpDown RvcPriorityField;
        private System.Windows.Forms.RichTextBox VerboseInfoField;
        private System.Windows.Forms.Panel ParametersPanel;
        private System.Windows.Forms.ComboBox DgnListComboBox;
        private System.Windows.Forms.CheckBox WriteToLogCHeckBox;
        private System.Windows.Forms.Button SendRvcButton;
        private System.Windows.Forms.TextBox RvcMessagePreview;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage rvcPage;
        private System.Windows.Forms.TabPage adverCanPAge;
        private System.Windows.Forms.RichTextBox adversCanLogField;
        private System.Windows.Forms.ListBox listBox1;
    }
}

