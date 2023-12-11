using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Bez
{
    internal static class DataManager
    {
        public static void Initialize()
        {
            InitializeDataPasswords();
            InitializeData();
        }

        private static void InitializeDataPasswords()
        {
            List<DataPassword> dataPasswords = new List<DataPassword>();

            DataPassword dataPassword1 = new("Employees.json", HashCodeConvertor.ConvertToHashCode("111"));
            DataPassword dataPassword2 = new("Subsidiaries.json", HashCodeConvertor.ConvertToHashCode("222"));
            DataPassword dataPassword3 = new("Revenue.json", HashCodeConvertor.ConvertToHashCode("333"));

            dataPasswords.Add(dataPassword1);
            dataPasswords.Add(dataPassword2);
            dataPasswords.Add(dataPassword3);

            File.WriteAllText("DataPasswords.json", JsonConvert.SerializeObject(dataPasswords, Formatting.Indented));
        }

        private static void InitializeData()
        {
            MessageContainer employees = new("\tСергей Владимирович\nВозраст: 21 год\nID: 2342342\n\tДмитрий Иванович\nВозраст: 31 год\nID: 6776823", 1);
            File.WriteAllText("Employees.json", JsonConvert.SerializeObject(employees, Formatting.Indented));

            MessageContainer subsidiaries = new("\tДочерние компании\nGrinding Gear Games\nRiot Games\nTencent Pictures\nYager Development\nIflix", 2);
            File.WriteAllText("Subsidiaries.json", JsonConvert.SerializeObject(subsidiaries, Formatting.Indented));

            MessageContainer revenue = new("\t\tВыручка\n\t2019 год\n 1.000.000 рублей\n\t2020 год\n 1.500.000 рублей\n\t2021 год\n 2.000.000 рублей", 3);
            File.WriteAllText("Revenue.json", JsonConvert.SerializeObject(revenue, Formatting.Indented));
        }
    }
}
