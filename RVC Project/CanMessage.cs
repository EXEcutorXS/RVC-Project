using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVC_Project
{
    public class CanMessage
    {
        public bool IDE;
        public UInt32 StdId;
        public UInt32 ExtId;
        public bool RTR;
        public byte DLC;
        public byte[] Data;

        public static CanMessage Parse(string str)
        {
            var ret = new CanMessage();
            if (str[0] != 'R')
                throw new FormatException("Can't parse. String must start with 'R'");
            ret.DLC = (byte)int.Parse(str[1].ToString());
            if (ret.DLC > 8)
                throw new FormatException($"Can't parse. Message length cant be {ret.DLC}, max length is 8");
            if (str[2] == '4')
                ret.IDE = true;
            else if (str[2] == '0')
                ret.IDE = false;
            else
                throw new FormatException($"Can't parse. Message IDE is {str[2]}, must be '0' or '4'");

            if (str[3]=='0')
                ret.RTR = false;
            else
                ret.RTR = true;
            var parts = str.Split('_');
            if (ret.IDE)
                ret.ExtId = Convert.ToUInt32(parts[1], 16);
            else
                ret.StdId = uint.Parse(parts[1]);
            ret.Data = new byte[ret.DLC];
            for (int i = 0; i < ret.DLC; i++)
            {
                string subString = parts[2].Substring(i * 2, 2);
                ret.Data[i] = Convert.ToByte(subString, 16);
            }
            return ret;
        }
    }


}
