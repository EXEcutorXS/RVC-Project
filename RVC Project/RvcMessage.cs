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
        { }

        private string bitMeaning(int dataByte, byte bitNum, string zeroMeaning, string oneMeaning, string paramName = "")
        {
            if (bitNum > 3)
                throw new ArgumentException("RV-C supports only 3 bit fields in one byte");
            dataByte = (dataByte >> (bitNum * 2)) & 0x3;
            switch (dataByte)
            {
                case 0: return paramName + paramName != "" ? ": " : "" + zeroMeaning + ";";
                case 1: return paramName + paramName.Length != "" ? ": " : "" + oneMeaning + ";";
                case 2: return (paramName.Length > 0) ? $"{paramName} Error;" : $"bit {bitNum} of {dataByte} is Error;";
                case 3: return (paramName.Length > 0) ? $"{paramName} not supported;" : "";
                default: return "";
            }
        }

        private string percent(byte dataByte, string paramName)
        {
            if (dataByte != 0xFF)
                return $"{paramName}: {dataByte / 2};";
            else
                return $"{paramName}: not connected;";
        }
        public RvcMessage(CanMessage msg)
        {
            if (msg == null)
                throw new ArgumentNullException("Source CAN Message can't be null");
            if (msg.DLC != 8)
                throw new ArgumentException("DLC of Source Message must be 8");
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
            if (obj == null)
                return false;
            if (!(obj is RvcMessage))
                return false;
            var comp = obj as RvcMessage;
            return GetCanMessage().Equals(comp.GetCanMessage());
        }

        public string DgnName()
        {
            switch (Dgn)
            {
                case 0x1FFF7: return "WATERHEATER_STATUS";
                case 0x1FFF6: return "WATERHEATER_COMMAND";

                case 0x1FE97: return "CIRCULATION_PUMP_STATUS";
                case 0x1FE96: return "CIRCULATION_PUMP_COMMAND";

                case 0x1FFE4: return "FURNACE_STATUS";
                case 0x1FFE3: return "FURNACE_COMMAND";


                case 0x1FFE2: return "THERMOSTAT_STATUS_1";
                case 0x1FEFA: return "THERMOSTAT_STATUS_2";

                case 0x1FEF9: return "THERMOSTAT_COMMAND_1";
                case 0x1FEF8: return "THERMOSTAT_COMMAND_2";

                case 0x1FF9C: return "THERMOSTAT_AMBIENT_STATUS";

                default: return "UNSUPPORTED_DGN";
            }
        }
        public string Meaning()
        {
            string res = "";
            switch (Dgn)
            {
                case 0x1FFF7:      //Water heater status;
                    res += $"Instance: {Data[0]};";
                    res += "Operating mode = ";
                    switch (Data[1])
                    {
                        case 0: res += "off;"; break;
                        case 1: res += "combustion;"; break;
                        case 2: res += "electric;"; break;
                        case 3: res += "gas/electric;"; break;
                        case 4: res += "automatic (electric if available, otherwise combustion);"; break;
                        case 5: res += "test combustiopn;"; break;
                        case 6: res += "test electric;"; break;
                        case 255: res += "no change;"; break;
                        default: res += "unsupported value;"; break;
                    }
                    if (Data[2] != 0xFF && Data[3] != 0xFF)
                    {
                        int Tsetpoint = (int)((Data[2] + Data[3] * 256) * 0.03125 - 273);
                        res += $", T setpoint = {Tsetpoint};";
                    }
                    if (Data[4] != 0xFF && Data[5] != 0xFF)
                    {
                        int Twater = (int)((Data[4] + Data[5] * 256) * 0.03125 - 273);
                        res += $", T water = {Twater};";
                    }
                    res += bitMeaning(Data[6], 0, "met", "not met", "Set point");
                    res += bitMeaning(Data[6], 1, "off", "lit", "Burner status");
                    res += bitMeaning(Data[6], 2, "active", "inactive", "Element status");
                    res += bitMeaning(Data[6], 3, "not tripped", "tripped", "High temp limit switch");
                    res += bitMeaning(Data[7], 0, "no", "yes", "Failed to ignite");
                    res += bitMeaning(Data[7], 1, "Present", "Not Present", "AC power failure");
                    res += bitMeaning(Data[7], 2, "DC Present", "DC not present", "DC power failure");
                    res += bitMeaning(Data[7], 3, "OK", "Warning", "DC warning");
                    return res;
                case 0x1FFE4:
                    res += $"Instance: {Data[0]};";
                    res += bitMeaning(Data[1], 0, "Automatic", "Manual", "Operating Mode");
                    res += "Heat source: ";
                    switch (Data[1] >> 2 & 0b111111)
                    {
                        case 0: res += "combustion;"; break;
                        case 1: res += "AC power primary;"; break;
                        case 2: res += "AC power secondary;"; break;
                        case 3: res += "Engine heat;"; break;
                        default: res += "Not supported;"; break;
                    }
                    res += $"Circulatin fan speed: {}"
                    return res;
                default: return "Unsupported DGN";
            }
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
