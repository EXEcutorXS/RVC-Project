using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RVC_Project
{

    class PGN
    {
        public int id;
        public string name;
        public bool multipack;
        public List<AC2Pparam> parameters = new List<AC2Pparam>();
    }
    public class AC2Pparam
    {
        public int id;
        public string paramsName;//from ParamsName.h
        public int startByte;   //Начальный байт в пакете
        public int startBit;    //Начальный бит в байте
        public int bitLength;   //Ддина параметра в битах
        public string name;     //Имя параметра
        public string unit = "";     //Единица измерения
        public double a = 1;         //коэффициент приведение
        public double b = 0;         //смещение
        //value = rawData*a+b
        public string outputFormat;
        public Dictionary<int, string> meanings;
        public string tip;
        public int packNumber;

    }
    class AC2Pcommand
    {
        public int firstByte;
        public int secondByte;
        public string name;
        public List<AC2Pparam> parameters;
    }
    public class AC2Pmessage
    {

        public int PGN;
        public int receiverType;
        public int receiverAdr;
        public int transmitterType;
        public int transmitterAdr;
        public byte[] data;
        public AC2Pmessage(CanMessage msg)
        {
            PGN = (msg.ID >> 20) & 0b111111111;
            receiverType = (msg.ID >> 13) & 0b1111111;
            receiverAdr = (msg.ID >> 10) & 0b111;
            transmitterType = (msg.ID >> 3) & 0b1111111;
            transmitterAdr = msg.ID & 0b111;
            data = msg.Data;
        }

        public string printParameter(AC2Pparam p)
        {
            StringBuilder retString = new StringBuilder();
            int rawValue;
            retString.Append(p.name + ": ");
            switch (p.bitLength)
            {
                case 1: rawValue = data[p.startByte] >> p.startBit & 0b1; break;
                case 2: rawValue = data[p.startByte] >> p.startBit & 0b11; break;
                case 3: rawValue = data[p.startByte] >> p.startBit & 0b111; break;
                case 4: rawValue = data[p.startByte] >> p.startBit & 0b1111; break;
                case 8: rawValue = data[p.startByte]; break;
                case 16: rawValue = data[p.startByte] * 256 + data[p.startByte + 1]; break;
                case 24: rawValue = data[p.startByte] * 65536 + data[p.startByte + 1] * 256 + data[p.startByte + 2]; break;
                case 32: rawValue = data[p.startByte] * 16777216 + data[p.startByte + 1] * 65536 + data[p.startByte + 2] * 256 + data[p.startByte + 3]; break;
                default: throw new Exception("Bad parameter size");
            }
            if (p.meanings != null && p.meanings.Count > 0)
                retString.Append(rawValue.ToString() + " - " + p.meanings[rawValue]);
            else
            {
                if (rawValue == Math.Pow(2, p.bitLength) - 1)
                    retString.Append($"Нет данных({rawValue})");
                else
                {
                    double rawDouble = (double)rawValue;
                    double value = rawDouble * p.a + p.b;
                    retString.Append(value.ToString(p.outputFormat) + p.unit + '(' + rawValue.ToString() + ')');
                }
            }
            retString.Append(';');
            return retString.ToString();
        }

        public override string ToString()
        {
            StringBuilder retString = new StringBuilder();
            retString.Append($"<{PGN:D02}>[{transmitterType}]({transmitterAdr})->[{receiverType}]({receiverAdr}):");
            foreach (byte b in data)
                retString.Append($"{b:X02} ");
            retString.Append("\n");
            return retString.ToString();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is AC2Pmessage)) return false;
            AC2Pmessage msg = obj as AC2Pmessage;
            if (msg.PGN != this.PGN) return false;
            if (msg.transmitterType != this.transmitterType) return false;
            if (msg.transmitterAdr != this.transmitterAdr) return false;
            if (msg.receiverAdr != this.receiverAdr) return false;
            if (msg.receiverType != this.receiverType) return false;
            for (int i = 0; i < data.Length; i++)
                if (msg.data[i] != this.data[i])
                    return false;
            return true;
        }

        public string VerboseInfo()
        {
            StringBuilder retString = new StringBuilder();
            PGN pgn = AC2P.PGNs[this.PGN];
            string sender,receiver;
            if (AC2P.DeviceTypes.ContainsKey(transmitterType))
                sender = AC2P.DeviceTypes[transmitterType];
            else
                sender = $"(неизвестное устройство №{transmitterType})";
            if (AC2P.DeviceTypes.ContainsKey(receiverType))
                receiver = AC2P.DeviceTypes[receiverType];
            else
                receiver = $"(неизвестное устройство №{receiverType})";
            retString.Append($"{sender}({transmitterAdr})->{receiver}({receiverAdr});");


            retString.Append(pgn.name + ';');
            if (pgn.multipack)
                retString.Append($"Мультипакет №{data[0]};");
            if (PGN == 1 && AC2P.commands.ContainsKey(new commandId(data[0], data[1])))
            {
                AC2Pcommand cmd = AC2P.commands[new commandId(data[0], data[1])];
                retString.Append(cmd.name + ";");
                if (cmd.parameters != null)
                    foreach (AC2Pparam p in cmd.parameters)
                        retString.Append(printParameter(p));
            }
            if (pgn.parameters != null)
                foreach (AC2Pparam p in pgn.parameters)
                    if (!pgn.multipack || data[0]==p.packNumber)
                    retString.Append(printParameter(p));
            return retString.ToString();
        }
    }
}

