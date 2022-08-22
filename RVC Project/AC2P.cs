using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace RVC_Project
{

    public class Device
    {
        public int ID;
        public string Name;
        public List<commandId> SupportedCommands;
        public string photo;


        public override string ToString()
        {
            return Name;
        }

    }
    public class DeviceStatus
    {
        public Dictionary<string, double> Variables;
    }
    public class ConnectedDevice
    {
        public deviceId ID;
        public Dictionary<DateTime, DeviceStatus> Statuses;
        public Dictionary<int, int> Parameters = new Dictionary<int, int>() { { 0, 0 } };
        public override string ToString()
        {
            if (AC2P.Devices.ContainsKey(ID.Type))
                return AC2P.Devices[ID.Type].Name;
            else
                return $"No device <{ID.Type}> in list";
        }

    }
    public struct commandId
    {
        public byte firstByte;
        public byte secondByte;

        public commandId(byte fb, byte sb)
        {
            firstByte = fb;
            secondByte = sb;
            return;
        }
    }

    public struct deviceId
    {
        public int Type;
        public int Adress;
        public deviceId(int type, int adr)
        {
            if (type > 127 || adr > 6)
                throw new ArgumentException("Bad device config adress must be below 7 and Type - below 127");
            Type = type;
            Adress = adr;
            return;
        }
        public override string ToString()
        {
            if (AC2P.Devices.ContainsKey(Type))
                return $"{Type} - {Adress} ({AC2P.Devices[Type]})";
            else
                return $"{Type} - {Adress}";
        }
    }

    public class configParameter
    {
        public int id;
        public string idString;
        public string nameRu;
        public string nameEn;

    }
    static class AC2P
    {
        public static CanAdapter adapter; //can adapter reference

        public static void ParceCanMessage(CanMessage msg)
        {
            AC2Pmessage m = msg.ToAdversCanMessage();
            deviceId id;
            id.Adress = m.transmitterAdr;
            id.Type = m.transmitterType;

            if (!connectedDevices.ContainsKey(id))
                connectedDevices.Add(id, new ConnectedDevice() { ID = id });

            if (m.PGN == 4) //Получили ответ на параметр
            {
                int parameterId = m.data[1] + m.data[0] * 256;
                int parameterValue = m.data[2] << 24 + m.data[3] << 16 + m.data[4] << 8 + m.data[5];
                if (parameterValue != 65535)
                {
                    if (!connectedDevices[id].Parameters.ContainsKey(parameterId))
                        connectedDevices[id].Parameters.Add(parameterId, parameterValue);
                    else
                        connectedDevices[id].Parameters[parameterId] = parameterValue;
                }
            }

        }
        public static void Parce(string filePath = "paramsname.h")
        {
            StreamReader sr = new StreamReader(filePath, System.Text.Encoding.GetEncoding(1251));
            while (!sr.EndOfStream)
            {
                string tempString = sr.ReadLine();
                List<string> tempList = new List<string>();
                int ParamNumber;
                string CodeName;
                string englishDescription;
                string russianDescription;


                if (tempString.StartsWith("#define PAR"))
                {
                    tempString = tempString.Remove(0, 8);
                    englishDescription = tempString.Substring(tempString.LastIndexOf('@') + 1);
                    russianDescription = tempString.Substring(tempString.LastIndexOf("//") + 2, tempString.LastIndexOf('@') - tempString.LastIndexOf("//") - 2);
                    tempString = tempString.Remove(tempString.IndexOf('/'));
                    tempList = tempString.Split(' ').ToList();
                    CodeName = tempList[0];
                    ParamNumber = int.Parse(tempList.Last());
                    tempString = "";
                    configParameters.Add(ParamNumber, new configParameter() { id = ParamNumber, idString = CodeName, nameRu = russianDescription, nameEn = englishDescription });
                }
            }
        }


        public static async void ReadParameters(int deviceType, int adress)
        {
            foreach (var p in configParameters)
            {
                AC2Pmessage msg = new AC2Pmessage();
                msg.PGN = 3;
                msg.transmitterAdr = 6;
                msg.transmitterType = 126;
                msg.receiverAdr = adress;
                msg.receiverType = deviceType;
                msg.data[0] = (byte)(p.Key / 256);
                msg.data[1] = (byte)(p.Key % 256);
                adapter.SendMessage(msg.ToCanMessage());
                Thread.Sleep(100);
            }
        }

        public static Dictionary<int, Device> Devices = new Dictionary<int, Device>() {
            { 0, new Device(){ID=0,Name="Любой" } } ,
            { 1, new Device(){ID=1,Name="14ТС-Мини" } } ,
            { 2, new Device(){ID=2,Name="Планар 2" }} ,
            { 3, new Device(){ID=3,Name="Планар 44Д" }} ,
            { 4, new Device(){ID=4,Name="30ТСД" }} ,
            { 5, new Device(){ID=5,Name="30ТСГ" }} ,
            { 6, new Device(){ID=6,Name="Binar-5S B" }} ,
            { 7, new Device(){ID=7,Name="Планар 8Д" }} ,
            { 8, new Device(){ID=8,Name="OB-8" }} ,
            { 9, new Device(){ID=9,Name="Планар 4Д" }} ,
            { 10, new Device(){ID=10,Name="Binar-5S D" }} ,
            { 11, new Device(){ID=11,Name="Планар-9Д, ОВ-8ДК" }} ,
            { 12, new Device(){ID=12,Name="Планар-44Б" }} ,
            { 13, new Device(){ID=13,Name="Планар-4Б" }} ,
            { 14, new Device(){ID=14,Name="Плита" }} ,
            { 15, new Device(){ID=15,Name="Планар-44Г" }} ,
            { 16, new Device(){ID=16,Name="ОВ-4" }} ,
            { 17, new Device(){ID=17,Name="14ТСД-10" }} ,
            { 18, new Device(){ID=18,Name="Планар 2Б" }} ,
            { 19, new Device(){ID=19,Name="Блок управления клапанами." }} ,
            { 20, new Device(){ID=20,Name="Планар-6Д" }} ,
            { 21, new Device(){ID=21,Name="14ТС-10" }} ,
            { 22, new Device(){ID=22,Name="30SP (впрысковый)" }} ,
            { 23, new Device(){ID=23,Name="Бинар 5Б-Компакт" }} ,
            { 25, new Device(){ID=25,Name="35SP (впрысковый)" }} ,
            { 27, new Device(){ID=27,Name="Бинар 5Д-Компакт" }} ,
            { 29, new Device(){ID=29,Name="Бинар 6Г-Компакт" }} ,
            { 31, new Device(){ID=31,Name="14ТСГ-Мини" }} ,
            { 32, new Device(){ID=32,Name="30SPG (на базе 30SP)" }} ,
            { 34, new Device(){ID=34,Name="Binar-10Д" }} ,
            { 35, new Device(){ID=35,Name="Binar-10Б" }} ,
            { 123, new Device(){ID=123,Name="Bootloader" }} ,
            { 126, new Device(){ID=126,Name="Устройство управления" }}
        };

        public static Dictionary<int, PGN> PGNs = new Dictionary<int, PGN>();

        public static Dictionary<commandId, AC2Pcommand> commands = new Dictionary<commandId, AC2Pcommand>();

        public static Dictionary<deviceId, ConnectedDevice> connectedDevices = new Dictionary<deviceId, ConnectedDevice>() { { new deviceId(0, 0), new ConnectedDevice() } };


        static Dictionary<int, string> defMeaningsYesNo = new Dictionary<int, string>() { [0] = "Нет", [1] = "Да", [2] = "Нет данных", [3] = "Нет данных" };
        static Dictionary<int, string> defMeaningsOnOff = new Dictionary<int, string>() { [0] = "Выкл", [1] = "Вкл", [2] = "Нет данных", [3] = "Нет данных" };
        static Dictionary<int, configParameter> configParameters = new Dictionary<int, configParameter>();


        static AC2P()
        {
            PGNs.Add(0, new PGN() { id = 0, name = "Пустая команда" });
            PGNs.Add(1, new PGN() { id = 1, name = "Комманда управления" });
            PGNs.Add(2, new PGN() { id = 2, name = "Подтверждение на принятую комманду" });
            PGNs.Add(3, new PGN() { id = 3, name = "Запрос параметра или набора данных по определенному номеру (SPN)" });
            PGNs.Add(4, new PGN() { id = 4, name = "Ответ на запрос параметра или набора данных по определенному номеру (SPN)" });
            PGNs.Add(5, new PGN() { id = 5, name = "Запись параметра или набора данных устройства" });
            PGNs.Add(6, new PGN() { id = 6, name = "Запрос параметров по PGN" });
            PGNs.Add(7, new PGN() { id = 7, name = "Запись/чтение параметров работы (конфигурация) в/из flash-памяти" });
            PGNs.Add(8, new PGN() { id = 8, name = "Работа с ЧЯ" });
            PGNs.Add(10, new PGN() { id = 10, name = "Стадия, режим, код неисправности, код предупреждения" });
            PGNs.Add(11, new PGN() { id = 11, name = "Напряжение питания, атмосферное давление, ток двигателя" });
            PGNs.Add(12, new PGN() { id = 12, name = "Обороты НВ, частота ТН, свеча, реле" });
            PGNs.Add(13, new PGN() { id = 13, name = "Температуры жидкостных подогревателей" });
            PGNs.Add(14, new PGN() { id = 14, name = "Слежение за пламенем" });
            PGNs.Add(15, new PGN() { id = 15, name = "АЦП 0-3 каналы" });
            PGNs.Add(16, new PGN() { id = 16, name = "АЦП 4-7 каналы" });
            PGNs.Add(17, new PGN() { id = 17, name = "АЦП 8-11 каналы" });
            PGNs.Add(18, new PGN() { id = 18, name = "Версия и дата программного обеспечения" });
            PGNs.Add(19, new PGN() { id = 19, name = "Параметры от центрального блока управления для подогревателя в системе отопления", multipack = true });
            PGNs.Add(20, new PGN() { id = 20, name = "Неисправности" });
            PGNs.Add(21, new PGN() { id = 21, name = "Блок управления системой отопления" });
            PGNs.Add(22, new PGN() { id = 22, name = "Блок управления системой отопления" });
            PGNs.Add(23, new PGN() { id = 23, name = "Блок управления системой отопления" });
            PGNs.Add(24, new PGN() { id = 24, name = "Блок управления системой отопления" });
            PGNs.Add(25, new PGN() { id = 25, name = "Блок управления системой отопления" });
            PGNs.Add(26, new PGN() { id = 26, name = "Блок управления системой отопления" });
            PGNs.Add(27, new PGN() { id = 27, name = "Блок управления системой отопления" });
            PGNs.Add(28, new PGN() { id = 28, name = "Общее время наработки подогревателя" });
            PGNs.Add(29, new PGN() { id = 29, name = "Параметры давления", multipack = true });
            PGNs.Add(30, new PGN() { id = 30, name = "Состояние сигнализации, двигателя автомобиля. Температура датчика воздуха. Напряжение канала двигателя автомобиля" });
            PGNs.Add(31, new PGN() { id = 31, name = "Время работы" });
            PGNs.Add(32, new PGN() { id = 32, name = "Параметры работы жидкостного подогревателя" });
            PGNs.Add(33, new PGN() { id = 33, name = "Серийный номер изделия (мультипакет)", multipack = true });
            PGNs.Add(34, new PGN() { id = 34, name = "Считать данные из flash по адресу" });
            PGNs.Add(35, new PGN() { id = 35, name = "Передача данных на запрос по PGN 34" });
            PGNs.Add(36, new PGN() { id = 36, name = "Передача состояния клапанов, зонда, кода неисправности клапанов" });
            PGNs.Add(37, new PGN() { id = 37, name = "Температуры воздушных отопителей (мультипакет)", multipack = true });
            PGNs.Add(38, new PGN() { id = 38, name = "Температура датчика в пульте" });
            PGNs.Add(39, new PGN() { id = 39, name = "Статусы драйверов ТН, свечи, помпа, реле" });
            PGNs.Add(100, new PGN() { id = 100, name = "Управления памятью (Мультипакет)", multipack = true });
            PGNs.Add(101, new PGN() { id = 101, name = "Заполнение буферного массива для последующей записи во флэш" });

            commands.Add(new commandId(0, 0), new AC2Pcommand() { firstByte = 0, secondByte = 0, name = "Кто здесь?" });
            commands.Add(new commandId(0, 1), new AC2Pcommand() { firstByte = 0, secondByte = 1, name = "пуск устройства" });
            commands.Add(new commandId(0, 3), new AC2Pcommand() { firstByte = 0, secondByte = 3, name = "остановка устройства" });
            commands.Add(new commandId(0, 4), new AC2Pcommand() { firstByte = 0, secondByte = 4, name = "пуск только помпы" });
            commands.Add(new commandId(0, 5), new AC2Pcommand() { firstByte = 0, secondByte = 5, name = "сброс неисправностей" });
            commands.Add(new commandId(0, 6), new AC2Pcommand() { firstByte = 0, secondByte = 6, name = "задать параметры работы жидкостного подогревателя" });
            commands.Add(new commandId(0, 7), new AC2Pcommand() { firstByte = 0, secondByte = 7, name = "запрос температурных переходов по режимам жидкостного подогревателя" });
            commands.Add(new commandId(0, 8), new AC2Pcommand() { firstByte = 0, secondByte = 8, name = "задать состояние клапанов устройства ”Блок управления клапанами”" });
            commands.Add(new commandId(0, 9), new AC2Pcommand() { firstByte = 0, secondByte = 9, name = "задать параметры работы воздушного отопителя" });
            commands.Add(new commandId(0, 10), new AC2Pcommand() { firstByte = 0, secondByte = 10, name = "запуск в режиме вентиляции (для воздушных отопителей)" });
            commands.Add(new commandId(0, 20), new AC2Pcommand() { firstByte = 0, secondByte = 20, name = "калибровка термопар" });
            commands.Add(new commandId(0, 21), new AC2Pcommand() { firstByte = 0, secondByte = 21, name = "задать параметры частоты ШИМ нагнетателя воздуха" });
            commands.Add(new commandId(0, 22), new AC2Pcommand() { firstByte = 0, secondByte = 22, name = "Reset CPU" });
            commands.Add(new commandId(0, 45), new AC2Pcommand() { firstByte = 0, secondByte = 45, name = "биты реакции на неисправности" });
            commands.Add(new commandId(0, 65), new AC2Pcommand() { firstByte = 0, secondByte = 65, name = "установить значение температуры" });
            commands.Add(new commandId(0, 66), new AC2Pcommand() { firstByte = 0, secondByte = 66, name = "сброс неисправностей" });
            commands.Add(new commandId(0, 67), new AC2Pcommand() { firstByte = 0, secondByte = 67, name = "вход/выход в стадию M (ручное управление) или T (тестирование блока управления)" });
            commands.Add(new commandId(0, 68), new AC2Pcommand() { firstByte = 0, secondByte = 68, name = "задание параметров устройств в стадии M (ручное управление)" });
            commands.Add(new commandId(0, 69), new AC2Pcommand() { firstByte = 0, secondByte = 69, name = "управление устройствами" });

            PGNs[3].parameters.Add(new AC2Pparam() { name = "SPN", bitLength = 16, startBit = 0, startByte = 0 });

            PGNs[4].parameters.Add(new AC2Pparam() { name = "Value", bitLength = 32, startBit = 0, startByte = 0 });

            PGNs[19].parameters.Add(new AC2Pparam() { name = "Подогреватель", bitLength = 2, startBit = 0, startByte = 1, packNumber = 1, meanings = defMeaningsOnOff });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Помпы", bitLength = 2, startBit = 2, startByte = 1, packNumber = 1, meanings = defMeaningsOnOff });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Вода", bitLength = 2, startBit = 4, startByte = 1, packNumber = 1, meanings = defMeaningsOnOff });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Быстрый нагрев воды", bitLength = 2, startBit = 6, startByte = 1, packNumber = 1, meanings = defMeaningsOnOff });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Температура бака", bitLength = 8, startByte = 2, b = -75, unit = "°С", packNumber = 1 });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Атмосферное давление", bitLength = 8, startByte = 3, unit = "кПа", packNumber = 1 });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Сработал датчик бытовой воды", bitLength = 2, startByte = 4, packNumber = 1, meanings = defMeaningsYesNo });

            PGNs[19].parameters.Add(new AC2Pparam() { name = "Уставка температуры жидкости подогревателя для перехода в ждущий.", bitLength = 8, startByte = 1, b = -75, packNumber = 2 });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Уставка температуры жидкости подогревателя для выхода из ждущего.", bitLength = 8, startByte = 2, b = -75, packNumber = 2 });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Уставка температуры жидкости подогревателя для выхода из ждущего при разборе воды.", bitLength = 8, startByte = 3, b = -75, packNumber = 2 });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Уставка температуры бака для перехода в ждущий.", bitLength = 8, startByte = 4, b = -75, packNumber = 2 });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Уставка температуры бака для выхода из ждущего.", bitLength = 8, startByte = 5, b = -75, packNumber = 2 });
            PGNs[19].parameters.Add(new AC2Pparam() { name = "Уставка температуры бака для выхода из ждущего при разборе воды.", bitLength = 8, startByte = 6, b = -75, packNumber = 2 });

            PGNs[29].parameters.Add(new AC2Pparam() { name = "Атмосферное давление", bitLength = 8, startByte = 1, unit = "кПа", packNumber = 1 });
            PGNs[29].parameters.Add(new AC2Pparam() { name = "Среднее максимальное значение давления", bitLength = 24, startByte = 2, unit = "кПа", a = 0.001, packNumber = 1 });
            PGNs[29].parameters.Add(new AC2Pparam() { name = "Среднее минимальное значение давления", bitLength = 24, startByte = 4, unit = "кПа", a = 0.001, packNumber = 1 });

            PGNs[29].parameters.Add(new AC2Pparam() { name = "Разница между max и min  значениями", bitLength = 16, startByte = 1, a = 0.01, unit = "кПа", packNumber = 2 });
            PGNs[29].parameters.Add(new AC2Pparam() { name = "Флаг появления пламени по пульсации давления", bitLength = 2, startByte = 3, meanings = defMeaningsYesNo, packNumber = 2 });
            PGNs[29].parameters.Add(new AC2Pparam() { name = "Атмосферное давление", bitLength = 24, startByte = 4, unit = "кПа", a = 0.001, packNumber = 2 });
        }


    }
}
