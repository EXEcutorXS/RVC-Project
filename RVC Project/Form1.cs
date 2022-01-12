﻿using System;
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
            canAdapter.GotNewMessage += CanAdapterGotMessage;
            canAdapter.GotError += CanAdapter_GotError;
            canAdapter.GotLogMessage += CanAdapter_GotLogMessage;

            if (SerialPort.GetPortNames().Length > 0)
                PortNamesListField.Text = SerialPort.GetPortNames()[0];

        }

        private void CanAdapter_GotLogMessage(object sender, EventArgs e)
        {
            try
            {
                while (canAdapter.UnreadLogMessages > 0)
                {
                    string s = canAdapter?.getNextLogMessage();
                    if (s != null)
                        LogField.Invoke(new Action(() => LogField.AppendText(s.ToString() + Environment.NewLine)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CanAdapter_GotError(object sender, EventArgs e)
        {
            try
            {
                while (canAdapter.UnreadErrors > 0)
                {
                    string s = canAdapter?.getNextError();
                    if (s != null)
                        LogField.Invoke(new Action(() => LogField.AppendText("Error: " + s.ToString() + Environment.NewLine)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CanAdapterGotMessage(object sender, EventArgs e)
        {
            while (canAdapter.UnprecessedMessages > 0)
            {
                CanMessage m = canAdapter?.getNextMessage();
                if (m != null)
                {
                    LogField.Invoke(new Action(() => LogField.AppendText(m.ToString() + Environment.NewLine)));

                    int? num = CanMessageList.findCanMessageById(m);
                    try
                    {
                        if (num != null)
                        {
                            CanMessageList.Invoke(new Action(() => CanMessageList.Items.RemoveAt((int)num)));
                            CanMessageList.Invoke(new Action(() => CanMessageList.Items.Insert((int)num, m)));
                        }
                        else
                            CanMessageList.Invoke(new Action(() => CanMessageList.Items.Insert(0, m)));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (m.RvcCompatible)
                    {
                        int? rvcNum = RvcMessageList.findRvcMessageByDgnAndInstance(m.ToRvcMessage());
                        try
                        {
                            if (rvcNum != null)
                            {
                                RvcMessageList.Invoke(new Action(() => RvcMessageList.Items.RemoveAt((int)rvcNum)));
                                RvcMessageList.Invoke(new Action(() => RvcMessageList.Items.Insert((int)rvcNum, m.ToRvcMessage())));
                            }
                            else
                                RvcMessageList.Invoke(new Action(() => RvcMessageList.Items.Insert(0, m.ToRvcMessage())));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            try
            {
                canAdapter.SetNormalMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoopbackButton_Click(object sender, EventArgs e)
        {
            try
            {
                canAdapter.SetLoopbackMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SilentButton_Click(object sender, EventArgs e)
        {
            canAdapter.SetSilentMode();
        }

        private void SilentLoopbackButton_Click(object sender, EventArgs e)
        {
            try
            {
                canAdapter.SetSilentLoopbackMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                canAdapter.RefreshVersion();
                Thread.Sleep(10);
                VersionField.Text = String.Format("{0:D2}.{1:D2}.{2:D2}.{3:D2}", canAdapter.Version >> 24 & 0xFF, canAdapter.Version >> 16 & 0xFF, canAdapter.Version >> 8 & 0xFF, canAdapter.Version & 0xFF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            try
            {
                for (int i = 0; i < msg.DLC; i++)
                    msg.Data[i] = Convert.ToByte(DataField.Text.Substring(i * 2, 2), 16);
                canAdapter.sendMessage(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            CanMessageList.Items.Clear();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                canAdapter.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                canAdapter.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RvcSendButton_Click(object sender, EventArgs e)
        {
            var msg = new RvcMessage();
            msg.Dgn = Convert.ToUInt32(RvcDgnField.Value);
            msg.Data = new byte[8];
            msg.SourceAdress = Convert.ToByte(RvcSourceAdressField.Value);
            msg.Priority = Convert.ToByte(RvcPriorityField.Value);
            try
            {
                for (int i = 0; i < 8; i++)
                    msg.Data[i] = Convert.ToByte(RvcDataField.Text.Substring(i * 2, 2), 16);
                canAdapter.sendMessage(msg.GetCanMessage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearRvcButton_Click(object sender, EventArgs e)
        {
            RvcMessageList.Items.Clear();
        }
    }
    public static class extensionMethods
    {
        public static int? findCanMessageById(this ListBox lisbBox, CanMessage msg)
        {
            for (int i = 0; i < lisbBox.Items.Count; i++)
            {
                if (((lisbBox.Items[i] as CanMessage).ExtId == msg.ExtId && (lisbBox.Items[i] as CanMessage).IDE == true) ||
                ((lisbBox.Items[i] as CanMessage).StdId == msg.ExtId && (lisbBox.Items[i] as CanMessage).IDE == false))
                    return i;
            }
            return null;
        }

        public static int? findRvcMessageByDgnAndInstance(this ListBox lisbBox, RvcMessage msg)
        {
            for (int i = 0; i < lisbBox.Items.Count; i++)
            {
                if ((lisbBox.Items[i] as RvcMessage).Dgn == msg.Dgn && (lisbBox.Items[i] as RvcMessage).Instance == msg.Instance)
                    return i;
            }
            return null;
        }
    }
}
