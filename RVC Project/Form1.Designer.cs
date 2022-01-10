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
            this.portNameSelector = new System.Windows.Forms.ComboBox();
            this.portButton = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idField = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.dataField = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rvcData = new System.Windows.Forms.TextBox();
            this.rvcDgn = new System.Windows.Forms.TextBox();
            this.rvcSA = new System.Windows.Forms.TextBox();
            this.rvcPriority = new System.Windows.Forms.TextBox();
            this.rvcSendButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portNameSelector
            // 
            this.portNameSelector.FormattingEnabled = true;
            this.portNameSelector.Location = new System.Drawing.Point(985, 12);
            this.portNameSelector.Name = "portNameSelector";
            this.portNameSelector.Size = new System.Drawing.Size(140, 21);
            this.portNameSelector.TabIndex = 1;
            // 
            // portButton
            // 
            this.portButton.Location = new System.Drawing.Point(1131, 12);
            this.portButton.Name = "portButton";
            this.portButton.Size = new System.Drawing.Size(75, 23);
            this.portButton.TabIndex = 2;
            this.portButton.Text = "Open";
            this.portButton.UseVisualStyleBackColor = true;
            this.portButton.Click += new System.EventHandler(this.portButton_Click);
            // 
            // serialPort
            // 
            this.serialPort.ReadBufferSize = 40960;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(805, 41);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(76, 20);
            this.idField.TabIndex = 4;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(1131, 41);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // dataField
            // 
            this.dataField.Location = new System.Drawing.Point(885, 41);
            this.dataField.Name = "dataField";
            this.dataField.Size = new System.Drawing.Size(240, 20);
            this.dataField.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(768, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "8";
            // 
            // rvcData
            // 
            this.rvcData.Location = new System.Drawing.Point(885, 72);
            this.rvcData.Name = "rvcData";
            this.rvcData.Size = new System.Drawing.Size(240, 20);
            this.rvcData.TabIndex = 8;
            // 
            // rvcDgn
            // 
            this.rvcDgn.Location = new System.Drawing.Point(744, 72);
            this.rvcDgn.Name = "rvcDgn";
            this.rvcDgn.Size = new System.Drawing.Size(76, 20);
            this.rvcDgn.TabIndex = 9;
            // 
            // rvcSA
            // 
            this.rvcSA.Location = new System.Drawing.Point(826, 73);
            this.rvcSA.Name = "rvcSA";
            this.rvcSA.Size = new System.Drawing.Size(55, 20);
            this.rvcSA.TabIndex = 10;
            // 
            // rvcPriority
            // 
            this.rvcPriority.Location = new System.Drawing.Point(705, 72);
            this.rvcPriority.Name = "rvcPriority";
            this.rvcPriority.Size = new System.Drawing.Size(33, 20);
            this.rvcPriority.TabIndex = 11;
            // 
            // rvcSendButton
            // 
            this.rvcSendButton.Location = new System.Drawing.Point(1131, 70);
            this.rvcSendButton.Name = "rvcSendButton";
            this.rvcSendButton.Size = new System.Drawing.Size(75, 23);
            this.rvcSendButton.TabIndex = 12;
            this.rvcSendButton.Text = "RV-C Send";
            this.rvcSendButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(904, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "AutoSearch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rvcSendButton);
            this.Controls.Add(this.rvcPriority);
            this.Controls.Add(this.rvcSA);
            this.Controls.Add(this.rvcDgn);
            this.Controls.Add(this.rvcData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataField);
            this.Controls.Add(this.send);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.portButton);
            this.Controls.Add(this.portNameSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            this.canAdapter = new CanAdapter();
        }

        #endregion
        private System.Windows.Forms.ComboBox portNameSelector;
        private System.Windows.Forms.Button portButton;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox dataField;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox rvcData;
        private System.Windows.Forms.TextBox rvcDgn;
        private System.Windows.Forms.TextBox rvcSA;
        private System.Windows.Forms.TextBox rvcPriority;
        private System.Windows.Forms.Button rvcSendButton;
        private System.Windows.Forms.Button button1;
        public CanAdapter canAdapter;
    }
}

