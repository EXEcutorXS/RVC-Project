using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVC_Project
{
    public class RvcMessage
    {
        public byte Priority;
        public uint Dgn;
        public byte SourceAdress;
        public byte[] Data = new byte[8];
        public byte Instance => Data[0];
        public RvcMessage()
        { 

        }

        public RvcMessage(CanMessage sourcsMsg)
        {
            if (sourcsMsg == null)
                throw new ArgumentNullException("Source CAN Message can't be null");
            if (sourcsMsg.DLC != 8)
                throw new ArgumentException("DLC of Souce Message must be 8");
            if (sourcsMsg.IDE == false)
                throw new ArgumentException("RV-C supports only extended CAN frame format (IDE=1)");
            if (sourcsMsg.RTR == true)
                throw new ArgumentException("RV-C do not supports data requests (RTR must be 0)");
            Priority = (byte)((sourcsMsg.ExtId >> 26) & 7);
            Dgn = sourcsMsg.ExtId >> 8 & 0x1FFFF;
            SourceAdress = (byte)(sourcsMsg.ExtId & 0xFF);
            Data = sourcsMsg.Data;
        }

        public CanMessage GetCanMessage()
        {
            var msg = new CanMessage();
            msg.ExtId = (uint)Priority<<26 | Dgn<<8 | SourceAdress;
            msg.DLC = 8;
            msg.IDE = true;
            msg.RTR = false;
            msg.Data = Data;
            return msg;
        }
        public override string ToString()
        {
            string ret = $"{Priority} |";
            ret += String.Format(" {0:X05} |", Dgn);
            foreach (var item in Data)
                ret += String.Format(" {0:X02} ",item);
            return ret;
        }
    }
}
