using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVC_Project
{
    public sealed class RvcMessage
    {
        public byte Priority;
        public int Dgn;
        public byte SourceAdress;
        public byte[] Data = new byte[8];
        public byte Instance => Data[0];
        public RvcMessage()
        {  }
    
        public RvcMessage(CanMessage msg)
        {
            if (msg == null)
                throw new ArgumentNullException("Source CAN Message can't be null");
            if (msg.DLC != 8)
                throw new ArgumentException("DLC of Souce Message must be 8");
            if (msg.IDE == false)
                throw new ArgumentException("RV-C supports only extended CAN frame format (IDE=1)");
            if (msg.RTR == true)
                throw new ArgumentException("RV-C do not supports data requests (RTR must be 0)");
            Priority = (byte)((msg.ID >> 26) & 7);
            Dgn = msg.ID >> 8 & 0x1FFFF;
            SourceAdress = (byte)(msg.ID & 0xFF);
            Data = msg.Data;
        }

        public CanMessage GetCanMessage()
        {
            var msg = new CanMessage();
            msg.ID = (int)Priority << 26 | Dgn << 8 | SourceAdress;
            msg.DLC = 8;
            msg.IDE = true;
            msg.RTR = false;
            msg.Data = Data;
            return msg;
        }

        public override bool Equals(object obj)
        {
            if (obj== null)
                return false;
            if (!(obj is RvcMessage))
                return false;
            var comp = obj as RvcMessage;
            return GetCanMessage().Equals(comp.GetCanMessage());
        }
        public override string ToString()
        {
            string ret = $"{Priority} | {Dgn:X05} {SourceAdress:D3} ||";
            foreach (var item in Data)
                ret += $" {item:X02} ";
            return ret;
        }
        public override int GetHashCode()
        {
            return GetCanMessage().GetHashCode();
        }
    }
}
