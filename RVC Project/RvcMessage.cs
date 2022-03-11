﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace RVC_Project
{
    static class RVC
    {
        static RVC()
        {

        }

        public static void SaveToFile()
        {
            JsonSerializer serialiser = new JsonSerializer();
            var fs = new FileStream("db.txt", FileMode.OpenOrCreate);
            TextWriter tw = new StreamWriter(fs);
            JsonWriter writer = new JsonTextWriter(tw);
            serialiser.Serialize(writer, DGNs);
            tw.Flush();
            tw.Close();
        }
        public static void SeedData()
        {
            Parameter newPar;
            DGN newDgn;

            newDgn = new DGN(true) { Dgn = 0x1FF9C, Name = "THERMOSTAT_AMBIENT_STATUS" };
            newDgn.Parameters.Add(new Parameter { Name = "Ambient temperature", ShortName = "Tamb", Type = parameterType.temperature, Size = parameterSize.uint16, firstByte = 1 });
            DGNs.Add(newDgn.Dgn, newDgn);

            newDgn = new DGN(true) { Dgn = 0x1FFE4, Name = "FURNACE_STATUS" };
            newDgn.Parameters.Add(new Parameter
            {
                Name = "Operating mode",
                ShortName = "Op mode",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 1,
                Meanings = { [0] = "Automatic", [1] = "Manual" }
            });
            newDgn.Parameters.Add(new Parameter
            {
                Name = "Heat Source",
                ShortName = "Heat Src",
                Type = parameterType.list,
                Size = parameterSize.uint6,
                firstByte = 1,
                firstBit = 2,
                Meanings = { [0] = "Combustion", [1] = "AC power primary", [2] = "AC power secondary", [3] = "Engine Heat" }
            });

            newDgn.Parameters.Add(new Parameter { Name = "Circulation fan speed", ShortName = "Fan%", Type = parameterType.percent, Size = parameterSize.uint8, firstByte = 2, firstBit = 0 });
            newDgn.Parameters.Add(new Parameter { Name = "Heat output level", ShortName = "Heat%", Type = parameterType.percent, Size = parameterSize.uint8, firstByte = 3, firstBit = 0 });
            newDgn.Parameters.Add(new Parameter { Name = "Dead band", ShortName = "Db", Type = parameterType.custom, Size = parameterSize.uint8, firstByte = 4, coefficient = 0.1, Unit = "C" });
            newDgn.Parameters.Add(new Parameter { Name = "Dead band level 2", ShortName = "Db2", Type = parameterType.custom, Size = parameterSize.uint8, firstByte = 5, coefficient = 0.1, Unit = "C" });
            newDgn.Parameters.Add(new Parameter { Name = "Zone overcurrent status", ShortName = "Zone OC", Type = parameterType.boolean, Size = parameterSize.uint2, firstByte = 6, firstBit = 0 });
            newDgn.Parameters.Add(new Parameter { Name = "Zone undercurrent status", ShortName = "Zone UC", Type = parameterType.boolean, Size = parameterSize.uint2, firstByte = 6, firstBit = 2 });
            newDgn.Parameters.Add(new Parameter
            {
                Name = "Zone temperature status",
                ShortName = "Zone t Status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 6,
                firstBit = 4,
                Meanings = { [0] = "Normal", [1] = "Warning" }
            });
            newDgn.Parameters.Add(new Parameter
            {
                Name = "Zone analog input status",
                ShortName = "Zone an",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 6,
                firstBit = 6,
                Meanings = { [0] = "Off(Inactive)", [1] = "On(Active)" }
            });
            DGNs.Add(newDgn.Dgn, newDgn);

            newDgn = new DGN(true) { Dgn = 0x1FFF7, Name = "WATERHEATER_STATUS" };
            newDgn.Parameters.Add(new Parameter
            {
                Name = "Operating modes",
                ShortName = "Mode",
                Type = parameterType.list,
                Size = parameterSize.uint8,
                firstByte = 1,
                Meanings = { [0] = "off", [1] = "combustion", [2] = "electric", [3] = "gas/electric (both)", [4] = "test combustion (forced on)", [5] = "test combustion (forced on)", [6] = "test electric (forced on)" }
            });

            newDgn.Parameters.Add(new Parameter { Name = "Set point temperature", ShortName = "SP T", Type = parameterType.temperature, Size = parameterSize.uint16, firstByte = 2 });

            newDgn.Parameters.Add(new Parameter { Name = "Water temperature", ShortName = "Twater", Type = parameterType.temperature, Size = parameterSize.uint16, firstByte = 4 });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Thermostat status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 6,
                firstBit = 0,
                Meanings = { [0] = "set point met", [1] = "set point not met (heat is being applied)" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Burner status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 6,
                firstBit = 2,
                Meanings = { [0] = "off", [1] = "burner is lit" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "AC element status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 6,
                firstBit = 4,
                Meanings = { [0] = "AC element is inactive", [1] = "AC element is active)" }
            });


            newDgn.Parameters.Add(new Parameter
            {
                Name = "High temperature limit switch status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 6,
                firstBit = 6,
                Meanings = { [0] = "limit switch not tripped", [1] = "limit switch tripped" }
            });

            newPar = new Parameter
            {
                Name = "Failure to ignite status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 7,
                firstBit = 0,
                Meanings = { [0] = "no failure", [1] = "device has failed to ignite" }
            };

            newPar = new Parameter
            {
                Name = "AC power failure status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 7,
                firstBit = 2,
                Meanings = { [0] = "AC power present", [1] = "AC power not present" }
            };

            newPar = new Parameter
            {
                Name = "DC power failure status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 7,
                firstBit = 4,
                Meanings = { [0] = "DC power present", [1] = "DC power not present" }
            };

            newPar = new Parameter
            {
                Name = "DC power warning status",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 7,
                firstBit = 6,
                Meanings = { [0] = "DC power sufficient", [1] = "DC power warning" }
            };

            DGNs.Add(newDgn.Dgn, newDgn);

            newDgn = new DGN(true) { Dgn = 0x1FFE2, Name = "THERMOSTAT_STATUS_1" };

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Operating mode",
                Type = parameterType.list,
                Size = parameterSize.uint4,
                firstByte = 1,
                Meanings = { [0] = "Off", [1] = "Cool", [2] = "Heat", [3] = "Auto heat/Cool", [4] = "Fan only", [5] = "Aux heat", [6] = "Window Defrost/Dehumidify" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Fan mode",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 1,
                firstBit = 4,
                Meanings = { [0] = "Auto", [1] = "On" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Schedule mode",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 1,
                firstBit = 6,
                Meanings = { [0] = "Disabled", [1] = "Enabled" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Fan speed",
                Type = parameterType.percent,
                Size = parameterSize.uint8,
                firstByte = 2,
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Setopint temp - Heat",
                Type = parameterType.temperature,
                Size = parameterSize.uint16,
                firstByte = 3,
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Setopint temp - Cool",
                Type = parameterType.temperature,
                Size = parameterSize.uint16,
                firstByte = 5,
            });

            DGNs.Add(newDgn.Dgn, newDgn);

            newDgn = new DGN(true) { Dgn = 0x1FEFA, Name = "THERMOSTAT_STATUS_2" };
            newDgn.Parameters.Add(new Parameter
            {
                Name = "Current schedule instatnce",
                Type = parameterType.custom,
                Size = parameterSize.uint8,
                firstByte = 1,
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Number of schedule instances",
                Type = parameterType.custom,
                Size = parameterSize.uint8,
                firstByte = 2,
            });


            newDgn.Parameters.Add(new Parameter
            {
                Name = "Reduced noise mode",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 3,
                Meanings = { [0] = "Disabled", [1] = "Endabled" }
            });

            DGNs.Add(newDgn.Dgn, newDgn);

            newDgn = new DGN(true) { Dgn = 0x1FEF7, Name = "THERMOSTAT_SCHEDULE_STATUS_1" };

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Schedule mode instance",
                Type = parameterType.list,
                Size = parameterSize.uint8,
                firstByte = 1,
                Meanings = { [0] = "Sleep", [1] = "Wake",[2]="Away",[3]="Return",[250]="Storage"}
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Start hour",
                Type = parameterType.custom,
                Size = parameterSize.uint8,
                firstByte = 2,
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Start minute",
                Type = parameterType.custom,
                Size = parameterSize.uint8,
                firstByte = 3,
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Setopint temp - Heat",
                Type = parameterType.temperature,
                Size = parameterSize.uint16,
                firstByte = 4,
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Setopint temp - Cool",
                Type = parameterType.temperature,
                Size = parameterSize.uint16,
                firstByte = 5,
            });

            DGNs.Add(newDgn.Dgn, newDgn);

            newDgn = new DGN(true) { Dgn = 0x1FEF6, Name = "THERMOSTAT_SCHEDULE_STATUS_2" };

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Schedule mode instance",
                Type = parameterType.list,
                Size = parameterSize.uint8,
                firstByte = 1,
                Meanings = { [0] = "Sleep", [1] = "Wake", [2] = "Away", [3] = "Return", [250] = "Storage" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Sunday",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 2,
                firstBit = 0,
                Meanings = { [0] = "Not scheduled for this day", [1] = "Schedule applies to this day"}
            });



            newDgn.Parameters.Add(new Parameter
            {
                Name = "Monday",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 2,
                firstBit = 2,
                Meanings = { [0] = "Not scheduled for this day", [1] = "Schedule applies to this day" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Tuesday",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 2,
                firstBit = 4,
                Meanings = { [0] = "Not scheduled for this day", [1] = "Schedule applies to this day" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Wednesday",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 2,
                firstBit = 6,
                Meanings = { [0] = "Not scheduled for this day", [1] = "Schedule applies to this day" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Thursday",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 3,
                firstBit = 0,
                Meanings = { [0] = "Not scheduled for this day", [1] = "Schedule applies to this day" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Friday",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 3,
                firstBit = 2,
                Meanings = { [0] = "Not scheduled for this day", [1] = "Schedule applies to this day" }
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Saturday",
                Type = parameterType.list,
                Size = parameterSize.uint2,
                firstByte = 3,
                firstBit = 4,
                Meanings = { [0] = "Not scheduled for this day", [1] = "Schedule applies to this day" }
            });

            DGNs.Add(newDgn.Dgn, newDgn);

            newDgn = new DGN(true) { Dgn = 0x1FE97, Name = "CIRCULATION_PUMP_STATUS" };

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Output status",
                Type = parameterType.list,
                Size = parameterSize.uint4,
                firstByte = 1,
                Meanings = { [0] = "Off", [1] = "On" ,[2]="Test (Forced On)"}
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Pump Overcurrent Status",
                Type = parameterType.list,
                Size = parameterSize.uint4,
                firstByte = 1,
                Meanings = { [0] = "No overcurrent detected", [1] = "Overcurrent detected" }
            });
            newDgn.Parameters.Add(new Parameter
            {
                Name = "Pump Undercurrent Status",
                Type = parameterType.list,
                Size = parameterSize.uint4,
                firstByte = 1,
                Meanings = { [0] = "No undercurrent detected", [1] = "Undercurrent detected"}
            });

            newDgn.Parameters.Add(new Parameter
            {
                Name = "Pump Temperature Status",
                Type = parameterType.list,
                Size = parameterSize.uint4,
                firstByte = 1,
                Meanings = { [0] = "Temperature normal", [1] = "Temperature warning"}
            });
            DGNs.Add(newDgn.Dgn, newDgn);
        }




        public static Dictionary<int, DGN> DGNs = new Dictionary<int, DGN>();

        public static string Decode(this RvcMessage msg)
        {
            if (!DGNs.ContainsKey(msg.Dgn))
                return $"{msg.Dgn} is not supported";
            return DGNs[msg.Dgn].Decode(msg.Data);
        }
    }
    public enum parameterSize
    {
        uint2, //uint2
        uint4,
        uint6,
        uint8,
        uint16,
        uint32,
    };

    public enum parameterType
    {
        boolean,
        list,
        instance,
        percent,
        temperature,
        voltage,
        amperage,
        hertz,
        watts,
        custom
    };

    public class DGN
    {
        public int Dgn;
        public string Name;
        public int MaxBroadcastGap = 5000;
        public int MinBroadcastGap = 500;
        public List<Parameter> Parameters;

        public DGN(bool addInstance = false)
        {
            Parameters = new List<Parameter>();
            if (addInstance) this.Parameters.Add(new Parameter { Name = "Instance", ShortName = "#", Type = parameterType.instance, Size = parameterSize.uint8, firstByte = 0 });
        }
        public string Decode(byte[] data)
        {
            string ret = Name + ":{";
            foreach (Parameter p in Parameters)
            {
                ret += p.ToString(data) + "; ";
            }
            ret += "}";
            return ret;
        }
    }
    public class Parameter
    {
        public string Name;
        public string ShortName;
        public parameterSize Size;
        public parameterType Type;
        public byte firstByte;
        public byte firstBit;
        public Dictionary<int, string> Meanings;
        public double coefficient = 1;
        public double shift = 0;
        public string Unit = "";

        public Parameter()
        {
            Meanings = new Dictionary<int, string>();
        }
        public string ToString(byte[] data, bool useFarenheit = false)
        {
            string retString = Name + ": ";

            int rawData = 0;
            double tempValue = 0;
            switch (Size)
            {
                case parameterSize.uint2: rawData = (data[firstByte] >> firstBit) & 0x3; break;
                case parameterSize.uint4: rawData = (data[firstByte] >> firstBit) & 0xF; break;
                case parameterSize.uint6: rawData = (data[firstByte] >> firstBit) & 0x3F; break;
                case parameterSize.uint8: rawData = (data[firstByte]); break;
                case parameterSize.uint16: rawData = (data[firstByte] + data[firstByte + 1] * 256); break;
                case parameterSize.uint32: rawData = (data[firstByte] + data[firstByte + 1] * 0x100 + data[firstByte + 2] * 0x10000 + data[firstByte + 3] * 0x1000000); break;
                default: throw new ArgumentException("Bad parameter size");
            }

            switch (Type)
            {
                case parameterType.percent:
                    tempValue = rawData / 2;
                    retString += tempValue.ToString() + "%";
                    break;
                case parameterType.instance:
                    tempValue = rawData;
                    retString += "#" + tempValue.ToString();
                    break;
                case parameterType.hertz:
                    tempValue = rawData;
                    retString += tempValue.ToString() + " Hz";
                    break;
                case parameterType.watts:
                    tempValue = rawData;
                    retString += tempValue.ToString() + " W";
                    break;
                case parameterType.amperage:
                    switch (Size)
                    {
                        case parameterSize.uint8: tempValue = rawData; break;
                        case parameterSize.uint16: tempValue = -1600 + rawData * 0.05; break;
                        case parameterSize.uint32: tempValue = -2000000000.0 + rawData * 0.001; break;
                        default: throw new Exception("Wrong size for Amperage field");
                    }
                    retString += tempValue.ToString() + "A";
                    break;
                case parameterType.voltage:
                    switch (Size)
                    {
                        case parameterSize.uint8: tempValue = rawData; break;
                        case parameterSize.uint16: tempValue = rawData * 0.05; break;
                        default: throw new Exception("Wrong size for Voltage field");
                    }
                    retString += tempValue.ToString() + "V";
                    break;

                case parameterType.temperature:
                    switch (Size)
                    {
                        case parameterSize.uint8: tempValue = -40 + rawData; break;
                        case parameterSize.uint16: tempValue = -273 + rawData * 0.03125; break;
                        default: throw new Exception("Wrong size for Temperature field");
                    }
                    if (useFarenheit) tempValue = tempValue * 9.0 / 5.0 + 32;
                    retString += tempValue.ToString() + (useFarenheit ? "F" : "C");
                    break;
                case parameterType.custom:
                    retString += $"{tempValue * coefficient + shift} {Unit}";
                    break;
                case parameterType.boolean:
                    switch (tempValue)
                    {
                        case 0: retString += "False"; break;
                        case 1: retString += "True"; break;
                        case 2: retString += "Error"; break;
                        case 3: retString += "Not supported"; break;
                    }
                    break;
                case parameterType.list:
                    if (!Meanings.ContainsKey(rawData))
                        retString += $"Parameter {Name} has no meaning for \"{rawData}!\"";
                    else
                        retString += Meanings[rawData];
                    break;


                default: throw new ArgumentException("Bad parameter type");
            }

            return retString;
        }
    }
    public sealed class RvcMessage
    {

        public byte Priority;
        public int Dgn;
        public byte SourceAdress;
        public byte[] Data = new byte[8];
        public byte Instance => Data[0];
        public RvcMessage()
        { }
        static bool showUnsupportedData = true;

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

        public override string ToString()
        {
            
            string ret = $"{Priority} | {Dgn:X05} {SourceAdress:D3} ||";
            foreach (var item in Data)
                ret += $" {item:X02} ";
            return ret;
            return this.Decode();
        }

        public string VerboseInfo()
        {
            return this.Decode();
        }
        public override int GetHashCode()
        {
            return GetCanMessage().GetHashCode();
        }
    }
}
