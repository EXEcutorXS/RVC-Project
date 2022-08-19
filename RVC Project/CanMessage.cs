using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVC_Project
{
    public sealed class CanMessage
    {
        public bool IDE { set; get; }
        public int ID { set; get; }
        public bool RTR { set; get; }
        public byte DLC { set; get; }

        public byte[] Data = new byte[8];

        public RvcMessage ToRvcMessage()
        {
            return new RvcMessage(this);
        }

        public AdversCanMessage ToAdversCanMessage()
        { 
        return new AdversCanMessage(this);
        }

        public string GetDataInTextFormat(string beforeString = "", string afterString = "")
        {
            StringBuilder sb = new StringBuilder("");
            foreach (var item in Data)
                sb.Append($"{beforeString}{item:X02}{afterString}");
            return sb.ToString();
        }

        public string RtrAsString => RTR ? "1" : "0";

        public string IdeAsString => IDE ? "1" : "0";

        public bool RvcCompatible => IDE && DLC == 8 && !RTR;

        public string IdInTextFormat => IDE ? string.Format("{0:X08}", ID) : string.Format("{0:X03}", ID);


        public override string ToString()
        {
            return $"L:{DLC} IDE:{IdeAsString} RTR:{RtrAsString} ID:0x{IdInTextFormat} Data:{GetDataInTextFormat(" ")}";
        }

        public CanMessage()
        { }
        public CanMessage(string str)
        {
            switch (str[0])
            {
                case 't': 
                    IDE = false;
                    RTR = false;
                    break;
                case 'T':
                    IDE = true;
                    RTR = false;
                    break;
                case 'r':
                    IDE = false;
                    RTR = true;
                    break;
                case 'R':
                    IDE = true;
                    RTR = true;
                    break;
                default:
                    throw new FormatException("Can't parse. String must start with 't','T','r' or 'R' ");
            }
            if (IDE)                
            DLC = (byte)int.Parse(str[9].ToString());
            else
                DLC = (byte)int.Parse(str[4].ToString());
            if (DLC > 8)
                throw new FormatException($"Can't parse. Message length cant be {DLC}, max length is 8");

            if (IDE)
                ID = Convert.ToInt32(str.Substring(1,8), 16);
            else
                ID = Convert.ToInt32(str.Substring(1, 3), 16);
            Data = new byte[DLC];

            int shift;
            if (!IDE)
                shift = 5;
            else
                shift = 10;
            for (int i = 0; i < DLC; i++)
                Data[i] = Convert.ToByte(str.Substring(shift + i * 2, 2),16);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (!(obj is CanMessage))
                return false;
            CanMessage toCompare = obj as CanMessage;
            if (toCompare.ID != ID || toCompare.DLC != DLC || toCompare.IDE != IDE || toCompare.RTR != RTR)
                return false;
            for (int i = 0; i < toCompare.DLC; i++)
                if (toCompare.Data[i] != Data[i])
                    return false;
            return true;
        }

        public override int GetHashCode()
        {
            int ret = ID;
            for (int i = 0; i < DLC; i++)
            {
                ret ^= Data[i] << (8 * (i % 4));
            }
            return ret;
        }

    }
}
