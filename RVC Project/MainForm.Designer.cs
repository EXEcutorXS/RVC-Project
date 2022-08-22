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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.AC2PtabControl = new System.Windows.Forms.TabControl();
            this.msgManagerTab = new System.Windows.Forms.TabPage();
            this.AC2PSendButton = new System.Windows.Forms.Button();
            this.AC2PDataField = new System.Windows.Forms.TextBox();
            this.AC2PAdrField = new System.Windows.Forms.TextBox();
            this.AC2PTypeField = new System.Windows.Forms.TextBox();
            this.AC2PPGNField = new System.Windows.Forms.TextBox();
            this.clearAC2PlistButton = new System.Windows.Forms.Button();
            this.AC2PMessageList = new System.Windows.Forms.ListBox();
            this.adversCanLogField = new System.Windows.Forms.RichTextBox();
            this.adversCanVerboseField = new System.Windows.Forms.RichTextBox();
            this.deviceControlTab = new System.Windows.Forms.TabPage();
            this.GraphTab = new System.Windows.Forms.TabPage();
            this.ManualModeTab = new System.Windows.Forms.TabPage();
            this.DeviceConfigTab = new System.Windows.Forms.TabPage();
            this.BindButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.deviceAdrField = new System.Windows.Forms.TextBox();
            this.deviceTypeField = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.connectedDeviceListField = new System.Windows.Forms.ComboBox();
            this.FirmwareTab = new System.Windows.Forms.TabPage();
            this.rvcPage = new System.Windows.Forms.TabPage();
            this.regularCanPage = new System.Windows.Forms.TabPage();
            this.CanMessageListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ideColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtrColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dlcColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListenButton = new System.Windows.Forms.Button();
            this.SelfReceptionButton = new System.Windows.Forms.Button();
            this.NormalButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSample = new System.Windows.Forms.Button();
            this.paramtersList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlcField)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RvcPriorityField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcSourceAdressField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RvcDgnField)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.adverCanPage.SuspendLayout();
            this.AC2PtabControl.SuspendLayout();
            this.msgManagerTab.SuspendLayout();
            this.DeviceConfigTab.SuspendLayout();
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
            this.CanMessageList.Size = new System.Drawing.Size(489, 484);
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
            this.panel2.Size = new System.Drawing.Size(793, 32);
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
            this.adverCanPage.Controls.Add(this.AC2PtabControl);
            this.adverCanPage.Location = new System.Drawing.Point(4, 22);
            this.adverCanPage.Name = "adverCanPage";
            this.adverCanPage.Padding = new System.Windows.Forms.Padding(3);
            this.adverCanPage.Size = new System.Drawing.Size(1066, 693);
            this.adverCanPage.TabIndex = 1;
            this.adverCanPage.Text = "Advers CAN2 protocol";
            this.adverCanPage.UseVisualStyleBackColor = true;
            // 
            // AC2PtabControl
            // 
            this.AC2PtabControl.Controls.Add(this.msgManagerTab);
            this.AC2PtabControl.Controls.Add(this.deviceControlTab);
            this.AC2PtabControl.Controls.Add(this.GraphTab);
            this.AC2PtabControl.Controls.Add(this.ManualModeTab);
            this.AC2PtabControl.Controls.Add(this.DeviceConfigTab);
            this.AC2PtabControl.Controls.Add(this.FirmwareTab);
            this.AC2PtabControl.Location = new System.Drawing.Point(6, 6);
            this.AC2PtabControl.Name = "AC2PtabControl";
            this.AC2PtabControl.SelectedIndex = 0;
            this.AC2PtabControl.Size = new System.Drawing.Size(1050, 687);
            this.AC2PtabControl.TabIndex = 37;
            // 
            // msgManagerTab
            // 
            this.msgManagerTab.Controls.Add(this.AC2PSendButton);
            this.msgManagerTab.Controls.Add(this.AC2PDataField);
            this.msgManagerTab.Controls.Add(this.AC2PAdrField);
            this.msgManagerTab.Controls.Add(this.AC2PTypeField);
            this.msgManagerTab.Controls.Add(this.AC2PPGNField);
            this.msgManagerTab.Controls.Add(this.clearAC2PlistButton);
            this.msgManagerTab.Controls.Add(this.AC2PMessageList);
            this.msgManagerTab.Controls.Add(this.adversCanLogField);
            this.msgManagerTab.Controls.Add(this.adversCanVerboseField);
            this.msgManagerTab.Location = new System.Drawing.Point(4, 22);
            this.msgManagerTab.Name = "msgManagerTab";
            this.msgManagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.msgManagerTab.Size = new System.Drawing.Size(1042, 661);
            this.msgManagerTab.TabIndex = 0;
            this.msgManagerTab.Text = "Message manager";
            this.msgManagerTab.UseVisualStyleBackColor = true;
            // 
            // AC2PSendButton
            // 
            this.AC2PSendButton.Location = new System.Drawing.Point(381, 309);
            this.AC2PSendButton.Name = "AC2PSendButton";
            this.AC2PSendButton.Size = new System.Drawing.Size(43, 23);
            this.AC2PSendButton.TabIndex = 42;
            this.AC2PSendButton.Text = "->";
            this.AC2PSendButton.UseVisualStyleBackColor = true;
            this.AC2PSendButton.Click += new System.EventHandler(this.AC2PSendButton_Click);
            // 
            // AC2PDataField
            // 
            this.AC2PDataField.Location = new System.Drawing.Point(147, 310);
            this.AC2PDataField.Name = "AC2PDataField";
            this.AC2PDataField.Size = new System.Drawing.Size(222, 20);
            this.AC2PDataField.TabIndex = 41;
            this.AC2PDataField.Text = "FFFFFFFFFFFFFFFF";
            // 
            // AC2PAdrField
            // 
            this.AC2PAdrField.Location = new System.Drawing.Point(91, 310);
            this.AC2PAdrField.Name = "AC2PAdrField";
            this.AC2PAdrField.Size = new System.Drawing.Size(50, 20);
            this.AC2PAdrField.TabIndex = 40;
            this.AC2PAdrField.Text = "0";
            // 
            // AC2PTypeField
            // 
            this.AC2PTypeField.Location = new System.Drawing.Point(43, 310);
            this.AC2PTypeField.Name = "AC2PTypeField";
            this.AC2PTypeField.Size = new System.Drawing.Size(42, 20);
            this.AC2PTypeField.TabIndex = 39;
            this.AC2PTypeField.Text = "126";
            // 
            // AC2PPGNField
            // 
            this.AC2PPGNField.Location = new System.Drawing.Point(6, 310);
            this.AC2PPGNField.Name = "AC2PPGNField";
            this.AC2PPGNField.Size = new System.Drawing.Size(31, 20);
            this.AC2PPGNField.TabIndex = 38;
            this.AC2PPGNField.Text = "3";
            // 
            // clearAC2PlistButton
            // 
            this.clearAC2PlistButton.Location = new System.Drawing.Point(430, 309);
            this.clearAC2PlistButton.Name = "clearAC2PlistButton";
            this.clearAC2PlistButton.Size = new System.Drawing.Size(75, 23);
            this.clearAC2PlistButton.TabIndex = 37;
            this.clearAC2PlistButton.Text = "Clear";
            this.clearAC2PlistButton.UseVisualStyleBackColor = true;
            this.clearAC2PlistButton.Click += new System.EventHandler(this.clearAC2PlistButton_Click);
            // 
            // AC2PMessageList
            // 
            this.AC2PMessageList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AC2PMessageList.FormattingEnabled = true;
            this.AC2PMessageList.ItemHeight = 14;
            this.AC2PMessageList.Location = new System.Drawing.Point(6, 6);
            this.AC2PMessageList.Name = "AC2PMessageList";
            this.AC2PMessageList.Size = new System.Drawing.Size(499, 298);
            this.AC2PMessageList.TabIndex = 35;
            this.AC2PMessageList.SelectedIndexChanged += new System.EventHandler(this.AdversCanMessageList_SelectedIndexChanged);
            // 
            // adversCanLogField
            // 
            this.adversCanLogField.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adversCanLogField.Location = new System.Drawing.Point(6, 338);
            this.adversCanLogField.Name = "adversCanLogField";
            this.adversCanLogField.Size = new System.Drawing.Size(1033, 317);
            this.adversCanLogField.TabIndex = 34;
            this.adversCanLogField.Text = "";
            // 
            // adversCanVerboseField
            // 
            this.adversCanVerboseField.Location = new System.Drawing.Point(511, 6);
            this.adversCanVerboseField.Name = "adversCanVerboseField";
            this.adversCanVerboseField.ReadOnly = true;
            this.adversCanVerboseField.Size = new System.Drawing.Size(528, 326);
            this.adversCanVerboseField.TabIndex = 36;
            this.adversCanVerboseField.Text = "";
            // 
            // deviceControlTab
            // 
            this.deviceControlTab.Location = new System.Drawing.Point(4, 22);
            this.deviceControlTab.Name = "deviceControlTab";
            this.deviceControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.deviceControlTab.Size = new System.Drawing.Size(1042, 661);
            this.deviceControlTab.TabIndex = 1;
            this.deviceControlTab.Text = "Device Control";
            this.deviceControlTab.UseVisualStyleBackColor = true;
            // 
            // GraphTab
            // 
            this.GraphTab.Location = new System.Drawing.Point(4, 22);
            this.GraphTab.Name = "GraphTab";
            this.GraphTab.Size = new System.Drawing.Size(1042, 661);
            this.GraphTab.TabIndex = 2;
            this.GraphTab.Text = "Graph";
            this.GraphTab.UseVisualStyleBackColor = true;
            // 
            // ManualModeTab
            // 
            this.ManualModeTab.Location = new System.Drawing.Point(4, 22);
            this.ManualModeTab.Name = "ManualModeTab";
            this.ManualModeTab.Size = new System.Drawing.Size(1042, 661);
            this.ManualModeTab.TabIndex = 3;
            this.ManualModeTab.Text = "Manual Mode";
            this.ManualModeTab.UseVisualStyleBackColor = true;
            // 
            // DeviceConfigTab
            // 
            this.DeviceConfigTab.Controls.Add(this.paramtersList);
            this.DeviceConfigTab.Controls.Add(this.BindButton);
            this.DeviceConfigTab.Controls.Add(this.richTextBox1);
            this.DeviceConfigTab.Controls.Add(this.deviceAdrField);
            this.DeviceConfigTab.Controls.Add(this.deviceTypeField);
            this.DeviceConfigTab.Controls.Add(this.Read);
            this.DeviceConfigTab.Controls.Add(this.searchButton);
            this.DeviceConfigTab.Controls.Add(this.connectedDeviceListField);
            this.DeviceConfigTab.Location = new System.Drawing.Point(4, 22);
            this.DeviceConfigTab.Name = "DeviceConfigTab";
            this.DeviceConfigTab.Size = new System.Drawing.Size(1042, 661);
            this.DeviceConfigTab.TabIndex = 4;
            this.DeviceConfigTab.Text = "Device configurator";
            this.DeviceConfigTab.UseVisualStyleBackColor = true;
            // 
            // BindButton
            // 
            this.BindButton.Location = new System.Drawing.Point(710, 11);
            this.BindButton.Name = "BindButton";
            this.BindButton.Size = new System.Drawing.Size(75, 23);
            this.BindButton.TabIndex = 7;
            this.BindButton.Text = "Bind";
            this.BindButton.UseVisualStyleBackColor = true;
            this.BindButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 352);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1009, 290);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // deviceAdrField
            // 
            this.deviceAdrField.Location = new System.Drawing.Point(495, 12);
            this.deviceAdrField.Name = "deviceAdrField";
            this.deviceAdrField.Size = new System.Drawing.Size(47, 20);
            this.deviceAdrField.TabIndex = 5;
            this.deviceAdrField.Text = "0";
            // 
            // deviceTypeField
            // 
            this.deviceTypeField.Location = new System.Drawing.Point(442, 12);
            this.deviceTypeField.Name = "deviceTypeField";
            this.deviceTypeField.Size = new System.Drawing.Size(47, 20);
            this.deviceTypeField.TabIndex = 4;
            this.deviceTypeField.Text = "126";
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(629, 11);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(75, 23);
            this.Read.TabIndex = 3;
            this.Read.Text = "Read All";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(548, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // connectedDeviceListField
            // 
            this.connectedDeviceListField.FormattingEnabled = true;
            this.connectedDeviceListField.Location = new System.Drawing.Point(14, 11);
            this.connectedDeviceListField.Name = "connectedDeviceListField";
            this.connectedDeviceListField.Size = new System.Drawing.Size(422, 21);
            this.connectedDeviceListField.TabIndex = 1;
            this.connectedDeviceListField.SelectedIndexChanged += new System.EventHandler(this.connectedDeviceListField_SelectedIndexChanged);
            // 
            // FirmwareTab
            // 
            this.FirmwareTab.Location = new System.Drawing.Point(4, 22);
            this.FirmwareTab.Name = "FirmwareTab";
            this.FirmwareTab.Size = new System.Drawing.Size(1042, 661);
            this.FirmwareTab.TabIndex = 5;
            this.FirmwareTab.Text = "Firmware";
            this.FirmwareTab.UseVisualStyleBackColor = true;
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
            this.regularCanPage.Controls.Add(this.CanMessageListView);
            this.regularCanPage.Controls.Add(this.CanMessageList);
            this.regularCanPage.Controls.Add(this.panel2);
            this.regularCanPage.Location = new System.Drawing.Point(4, 22);
            this.regularCanPage.Name = "regularCanPage";
            this.regularCanPage.Size = new System.Drawing.Size(1066, 693);
            this.regularCanPage.TabIndex = 2;
            this.regularCanPage.Text = "Basic CAN";
            this.regularCanPage.UseVisualStyleBackColor = true;
            // 
            // CanMessageListView
            // 
            this.CanMessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.ideColumn,
            this.rtrColumn,
            this.dlcColumn,
            this.dataColumn});
            this.CanMessageListView.FullRowSelect = true;
            this.CanMessageListView.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.CanMessageListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.CanMessageListView.HideSelection = false;
            this.CanMessageListView.LabelEdit = true;
            this.CanMessageListView.Location = new System.Drawing.Point(503, 45);
            this.CanMessageListView.Name = "CanMessageListView";
            this.CanMessageListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CanMessageListView.Size = new System.Drawing.Size(532, 484);
            this.CanMessageListView.TabIndex = 26;
            this.CanMessageListView.UseCompatibleStateImageBehavior = false;
            this.CanMessageListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 59;
            // 
            // ideColumn
            // 
            this.ideColumn.Text = "IDE";
            this.ideColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ideColumn.Width = 30;
            // 
            // rtrColumn
            // 
            this.rtrColumn.Text = "RTR";
            this.rtrColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rtrColumn.Width = 36;
            // 
            // dlcColumn
            // 
            this.dlcColumn.Text = "DLC";
            this.dlcColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dlcColumn.Width = 33;
            // 
            // dataColumn
            // 
            this.dataColumn.Text = "DATA";
            this.dataColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dataColumn.Width = 228;
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
            // addSample
            // 
            this.addSample.Location = new System.Drawing.Point(918, 13);
            this.addSample.Name = "addSample";
            this.addSample.Size = new System.Drawing.Size(75, 23);
            this.addSample.TabIndex = 25;
            this.addSample.Text = "Sample";
            this.addSample.UseVisualStyleBackColor = true;
            this.addSample.Click += new System.EventHandler(this.addSample_Click);
            // 
            // paramtersList
            // 
            this.paramtersList.FormattingEnabled = true;
            this.paramtersList.Location = new System.Drawing.Point(14, 45);
            this.paramtersList.MultiColumn = true;
            this.paramtersList.Name = "paramtersList";
            this.paramtersList.Size = new System.Drawing.Size(1009, 290);
            this.paramtersList.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 761);
            this.Controls.Add(this.addSample);
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
            this.Text = "Advers CAN Tool";
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
            this.AC2PtabControl.ResumeLayout(false);
            this.msgManagerTab.ResumeLayout(false);
            this.msgManagerTab.PerformLayout();
            this.DeviceConfigTab.ResumeLayout(false);
            this.DeviceConfigTab.PerformLayout();
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
        private System.Windows.Forms.ListBox AC2PMessageList;
        private System.Windows.Forms.RichTextBox adversCanVerboseField;
        private System.Windows.Forms.TabPage regularCanPage;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Button SelfReceptionButton;
        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSample;
        private System.Windows.Forms.TabControl AC2PtabControl;
        private System.Windows.Forms.TabPage msgManagerTab;
        private System.Windows.Forms.TabPage deviceControlTab;
        private System.Windows.Forms.TabPage GraphTab;
        private System.Windows.Forms.TabPage ManualModeTab;
        private System.Windows.Forms.TabPage DeviceConfigTab;
        private System.Windows.Forms.TabPage FirmwareTab;
        private System.Windows.Forms.ListView CanMessageListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader ideColumn;
        private System.Windows.Forms.ColumnHeader rtrColumn;
        private System.Windows.Forms.ColumnHeader dlcColumn;
        private System.Windows.Forms.ColumnHeader dataColumn;
        private System.Windows.Forms.Button clearAC2PlistButton;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox connectedDeviceListField;
        private System.Windows.Forms.TextBox deviceTypeField;
        private System.Windows.Forms.TextBox deviceAdrField;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BindButton;
        private System.Windows.Forms.Button AC2PSendButton;
        private System.Windows.Forms.TextBox AC2PDataField;
        private System.Windows.Forms.TextBox AC2PAdrField;
        private System.Windows.Forms.TextBox AC2PTypeField;
        private System.Windows.Forms.TextBox AC2PPGNField;
        private System.Windows.Forms.ListBox paramtersList;
    }
}

