using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace RVC_Project
{
    public enum CanAdapterMode { Normal, Silent, Loopback, SilentLoopback }
    public class CanAdapter
    {
        
        private Queue<CanMessage> ReceivedMessages = new Queue<CanMessage>(4096);
        private Queue<string> LogMessages = new Queue<String>(4096);
        private Queue<string> Errors = new Queue<String>(4096);

        char[] currentBuf = new char[1024];
        int ptr = 0;

        public UInt32 Version = 0;
        public bool connected = false;
        public UInt64 totalSent = 0;
        public UInt64 totalReceived = 0;

        public int Bitrate = 250;

        public bool PortOpened => serialPort.IsOpen;


        public string PortName { set => serialPort.PortName = value; get => serialPort.PortName; }

        private SerialPort serialPort;

        public event EventHandler GotNewMessage;

        public event EventHandler GotError;

        public event EventHandler GotLogMessage;

        public int UnreadMessages => ReceivedMessages.Count;
        public int UnreadLogMessages => LogMessages.Count;
        public int UnreadErrors => Errors.Count;

        public void PortOpen() => serialPort.Open();
        public void PortClose() => serialPort.Close();

        public void SetMode(CanAdapterMode mode)
        {
            switch (mode)
            {
                case CanAdapterMode.Normal:
                    serialPort.Write("<N>");
                    break;
                case CanAdapterMode.Silent:
                    serialPort.Write("<S>");
                    break;
                case CanAdapterMode.Loopback:
                    serialPort.Write("<L>");
                    break;
                case CanAdapterMode.SilentLoopback:
                    serialPort.Write("<K>");
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Wrong work mode");
            }
        }
        public void SetBitrate(int bitrate)
        {
            if (bitrate > 0 && bitrate <= 1000)
                serialPort.Write($"<9{bitrate}>");
            else
                throw new ArgumentException("Bitrate must be 1..1000 kb/s");
        }
        public CanMessage GetNextMessage()
        {
            if (ReceivedMessages.Count > 0)
                return ReceivedMessages.Dequeue();
            else return null;
        }

        public string GetNextLogMessage()
        {
            if (LogMessages.Count > 0)
                return LogMessages.Dequeue();
            else return null;
        }

        public string GetNextError()
        {

            if (Errors.Count > 0)
                return Errors.Dequeue();
            else return null;
        }

        public void SendMessage(CanMessage msg)
        {
            if (serialPort.IsOpen == false)
                return;
            StringBuilder str = new StringBuilder("T");
            str.Append(msg.DLC.ToString());
            str.Append(msg.IdeAsString);
            str.Append(msg.RtrAsString);

            str.Append(msg.IdInTextFormat);
            str.Append(msg.GetDataInTextFormat());
            str.Append('>');
            serialPort.Write(str.ToString());

        }


        private void uartMessageProcess()
        {
            var eventArgs = new EventArgs();
            switch (currentBuf[0])
            {
                case 'V':
                    string verString = (new string(currentBuf)).Substring(1, 8);
                    Version = Convert.ToUInt32(verString, 16);
                    connected = true;
                    break;
                case 'R':
                    ReceivedMessages.Enqueue(new CanMessage(new string(currentBuf)));
                    GotNewMessage?.Invoke(this, eventArgs);
                    break;
                case 'P':
                    string LogMessage = new string(currentBuf).Substring(1);
                    LogMessages.Enqueue(LogMessage);
                    GotLogMessage?.Invoke(this, eventArgs);
                    break;
                case 'E':
                    string Error = new string(currentBuf).Substring(1);
                    Errors.Enqueue(Error);
                    GotError?.Invoke(this, eventArgs);
                    break;
                default:
                    break;
            }
        }

        public void GetAdapterVersion()
        {
            serialPort.Write("<V>");
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs args)
        {
            while (serialPort.IsOpen && serialPort.BytesToRead > 0)
            {
                char newChar = (char)serialPort.ReadByte();
                if (newChar == '<')
                    ptr = 0;
                else if (newChar == '>')
                {
                    currentBuf[ptr] = '\0';
                    uartMessageProcess();
                }
                else
                    currentBuf[ptr++] = newChar;

            }
        }

        public CanAdapter()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceivedHandler);
        }
        public void StartCan()
        {
            serialPort.Write("<1>");
        }

        public void StopCan()
        {
            serialPort.Write("<2>");

        }
    }
}
