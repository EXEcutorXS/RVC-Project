using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
namespace RVC_Project
{
    public class CanAdapter
    {
        private List<CanMessage> ReceivedMessages = new List<CanMessage>();
        private List<string> LogMessages = new List<String>();
        private List<string> Errors = new List<String>();

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

        public void PortOpen() => serialPort.Open();
        public void PortClose() => serialPort.Close();

        public void SetNormalMode()
        {
            serialPort.Write("<N>");
        }

        public void SetSilentMode()
        {
            serialPort.Write("<S>");
        }

        public void SetLoopbackMode()
        {
            serialPort.Write("<L>");
        }

        public void SetSilentLoopbackMode()
        {
            serialPort.Write("<K>");
        }
        public void RefreshVersion()
        {
            serialPort.Write("<V>");
        }

        public void SetBitrate(int bitrate)
        {
            if (PortOpened)
                if (bitrate > 0 && bitrate <= 1000)
                    serialPort.Write($"<9{bitrate}>");
                else throw new ArgumentException("Bitrate must be 1..1000 kb/s");
        }

        public int UnprecessedMessages => ReceivedMessages.Count;
        public int UnreadLogMessages => LogMessages.Count;

        public int UnreadErrors => Errors.Count;
        public CanMessage getNextMessage()
        {

            if (ReceivedMessages != null && ReceivedMessages.Count > 0)
            {
                CanMessage ret = ReceivedMessages[0];
                ReceivedMessages.RemoveAt(0);
                return ret;
            }
            else return null;
        }

        public string getNextLogMessage()
        {

            if (LogMessages != null && LogMessages.Count > 0)
            {
                string ret = LogMessages[0];
                LogMessages.RemoveAt(0);
                return ret;
            }
            else return null;
        }

        public string getNextError()
        {

            if (Errors != null && Errors.Count > 0)
            {
                string ret = Errors[0];
                Errors.RemoveAt(0);
                return ret;
            }
            else return null;
        }

        public void sendMessage(CanMessage msg)
        {
            if (serialPort.IsOpen == false)
                return;
            StringBuilder str = new StringBuilder("T");
            str.Append(msg.DLC.ToString());
            str.Append(msg.IdeAsString);
            str.Append(msg.RtrAsString);

            str.Append(msg.IdInTextFormat);
            str.Append(msg.DataInTextFormat);
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
                    CanMessage message = CanMessage.Parse(new string(currentBuf));

                    ReceivedMessages.Add(message);
                    if (ReceivedMessages.Count > 1024)
                        ReceivedMessages.RemoveAt(0);
                    GotNewMessage?.Invoke(this, eventArgs);
                    break;
                case 'P':
                    string LogMessage = new string(currentBuf).Substring(1);
                    LogMessages.Add(LogMessage);
                    if (LogMessages.Count > 1024)
                        LogMessages.RemoveAt(0);
                    GotLogMessage?.Invoke(this, eventArgs);
                    break;
                case 'E':
                    string Error = new string(currentBuf).Substring(1);
                    Errors.Add(Error);
                    if (Errors.Count > 1024)
                        Errors.RemoveAt(0);
                    GotError?.Invoke(this, eventArgs);
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
            serialPort.DataReceived += new SerialDataReceivedEventHandler(this.dataReceived);
        }
        public void Start()
        {
            serialPort.Write("<1>");
        }

        public void Stop()
        {
            serialPort.Write("<2>");

        }
    }
}
