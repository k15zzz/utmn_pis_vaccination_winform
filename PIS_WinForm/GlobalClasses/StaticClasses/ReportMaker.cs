using PIS_WinForm.GlobalClasses.NonStaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PIS_WinForm.GlobalClasses.StaticClasses
{
    public static class ReportMaker
    {
        public static Report CreateReport(Dictionary<int, Dictionary<string, string>> report)
        {
            Dictionary<string, Dictionary<int, Dictionary<string, string>>> dataDroupByTown = GroupingByTown(report);

            var retorn = new Report();

            foreach (var town in dataDroupByTown)
            {
                var nameTown = town.Key;
                var countTown = CalculateCount(town.Value);
                var costTown = CalculateCost(town.Value);

                retorn.AddTown(nameTown, countTown, costTown);
            }

            return retorn;
        }

        private static int CalculateCount(Dictionary<int, Dictionary<string, string>> items)
        {
            return items.Count;
        }

        private static double CalculateCost(Dictionary<int, Dictionary<string, string>> items )
        {
            double cost = 0;

            foreach (var item in items)
                cost += double.Parse(item.Value["price"]);

            return cost;
        }

        private static Dictionary<string, Dictionary<int, Dictionary<string, string>>> GroupingByTown(Dictionary<int, Dictionary<string, string>> data)
        {
            var result = new Dictionary<string, Dictionary<int, Dictionary<string, string>>>();

            foreach (var value in data)
            {
                if (!result.ContainsKey(value.Value["town_name"]))
                {
                    result.Add(value.Value["town_name"], new Dictionary<int, Dictionary<string, string>>());
                }
                
                result[value.Value["town_name"]].Add(value.Key, value.Value);
            }

            return result;
        }
    }
}
