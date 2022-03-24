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
            if (str[0] != 'R')
                throw new FormatException("Can't parse. String must start with 'R'");
            DLC = (byte)int.Parse(str[1].ToString());
            if (DLC > 8)
                throw new FormatException($"Can't parse. Message length cant be {DLC}, max length is 8");
            if (str[2] != '0')
                IDE = true;
            else if (str[2] == '0')
                IDE = false;
            else
                throw new FormatException($"Can't parse. Message IDE is {str[2]}, must be '0' or '4'");

            if (str[3] == '0')
                RTR = false;
            else
                RTR = true;
            var parts = str.Split('_');
            ID = Convert.ToInt32(parts[1], 16);
            Data = new byte[DLC];
            for (int i = 0; i < DLC; i++)
            {
                string subString = parts[2].Substring(i * 2, 2);
                Data[i] = Convert.ToByte(subString, 16);
            }
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
