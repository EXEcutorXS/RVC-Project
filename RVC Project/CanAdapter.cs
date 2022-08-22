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

        public void startNormal()
        {
            serialPort.Write("O\r");
        }

        public void startListen()
        {
            serialPort.Write("L\r");
        }

        public void startSelfReception()
        {
            serialPort.Write("Y\r");
        }

        public void stop()
        {
            serialPort.Write("C\r");
        }

        public void SetBitrate(int bitrate)
        {
                serialPort.Write($"S{bitrate}\r");
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
            StringBuilder str = new StringBuilder("");
            if (msg.IDE && msg.RTR)
                str.Append('R');
            if (!msg.IDE && msg.RTR)
                str.Append('r');
            if (msg.IDE && !msg.RTR)
                str.Append('T');
            if (!msg.IDE && !msg.RTR)
                str.Append('t');
            str.Append(msg.IdInTextFormat);
            str.Append(msg.DLC.ToString());
            str.Append(msg.GetDataInTextFormat());
            str.Append('\r');
            serialPort.Write(str.ToString());

        }

        public void addSampleMessage(CanMessage msg = null)
        {
            if (msg != null)
                ReceivedMessages.Enqueue(msg);
            else
                ReceivedMessages.Enqueue(new CanMessage() { ID = 0x1FF, Data = new byte[] { 11, 22, 33, 44, 55, 66, 77, 88 }, IDE = true, DLC = 8, RTR = false });
            GotNewMessage?.Invoke(this, new EventArgs());
        }
        private void uartMessageProcess()
        {
            var eventArgs = new EventArgs();
            switch (currentBuf[0])
            {
                case 'T':
                case 't':
                case 'r':
                case 'R':
                    ReceivedMessages.Enqueue(new CanMessage(new string(currentBuf)));
                    GotNewMessage?.Invoke(this, eventArgs);
                    break;
                case 'Z':
                    LogMessages.Enqueue("Transmission sucess");
                    GotLogMessage?.Invoke(this, eventArgs);
                    break;
                case '\a':
                    LogMessages.Enqueue("Error reported");
                    GotLogMessage?.Invoke(this, eventArgs);
                    break;
                default:
                    break;

            }
        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs args)
        {
            while (serialPort.IsOpen && serialPort.BytesToRead > 0)
            {
                int newByte = serialPort.ReadByte();
                if (newByte == 13 || newByte == 0)
                {
                    currentBuf[ptr] = '\0';
                    uartMessageProcess();
                    ptr = 0;
                }
                else
                    currentBuf[ptr++] = (char)newByte;
            }
        }

        public CanAdapter()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceivedHandler);
        }
    }
}
