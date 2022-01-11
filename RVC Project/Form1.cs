using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace RVC_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canAdapter = new CanAdapter();
            canAdapter.GotNewMessage += CanAdapter_GotNewMessage;
            
            if (SerialPort.GetPortNames().Length > 0)
                PortNamesListField.Text = SerialPort.GetPortNames()[0];

        }

        private int? findMessage(bool IDE, UInt32 Id, ListBox container)
        {
            for (int i = 0; i < container.Items.Count; i++)
            {
                if ((container.Items[i] as CanMessage).ExtId == Id && (container.Items[i] as CanMessage).IDE == IDE)
                    return i;
                if ((container.Items[i] as CanMessage).StdId == Id && (container.Items[i] as CanMessage).IDE == IDE)
                    return i;
            }
            return null;
        }
        private void CanAdapter_GotNewMessage(object sender, EventArgs e)
        {
            while (canAdapter.UnprecessedMessages > 0)
            {
                CanMessage m = canAdapter?.getNextMessage();
                if (m != null)
                {
                    LogField.Invoke(new Action(() => LogField.AppendText(m.ToString() + Environment.NewLine)));
                    if (m.IDE)
                    {
                        int? num = findMessage(true, m.ExtId, MessageList);
                        if (num != null)
                        {
                            MessageList.Invoke(new Action(() => MessageList.Items.RemoveAt((int)num)));
                            MessageList.Invoke(new Action(() => MessageList.Items.Insert((int)num, m)));
                        }
                        else
                            MessageList.Invoke(new Action(() => MessageList.Items.Insert(0, m)));
                        
                    }
                    else
                    {
                        int? num = findMessage(false, m.StdId, MessageList);
                        if (num != null)
                        {
                            MessageList.Invoke(new Action(() => MessageList.Items.RemoveAt((int)num)));
                            MessageList.Invoke(new Action(() => MessageList.Items.Insert((int)num, m)));
                        }
                        else
                            MessageList.Invoke(new Action(() => MessageList.Items.Insert(0, m)));
                    }
                }
            }

            while (canAdapter.UnreadLogMessages > 0)
            {
                string s = canAdapter?.getNextLogMessage();
                if (s != null)
                    LogField.Invoke(new Action(() => LogField.AppendText(s.ToString() + Environment.NewLine)));
            }

            while (canAdapter.UnreadErrors > 0)
            {
                string s = canAdapter?.getNextError();
                if (s != null)
                    LogField.Invoke(new Action(() => LogField.AppendText("Error: " + s.ToString() + Environment.NewLine)));
            }

        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            canAdapter.SetNormalMode();
        }

        private void LoopbackButton_Click(object sender, EventArgs e)
        {
            canAdapter.SetLoopbackMode();
        }

        private void SilentButton_Click(object sender, EventArgs e)
        {
            canAdapter.SetSilentMode();
        }

        private void SilentLoopbackButton_Click(object sender, EventArgs e)
        {
            canAdapter.SetSilentLoopbackMode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canAdapter.RefreshVersion();
            Thread.Sleep(10);
            VersionField.Text = String.Format("{0:D2}.{1:D2}.{2:D2}.{3:D2}", canAdapter.Version>>24&0xFF, canAdapter.Version >> 16 & 0xFF,canAdapter.Version >> 8 & 0xFF,canAdapter.Version & 0xFF);
        }

        private void SetBitrateButton_Click(object sender, EventArgs e)
        {
            canAdapter.SetBitrate(Convert.ToInt32(BitrateField.Value));
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            var msg = new CanMessage();
            msg.RTR = RtrField.Checked;
            msg.IDE = IdeField.Checked;
            msg.DLC = Convert.ToByte(DlcField.Value);
            msg.Data = new byte[msg.DLC];
            if (msg.IDE)
                msg.ExtId = Convert.ToUInt32(IdField.Value);
            else
                msg.StdId = Convert.ToUInt32(IdField.Value);

            msg.Data = new byte[msg.DLC];
            for (int i = 0; i < msg.DLC; i++)
                try
                {
                    msg.Data[i] = Convert.ToByte(DataField.Text.Substring(i * 2, 2), 16);
                    canAdapter.sendMessage(msg);
                }
                catch
                { 
                
                }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            PortNamesListField.Items.Clear();
            PortNamesListField.Items.AddRange(SerialPort.GetPortNames());
            if (PortNamesListField.Items.Count > 0)
                PortNamesListField.SelectedIndex = 0;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            
            if (canAdapter.PortOpened)
            {
                canAdapter.PortClose();
                ConnectButton.Text = "Connect";
                return;
            }

            if (canAdapter.PortName == "")
            {
                return;
            }

            canAdapter.PortName = PortNamesListField.Text;
            canAdapter.PortOpen();
            ConnectButton.Text = "Disconnect";
        }


        private void AutoConnectButton_Click(object sender, EventArgs e)
        {
            canAdapter.AutoConnect();
            if (canAdapter.connected)
            {
                PortNamesListField.Text = canAdapter.PortName;
                VersionField.Text = String.Format("{0:X08}", canAdapter.Version);

            }
        }

        private void IdeField_CheckedChanged(object sender, EventArgs e)
        {
            if (IdeField.Checked)
                IdField.Maximum = 0x1FFFFFFF;
            else
                IdField.Maximum = 0x7FF;
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogField.Clear();
        }

        private void ClearMessagesButton_Click(object sender, EventArgs e)
        {
            MessageList.Items.Clear();
        }
    }
}
