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
        List<Parameter> parameters = new List<Parameter>();
        List<Label> labels = new List<Label>();
        RvcMessage formedMessage = new RvcMessage() { };

        public void rebuildMessage(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                formedMessage.Data[i] = 0xFF;
            }
            for (int i = 0; i < parameters.Count; i++)
            {
                Parameter p = parameters[i];
                switch (p.Type)
                {
                    case parameterType.boolean:
                        
                        break;
                    default:
                        break;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RVC.SeedData();
            RVC.SaveToFile();
            DgnListComboBox.Items.AddRange(RVC.DGNs.ToArray().Select(x => x.Value.Dgn.ToString("X") + " " + x.Value.Name).ToArray());
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
                    string s = canAdapter?.GetNextLogMessage();
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
                    string s = canAdapter?.GetNextError();
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
            while (canAdapter.UnreadMessages > 0)
            {
                CanMessage m = canAdapter?.GetNextMessage();
                if (m != null)
                {
                    if (WriteToLogCHeckBox.Checked)
                        LogField.Invoke(new Action(() => LogField.AppendText(m.ToString() + Environment.NewLine)));

                    int? num = CanMessageList.findCanMessageById(m);
                    try
                    {
                        if (num != null)
                        {
                            if (!CanMessageList.Items[(int)num].Equals(m))
                                CanMessageList.Invoke(new Action(() => CanMessageList.Items[(int)num] = m));
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
                        int? rvcNum = m.ToRvcMessage().getPosInList(RvcMessageList.Items.Cast<RvcMessage>().ToList());

                        if (rvcNum != null)
                        {
                            if (!RvcMessageList.Items[(int)rvcNum].Equals(m.ToRvcMessage()))
                            {
                                RvcMessageList.Invoke(new Action(() => RvcMessageList.Items[(int)rvcNum] = m.ToRvcMessage()));
                                int selcectedIndex = (int)RvcMessageList.Invoke(new Func<int>(() => RvcMessageList.SelectedIndex));
                                if (selcectedIndex == rvcNum)
                                    VerboseInfoField.Invoke(new Action(() => VerboseInfoField.Text = m.ToRvcMessage().VerboseInfo().Replace(';', '\n')));
                            }
                        }
                        else
                            RvcMessageList.Invoke(new Action(() => { RvcMessageList.Items.Insert(0, m.ToRvcMessage());}));
                    }

                        adversCanLogField.Invoke(new Action(() => adversCanLogField.AppendText(new AdversCanMessage(m).ToString())));

                }
            }
        }

        
        private void NormalButton_Click(object sender, EventArgs e)
        {
            try
            {
                canAdapter.startNormal();
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
                canAdapter.startSelfReception();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            var msg = new CanMessage();
            msg.RTR = RtrField.Checked;
            msg.IDE = IdeField.Checked;
            msg.DLC = Convert.ToByte(DlcField.Value);
            msg.Data = new byte[msg.DLC];
            msg.ID = Convert.ToInt32(IdField.Value);
            msg.Data = new byte[msg.DLC];

            try
            {
                for (int i = 0; i < msg.DLC; i++)
                    msg.Data[i] = Convert.ToByte(DataField.Text.Substring(i * 2, 2), 16);
                canAdapter.SendMessage(msg);
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


        private void StopButton_Click(object sender, EventArgs e)
        {
            canAdapter.stop();
        }

        private void RvcSendButton_Click(object sender, EventArgs e)
        {
            var msg = new RvcMessage();
            msg.Dgn = Convert.ToInt32(RvcDgnField.Value);
            msg.Data = new byte[8];
            msg.SourceAdress = Convert.ToByte(RvcSourceAdressField.Value);
            msg.Priority = Convert.ToByte(RvcPriorityField.Value);
            try
            {
                for (int i = 0; i < 8; i++)
                    msg.Data[i] = Convert.ToByte(RvcDataField.Text.Substring(i * 2, 2), 16);
                canAdapter.SendMessage(msg.GetCanMessage());
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

        private void DataField_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataField.Text.Length; i++)
            {
                char c = DataField.Text[i];
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
                {
                    DataField.Text = DataField.Text.Remove(i, 1);
                    MessageBox.Show($"Введён неподходящий символ ({c})");
                }
            }

        }

        private void RvcDataField_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < RvcDataField.Text.Length; i++)
            {
                char c = RvcDataField.Text[i];
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
                {
                    RvcDataField.Text = RvcDataField.Text.Remove(i, 1);
                    MessageBox.Show($"Введён неподходящий символ ({c})");
                }
            }
        }

        private void RvcMessageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerboseInfoField.Text = (RvcMessageList?.SelectedItem as RvcMessage)?.VerboseInfo()?.Replace(';', '\n');
        }

        private void DgnListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Yposition = 5;
            int dgn = Convert.ToInt32(DgnListComboBox.SelectedItem.ToString().Split()[0], 16);
            ParametersPanel.Controls.Clear();

            if (RVC.DGNs.ContainsKey(dgn))
            {
                DGN currentDgn = RVC.DGNs[dgn];
                for (int i = 0; i < currentDgn.Parameters.Count; i++)
                {
                    Parameter p = currentDgn.Parameters[i];
                    p.assignedLabel = new Label();
                    ParametersPanel.Controls.Add(p.assignedLabel);

                    p.assignedLabel.Location = new Point(10, Yposition);
                    p.assignedLabel.Width = 170;
                    p.assignedLabel.Text = p.Name;
                    string unitString = "";
                    switch (p.Type)
                    {
                        case parameterType.percent: unitString = ", %"; break;
                        case parameterType.temperature: unitString = ", C°"; break;
                        case parameterType.amperage: unitString = ", A"; break;
                        case parameterType.custom: unitString = ", " + p.Unit; break;
                        case parameterType.hertz: unitString = ", Hz"; break;
                        case parameterType.voltage: unitString = ", V"; break;
                        case parameterType.watts: unitString = ", W"; break;
                        default: break;
                    }
                    p.assignedLabel.Text += unitString;
                    switch (p.Type)
                    {
                        case parameterType.boolean:
                        case parameterType.list:
                            p.assignedField = new ComboBox();
                            ComboBox box = (ComboBox)p.assignedField;
                            ParametersPanel.Controls.Add(p.assignedField);
                            p.assignedField.Location = new Point(200, Yposition);
                            p.assignedField.Width = 200;
                            p.assignedField.TextChanged += rebuildMessage;
                            if (p.Meanings.Count > 0)
                                foreach (KeyValuePair<uint, string> entry in p.Meanings)
                                    (p.assignedField as ComboBox).Items.Add(entry.Key.ToString() + " - " + entry.Value.ToString());
                            else
                            {
                                box.Items.Add("0 - False");
                                box.Items.Add("1 - True");
                            }
                            box.Items.Add("No change");
                            box.SelectedIndex = box.Items.Count - 1;
                            break;
                        case parameterType.percent:
                        case parameterType.amperage:
                        case parameterType.custom:
                        case parameterType.hertz:
                        case parameterType.instance:
                        case parameterType.temperature:
                        case parameterType.voltage:
                        case parameterType.watts:

                            TextBox txt = new TextBox();
                            p.assignedField = txt;
                            ParametersPanel.Controls.Add(txt);
                            txt.Location = new Point(200, Yposition);
                            txt.Width = 200;
                            txt.TextChanged += rebuildMessage;
                            break;
                        default:
                            break;
                    }
                    Yposition += 24;
                }
            }

        }

        private void SendRvcButton_Click(object sender, EventArgs e)
        {
            RvcMessage m = new RvcMessage();
            for (int i = 0; i < parameters.Count; i++)
            {
                Parameter p = parameters[i];
                if (parameters[i].assignedField.Text == "" || parameters[i].assignedField.Text == "No Change")
                    continue;
                switch (p.Type)
                {
                    case parameterType.list:
                        byte raw = 0;
                        raw |= (byte)(Convert.ToByte(parameters[i].assignedField.Text.Split()[0]) << p.firstBit);
                        switch (p.Size)
                        {
                            case parameterSize.uint2: raw &= 0b11; break;
                            case parameterSize.uint4: raw &= 0b1111; break;
                            case parameterSize.uint6: raw &= 0b111111; break;
                            default: throw new ArgumentException($"Parameter of type {p.Type} cant have size {p.Size}");
                        }
                        m.Data[p.firstByte] |= raw;
                        break;
                    default:
                        break;
                }
            }
        }

        private void RvcMessageList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            // draw the background color you want
            // mine is set to olive, change it to whatever you want
            /*
            int dgn = (RvcMessageList.Items[e.Index] as RvcMessage).Dgn;
            if (RVC.DGNs.ContainsKey(dgn))
            {
                if (RVC.DGNs[dgn].Name.Contains("COMMAND"))
                    g.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
                if (RVC.DGNs[dgn].Name.Contains("STATUS"))
                    g.FillRectangle(new SolidBrush(Color.Green), e.Bounds);
            }
            */
            // draw the text of the list item, not doing this will only show
            // the background color
            // you will need to get the text of item to display
            g.DrawString(RvcMessageList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            canAdapter.startListen();
        }

        private void SelfReceptionButton_Click(object sender, EventArgs e)
        {
            canAdapter.startSelfReception();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            canAdapter.SetBitrate(int.Parse(comboBox1.SelectedIndex.ToString()));
        }
    }
    public static class extensionMethods
    {
        public static int? findCanMessageById(this ListBox lisbBox, CanMessage msg)
        {
            for (int i = 0; i < lisbBox.Items.Count; i++)
                if ((lisbBox.Items[i] as CanMessage).ID == msg.ID)
                    return i;
            return null;
        }

        public static int? findRvcMessageByDgnAndInstance(this ListBox listBox, RvcMessage msg)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if ((listBox.Items[i] is RvcMessage) && (listBox.Items[i] as RvcMessage).Dgn == msg.Dgn && (listBox.Items[i] as RvcMessage).Instance == msg.Instance)
                    return i;
            }
            return null;
        }
    }
}

