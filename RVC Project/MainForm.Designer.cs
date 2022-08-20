namespace RVC_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SendButton = new System.Windows.Forms.Button();
            this.DataField = new System.Windows.Forms.TextBox();
            this.IdeField = new System.Windows.Forms.CheckBox();
            this.RtrField = new System.Windows.Forms.CheckBox();
            this.IdField = new System.Windows.Forms.NumericUpDown();
            this.CanMessageList = new System.Windows.Forms.ListBox();
            this.DlcField = new System.Windows.Forms.NumericUpDown();
            this.PortNamesListField = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ClearMessagesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RvcPriorityField = new System.Windows.Forms.NumericUpDown();
            this.RvcSourceAdressField = new System.Windows.Forms.NumericUpDown();
            this.RvcSendButton = new System.Windows.Forms.Button();
            this.RvcDgnField = new System.Windows.Forms.NumericUpDown();
            this.RvcDataField = new System.Windows.Forms.TextBox();
            this.ClearRvcButton = new System.Windows.Forms.Button();
            this.RvcMessageList = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.VerboseInfoField = new System.Windows.Forms.RichTextBox();
            this.ParametersPanel = new System.Windows.Forms.Panel();
            this.DgnListComboBox = new System.Windows.Forms.ComboBox();
            this.SendRvcButton = new System.Windows.Forms.Button();
            this.RvcMessagePreview = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.adverCanPage = new System.Windows.Forms.TabPage();
            this.adversCanVerboseField = new System.Windows.Forms.RichTextBox();
            this.AdversCanMessageList = new System.Windows.Forms.ListBox();
            this.adversCanLogField = new System.Windows.Forms.RichTextBox();
            this.rvcPage = new System.Windows.Forms.TabPage();
            this.regularCanPage = new System.Windows.Forms.TabPage();
            this.ListenButton = new System.Windows.Forms.Button();
            this.SelfReceptionButton = new System.Windows.Forms.Button();
            this.NormalButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RvcPriorityField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcSourceAdressField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcDgnField)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.adverCanPage.SuspendLayout();
            this.rvcPage.SuspendLayout();
            this.regularCanPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(3, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(77, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DataField
            // 
            this.DataField.Location = new System.Drawing.Point(350, 4);
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
            this.IdeField.Location = new System.Drawing.Point(88, 6);
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
            this.RtrField.Location = new System.Drawing.Point(133, 6);
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
            this.IdField.Location = new System.Drawing.Point(237, 4);
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
            this.CanMessageList.Location = new System.Drawing.Point(8, 45);
            this.CanMessageList.Name = "CanMessageList";
            this.CanMessageList.Size = new System.Drawing.Size(583, 484);
            this.CanMessageList.TabIndex = 14;
            this.toolTip1.SetToolTip(this.CanMessageList, "Перечень различных CAN сообщений");
            // 
            // DlcField
            // 
            this.DlcField.Location = new System.Drawing.Point(184, 4);
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
            this.PortNamesListField.Location = new System.Drawing.Point(116, 9);
            this.PortNamesListField.Name = "PortNamesListField";
            this.PortNamesListField.Size = new System.Drawing.Size(121, 21);
            this.PortNamesListField.TabIndex = 19;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(11, 8);
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
            // ClearMessagesButton
            // 
            this.ClearMessagesButton.Location = new System.Drawing.Point(493, 3);
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
            this.panel2.Controls.Add(this.ClearMessagesButton);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 32);
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
            this.panel3.Controls.Add(this.ClearRvcButton);
            this.panel3.Location = new System.Drawing.Point(6, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 32);
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
            this.RvcSourceAdressField.Location = new System.Drawing.Point(220, 3);
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
            this.RvcDataField.Location = new System.Drawing.Point(281, 3);
            this.RvcDataField.Name = "RvcDataField";
            this.RvcDataField.Size = new System.Drawing.Size(137, 20);
            this.RvcDataField.TabIndex = 6;
            this.RvcDataField.Text = "0011223344556677";
            this.RvcDataField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.RvcDataField, "Данные для передачи");
            this.RvcDataField.TextChanged += new System.EventHandler(this.RvcDataField_TextChanged);
            // 
            // ClearRvcButton
            // 
            this.ClearRvcButton.Location = new System.Drawing.Point(460, 2);
            this.ClearRvcButton.Name = "ClearRvcButton";
            this.ClearRvcButton.Size = new System.Drawing.Size(57, 23);
            this.ClearRvcButton.TabIndex = 28;
            this.ClearRvcButton.Text = "Clear list";
            this.ClearRvcButton.UseVisualStyleBackColor = true;
            this.ClearRvcButton.Click += new System.EventHandler(this.ClearRvcButton_Click);
            // 
            // RvcMessageList
            // 
            this.RvcMessageList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RvcMessageList.FormattingEnabled = true;
            this.RvcMessageList.ItemHeight = 16;
            this.RvcMessageList.Location = new System.Drawing.Point(6, 44);
            this.RvcMessageList.Name = "RvcMessageList";
            this.RvcMessageList.Size = new System.Drawing.Size(538, 804);
            this.RvcMessageList.TabIndex = 27;
            this.toolTip1.SetToolTip(this.RvcMessageList, "Перечень различных RV-C сообщений");
            this.RvcMessageList.SelectedIndexChanged += new System.EventHandler(this.RvcMessageList_SelectedIndexChanged);
            // 
            // VerboseInfoField
            // 
            this.VerboseInfoField.Location = new System.Drawing.Point(547, 7);
            this.VerboseInfoField.Name = "VerboseInfoField";
            this.VerboseInfoField.ReadOnly = true;
            this.VerboseInfoField.Size = new System.Drawing.Size(513, 271);
            this.VerboseInfoField.TabIndex = 29;
            this.VerboseInfoField.Text = "";
            // 
            // ParametersPanel
            // 
            this.ParametersPanel.AutoScroll = true;
            this.ParametersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ParametersPanel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametersPanel.Location = new System.Drawing.Point(547, 339);
            this.ParametersPanel.Name = "ParametersPanel";
            this.ParametersPanel.Size = new System.Drawing.Size(513, 336);
            this.ParametersPanel.TabIndex = 30;
            // 
            // DgnListComboBox
            // 
            this.DgnListComboBox.FormattingEnabled = true;
            this.DgnListComboBox.Location = new System.Drawing.Point(547, 312);
            this.DgnListComboBox.Name = "DgnListComboBox";
            this.DgnListComboBox.Size = new System.Drawing.Size(460, 21);
            this.DgnListComboBox.TabIndex = 0;
            this.DgnListComboBox.SelectedIndexChanged += new System.EventHandler(this.DgnListComboBox_SelectedIndexChanged);
            // 
            // SendRvcButton
            // 
            this.SendRvcButton.Location = new System.Drawing.Point(1013, 310);
            this.SendRvcButton.Name = "SendRvcButton";
            this.SendRvcButton.Size = new System.Drawing.Size(47, 23);
            this.SendRvcButton.TabIndex = 0;
            this.SendRvcButton.Text = "->";
            this.SendRvcButton.UseVisualStyleBackColor = true;
            this.SendRvcButton.Click += new System.EventHandler(this.SendRvcButton_Click);
            // 
            // RvcMessagePreview
            // 
            this.RvcMessagePreview.Location = new System.Drawing.Point(547, 284);
            this.RvcMessagePreview.Name = "RvcMessagePreview";
            this.RvcMessagePreview.Size = new System.Drawing.Size(513, 20);
            this.RvcMessagePreview.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.adverCanPage);
            this.tabControl1.Controls.Add(this.rvcPage);
            this.tabControl1.Controls.Add(this.regularCanPage);
            this.tabControl1.Location = new System.Drawing.Point(11, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 719);
            this.tabControl1.TabIndex = 33;
            // 
            // adverCanPage
            // 
            this.adverCanPage.Controls.Add(this.adversCanVerboseField);
            this.adverCanPage.Controls.Add(this.AdversCanMessageList);
            this.adverCanPage.Controls.Add(this.adversCanLogField);
            this.adverCanPage.Location = new System.Drawing.Point(4, 22);
            this.adverCanPage.Name = "adverCanPage";
            this.adverCanPage.Padding = new System.Windows.Forms.Padding(3);
            this.adverCanPage.Size = new System.Drawing.Size(1066, 693);
            this.adverCanPage.TabIndex = 1;
            this.adverCanPage.Text = "Advers CAN2 protocol";
            this.adverCanPage.UseVisualStyleBackColor = true;
            // 
            // adversCanVerboseField
            // 
            this.adversCanVerboseField.Location = new System.Drawing.Point(537, 3);
            this.adversCanVerboseField.Name = "adversCanVerboseField";
            this.adversCanVerboseField.ReadOnly = true;
            this.adversCanVerboseField.Size = new System.Drawing.Size(523, 312);
            this.adversCanVerboseField.TabIndex = 36;
            this.adversCanVerboseField.Text = "";
            // 
            // AdversCanMessageList
            // 
            this.AdversCanMessageList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdversCanMessageList.FormattingEnabled = true;
            this.AdversCanMessageList.ItemHeight = 14;
            this.AdversCanMessageList.Location = new System.Drawing.Point(6, 3);
            this.AdversCanMessageList.Name = "AdversCanMessageList";
            this.AdversCanMessageList.Size = new System.Drawing.Size(525, 312);
            this.AdversCanMessageList.TabIndex = 35;
            this.AdversCanMessageList.SelectedIndexChanged += new System.EventHandler(this.AdversCanMessageList_SelectedIndexChanged);
            // 
            // adversCanLogField
            // 
            this.adversCanLogField.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adversCanLogField.Location = new System.Drawing.Point(6, 321);
            this.adversCanLogField.Name = "adversCanLogField";
            this.adversCanLogField.Size = new System.Drawing.Size(1054, 393);
            this.adversCanLogField.TabIndex = 34;
            this.adversCanLogField.Text = "";
            // 
            // rvcPage
            // 
            this.rvcPage.Controls.Add(this.RvcMessageList);
            this.rvcPage.Controls.Add(this.SendRvcButton);
            this.rvcPage.Controls.Add(this.ParametersPanel);
            this.rvcPage.Controls.Add(this.RvcMessagePreview);
            this.rvcPage.Controls.Add(this.DgnListComboBox);
            this.rvcPage.Controls.Add(this.VerboseInfoField);
            this.rvcPage.Controls.Add(this.panel3);
            this.rvcPage.Location = new System.Drawing.Point(4, 22);
            this.rvcPage.Name = "rvcPage";
            this.rvcPage.Padding = new System.Windows.Forms.Padding(3);
            this.rvcPage.Size = new System.Drawing.Size(1066, 693);
            this.rvcPage.TabIndex = 0;
            this.rvcPage.Text = "RV-C protocol";
            this.rvcPage.UseVisualStyleBackColor = true;
            // 
            // regularCanPage
            // 
            this.regularCanPage.Controls.Add(this.CanMessageList);
            this.regularCanPage.Controls.Add(this.panel2);
            this.regularCanPage.Location = new System.Drawing.Point(4, 22);
            this.regularCanPage.Name = "regularCanPage";
            this.regularCanPage.Size = new System.Drawing.Size(1066, 693);
            this.regularCanPage.TabIndex = 2;
            this.regularCanPage.Text = "Basic CAN";
            this.regularCanPage.UseVisualStyleBackColor = true;
            // 
            // ListenButton
            // 
            this.ListenButton.Location = new System.Drawing.Point(447, 8);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(93, 23);
            this.ListenButton.TabIndex = 2;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // SelfReceptionButton
            // 
            this.SelfReceptionButton.Location = new System.Drawing.Point(546, 8);
            this.SelfReceptionButton.Name = "SelfReceptionButton";
            this.SelfReceptionButton.Size = new System.Drawing.Size(93, 23);
            this.SelfReceptionButton.TabIndex = 1;
            this.SelfReceptionButton.Text = "Self Reception";
            this.SelfReceptionButton.UseVisualStyleBackColor = true;
            this.SelfReceptionButton.Click += new System.EventHandler(this.SelfReceptionButton_Click);
            // 
            // NormalButton
            // 
            this.NormalButton.Location = new System.Drawing.Point(348, 8);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(93, 23);
            this.NormalButton.TabIndex = 0;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = true;
            this.NormalButton.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(645, 8);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(93, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(744, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "250";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "kB/s";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SelfReceptionButton);
            this.Controls.Add(this.NormalButton);
            this.Controls.Add(this.ListenButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortNamesListField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "11111111";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RvcPriorityField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcSourceAdressField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcDgnField)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.adverCanPage.ResumeLayout(false);
            this.rvcPage.ResumeLayout(false);
            this.rvcPage.PerformLayout();
            this.regularCanPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CanAdapter canAdapter;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox DataField;
        private System.Windows.Forms.CheckBox IdeField;
        private System.Windows.Forms.CheckBox RtrField;
        private System.Windows.Forms.NumericUpDown IdField;
        private System.Windows.Forms.ListBox CanMessageList;
        private System.Windows.Forms.NumericUpDown DlcField;
        private System.Windows.Forms.ComboBox PortNamesListField;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ClearMessagesButton;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Button SendRvcButton;
        private System.Windows.Forms.TextBox RvcMessagePreview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage rvcPage;
        private System.Windows.Forms.TabPage adverCanPage;
        private System.Windows.Forms.RichTextBox adversCanLogField;
        private System.Windows.Forms.ListBox AdversCanMessageList;
        private System.Windows.Forms.RichTextBox adversCanVerboseField;
        private System.Windows.Forms.TabPage regularCanPage;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Button SelfReceptionButton;
        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

