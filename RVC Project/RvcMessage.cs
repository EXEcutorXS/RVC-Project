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
        public byte SourseAdress;
        public List<byte> data = new List<byte>();

        public RvcMessage(string stringToParse)
        { 
        
        }
        public string toString()
        {
            string ret = $"{Priority} | {Dgn} |";
            foreach (var item in data)
                ret += " " + item.ToString();
            return ret;
        }
    }
}
