using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVC_Project
{
    internal class AdversCanMessage
    {
        private Dictionary<int, string> DeviceTypes = new Dictionary<int, string>() {
            { 0, "Любой" } ,
            { 1, "14ТС-Мини" } ,
            { 2, "Планар 2" } ,
            { 3, "Планар 44Д" } ,
            { 4, "30ТСД" } ,
            { 5, "30ТСГ" } ,
            { 6, "Binar-5S (бензин)" } ,
            { 7, "Планар 8Д" } ,
            { 8, "OB-8" } ,
            { 9, "Планар 4Д" } ,
            { 10, "Binar-5S diesel" } ,
            { 11, "Планар-9Д, ОВ-8ДК" } ,
            { 12, "Планар-44Б" } ,
            { 13, "Планар-4Б" } ,
            { 14, "Плита" } ,
            { 15, "Планар-44Г" } ,
            { 16, "ОВ-4" } ,
            { 17, "14ТСД-10" } ,
            { 18, "Планар 2Б" } ,
            { 19, "Блок управления клапанами." } ,
            { 20, "Планар-6Д" } ,
            { 21, "14ТС-10" } ,
            { 22, "30SP (впрысковый)" } ,
            { 23, "Бинар 5Б-Компакт" } ,
            { 25, "35SP (впрысковый)" } ,
            { 27, "Бинар 5Д-Компакт" } ,
            { 29, "Бинар 6Г-Компакт" } ,
            { 31, "14ТСГ-Мини" } ,
            { 32, "30SPG (на базе 30SP)" } ,
            { 34, "Binar-10Д" } ,
            { 35, "Binar-10Б" } ,
            { 123, "Bootloader" } ,
            { 126, "Устройство управления" }
        };
        public int PGN;
        public int receiverType;
        public int receiverAdr;
        public int transmitterType;
        public int transmitterAdr;
        public byte[] data;
        public AdversCanMessage(CanMessage msg)
        {
            PGN = (msg.ID >> 20) & 0b111111111;
            receiverType = (msg.ID >> 13) & 0b1111111;
            receiverAdr = (msg.ID >> 10) & 0b111;
            transmitterType = (msg.ID >> 3) & 0b1111111;
            transmitterAdr = msg.ID & 0b111;
            data = msg.Data;
        }

        public string GetVerboseInfo()
        {
            StringBuilder retString = new StringBuilder();

            string meaning = "";

            switch (PGN)
            {
                case 0:
                    meaning = $"Пустая комманда";
                    break;
                case 1:
                    retString.Append("Комманда: ");
                    switch (data[0])
                    {
                        case 0: meaning = "Кто здесь"; break;
                        case 1: meaning = $"Пуск устройства на {data[2] * 256 + data[3]} минут"; break;
                        case 3: meaning = "остановка устройства"; break;
                        case 4: meaning = $"пуск только помпы на {data[2] * 256 + data[3]} минут"; break;
                        case 5: meaning = "сброс неисправностей"; break;
                        case 6:
                            meaning = "задать параметры работы жидкостного подогревателя\n";
                            meaning += $"Время работы: {data[2] * 256 + data[3]} минут\n";
                            switch (data[4] & 0b1111)
                            {
                                case 0: meaning += "Режим: Обычный\n"; break;
                                case 1: meaning += "Режим: Экономичный\n"; break;
                                case 2: meaning += "Режим: Догреватель\n"; break;
                                case 3: meaning += "Режим: Отопление\n"; break;
                                case 4: meaning += "Режим: Отопительные системы\n"; break;
                                default: meaning += "Режим: Неизвестен\n"; break;
                            }
                            break;
                            switch ((data[4] >> 4) & 0b1111)
                            {
                                case 0: meaning += "Режим догрева: Отключен\n"; break;
                                case 1: meaning += "Режим догрева: Автоматический\n"; break;
                                case 2: meaning += "Режим догрева: Ручной\n"; break;
                                default: break;
                            }
                            break;
                            meaning += $"Уставка температуры: {data[5] * 256 + data[6]} градусов\n";
                            meaning += $"Работа помпы в ждущем режиме:{data[7] & 0b11}\n";
                            meaning += $"Работа помпы на заведённом двигателе:{(data[7] >> 2) & 0b11}\n";

                        case 7:
                            meaning = "запрос температурных переходов по режимам жидкостного подогревателя\n";
                            meaning += $"Номер мощности: {data[2]}";
                            if (data[3] + data[4] != 0 || data[5] + data[6] != 0)
                            {
                                meaning += $"Переход на большую мощность: {data[3] * 256 + data[4]} С\n";
                                meaning += $"Переход на меньшую мощность: {data[5] * 256 + data[6]} С\n";
                            }
                            break;
                        case 8:
                            meaning = "задать состояние клапанов устройства ”Блок управления клапанами”\n";
                            meaning = $"Клапан 1:{(data[2] >> 0) & 0b11}\n";
                            meaning = $"Клапан 2:{(data[2] >> 2) & 0b11}\n";
                            meaning = $"Клапан 3:{(data[2] >> 4) & 0b11}\n";
                            meaning = $"Клапан 4:{(data[2] >> 6) & 0b11}\n";
                            meaning = $"Клапан 5:{(data[3] >> 0) & 0b11}\n";
                            meaning = $"Клапан 6:{(data[3] >> 2) & 0b11}\n";
                            meaning = $"Клапан 7:{(data[3] >> 4) & 0b11}\n";
                            meaning = $"Клапан 8:{(data[3] >> 6) & 0b11}\n";
                            meaning = $"Сброс ошибок:{data[4] & 0b1}\n";
                            break;
                        case 9: meaning = "задать параметры работы воздушного отопителя"; break;
                        case 10: meaning = "апуск в режиме вентиляции (для воздушных отопителей)"; break;
                        case 20: meaning = "калибровка термопар"; break;
                        case 21: meaning = "задать параметры частоты ШИМ нагнетателя воздуха"; break;
                        case 22: meaning = "Reset CPU"; break;
                        case 45: meaning = "биты реакции на неисправности"; break;
                        case 65: meaning = "установить значение температуры"; break;
                        case 66: meaning = "сброс неисправностей"; break;
                        case 67: meaning = "вход/выход в стадию M (ручное управление) или T (тестирование блока управления)"; break;
                        case 68: meaning = "задание параметров устройств в стадии M (ручное управление)"; break;
                        case 69: meaning = "управление устройствами"; break;
                        default: meaning = "Неизвестная команда"; break;
                    }
                    break;
            }
            retString.Append(meaning);

            return retString.ToString();
        }
        public override string ToString()
        {
            StringBuilder retString = new StringBuilder();
            string transmitterName = "Unknown";
            string receiverName = "Unknown";
            if (DeviceTypes.ContainsKey(receiverType))
                receiverName = DeviceTypes[receiverType];
            if (DeviceTypes.ContainsKey(transmitterType))
                transmitterName = DeviceTypes[transmitterType];
            retString.Append($"[{transmitterType}]({transmitterAdr})->[{receiverType}]({receiverAdr}):");
            foreach (byte b in data)
                retString.Append($"{b:X02} ");


            retString.Append("\n");
            return retString.ToString();
        }
    }
}

