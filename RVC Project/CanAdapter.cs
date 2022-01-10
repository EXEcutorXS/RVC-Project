using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace RVC_Project
{
    public class CanMessageReceivedEventArgs : EventArgs
    {
        public CanMessage Message;
    }

    public class CanLogEventArgs : EventArgs
    {
        public string Message;
    }

    public class CanAdapter
    {
        private Queue<CanMessage> ReceivedMessages = new Queue<CanMessage>();

        private StringBuilder currentBuf = new StringBuilder("");

        public UInt32 Version = 0;
        public bool connected = false;
        public UInt64 totalSent = 0;
        public UInt64 totalReceived = 0;

        public int Bitrate = 250;

        public bool PortOpened => serialPort.IsOpen;


        public string PortName { set => serialPort.PortName = value; get => serialPort.PortName; }

        private SerialPort serialPort;

        public event EventHandler GotNewMessage;

        public void PortOpen() => serialPort.Open();
        public void PortClose() => serialPort.Close();
        public void RefreshVersion()
        {
            if (serialPort.IsOpen)
            serialPort.Write("<V>");
        }

        public void SetBitrate(int bitrate)
        {
            serialPort.Write($"<9{bitrate}>");
        }

        public void sendMessage(CanMessage msg)
        {
            StringBuilder str = new StringBuilder("T");
            str.Append(msg.DLC.ToString());

            if (msg.IDE)
                str.Append("1");
            else
                str.Append("0");

            if (msg.RTR)
                str.Append("1");
            else
                str.Append("0");

            if (msg.IDE)
                str.Append(String.Format("{0:08X}", msg.ExtId));
            else
                str.Append(String.Format("{0:03X}", msg.StdId));

            foreach (var item in msg.Data)
            { 
            str.Append(item.ToString("02X"));
            }

        }


        private void uartMessageProcess()
        {
            switch (currentBuf[0])
            {
                case 'V':
                    string verString = currentBuf.ToString().Substring(1);
                    Version = Convert.ToUInt32(verString);
                    connected = true;
                    break;
                case 'R':
                    CanMessage message = CanMessage.Parse(currentBuf.ToString());
                    var eventArgs = new CanMessageReceivedEventArgs();
                    eventArgs.Message = message;
                    GotNewMessage.Invoke(this, eventArgs);
                    break;
                default:
                    break;
            }

        }
        private void dataReceived(object sender, SerialDataReceivedEventArgs args)
        {
            while (serialPort.BytesToRead > 0)
            {
                char newChar = (char)serialPort.ReadByte();
                if (newChar == '<')
                    currentBuf.Clear();
                else if (newChar == '>')
                    uartMessageProcess();
                else
                    currentBuf.Append((char)serialPort.ReadByte());
            }
        }

        public CanAdapter()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(this.dataReceived);
        }
        public void AutoConnect()
        {
            connected = false;
            var portNames = SerialPort.GetPortNames();
            if (portNames.Length == 0)
                return;
            foreach (var portName in portNames)
            {
                try
                {
                    serialPort.PortName = portName;
                    serialPort.Open();
                    serialPort.WriteLine("<V>");

                }
                catch
                {

                }
            }

        }
        public void Start()
        {

        }
    }
}
