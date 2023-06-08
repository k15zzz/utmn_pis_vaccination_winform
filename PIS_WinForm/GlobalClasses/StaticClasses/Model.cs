using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;
using PIS_WinForm;
using PIS_WinForm.GlobalClasses.NonStaticClasses;
using PIS_WinForm.GlobalClasses.StaticClasses;

namespace Model
{
    public static class Animal
    {
        public static Card.Animal LookAtCard(DataGridViewRow data)
        {
            var returanbleValues = new Dictionary<string, string>()
            {
                { "regNum", data.Cells[1].Value.ToString() },
                { "category", data.Cells[4].Value.ToString() },
                { "sex", data.Cells[5].Value.ToString() },
                { "burthYear", data.Cells[6].Value.ToString() },
                { "town_id", data.Cells[3].Value.ToString() },
                { "name", data.Cells[8].Value.ToString() },
                { "e-chipNumber", data.Cells[7].Value.ToString() },
                { "specMarcks", data.Cells[10].Value.ToString() },
                { "photos", data.Cells[9].Value.ToString() }
            };
            return new Card.Animal(returanbleValues);
        }

        private static readonly string _tableName = "Animals";
        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, List<string>> filter)
            => GenericMethods.LookAll(_tableName, filter, ReplaceFields);

        private static Dictionary<int, Dictionary<string, string>> ReplaceFields(Dictionary<int, Dictionary<string, string>> filteredtable, Dictionary<string, Dictionary<int, Dictionary<string, string>>> db)
        {
            var templeDictionry = new Dictionary<int, Dictionary<string, string>>();
            foreach (var item in filteredtable)
            {
                templeDictionry.Add(item.Key, new Dictionary<string, string>());
                foreach (var itemValue in item.Value)
                    templeDictionry[item.Key].Add(itemValue.Key, itemValue.Value);
            }

            foreach (var item in templeDictionry)
            {
                templeDictionry[item.Key].Add("townName", db["Tows"][int.Parse(item.Value["town_id"])]["name"]);
            }
            return templeDictionry;
        }

        public static bool Add(Card.Animal animal)
        {
            bool adding;
            try
            {
                adding = PermissionGuard.CanAdd("Animals");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            bool allIsNotEmpty = ChechOnEmptyFields(animal);
            if (allIsNotEmpty)
            {
                return DBAdapter.AddAnimal(animal);
            }
            else
            {
                throw new Exception("Fill all fields");
            }
        }
        private static List<string> category = new List<string>();
        private static List<string> sex = new List<string>();
        private static bool ChechOnEmptyFields(Card.Animal animal)
        {
            var animals = DBAdapter.GetAll("Animals");
            foreach (var item in animals)
            {
                if(!category.Contains(item.Value["сategory"]))
                {
                    category.Add(item.Value["сategory"]);
                }
            }
            foreach (var item in animals)
            {
                if (!sex.Contains(item.Value["sex"]))
                {
                    sex.Add(item.Value["sex"]);
                }
            }
            bool allNotEmpty = false;
            foreach (string categ in category)
            {
                if (animal.category == categ)
                {
                    allNotEmpty = true;
                    break;
                }
            }
            if (!allNotEmpty) return false;
            allNotEmpty = false;
            foreach (string s in sex)
            {
                if (animal.sex == s)
                {
                    allNotEmpty = true;
                    break;
                }
            }
            if (!allNotEmpty) return false;
            if (animal.burthYear.Length == 4) allNotEmpty = true;
            if (!allNotEmpty) return false;
            if (animal.town_id.Length > 0) allNotEmpty = true;
            if (!allNotEmpty) return false;
            if (animal.name.Length > 0) allNotEmpty = true;
            if (!allNotEmpty) return false;
            if (animal.chipNumber.Length > 0) allNotEmpty = true;
            if (!allNotEmpty) return false;
            if (animal.specMarcks.Length > 0) allNotEmpty = true;
            if (!allNotEmpty) return false;
            //проверка фото?
            else return true;
        }

        public static void Delete(int id)
        {
            DBAdapter.Delete(id, "Animals");
        }
    }

    public static class Organizations
    {
        private static readonly string _tableName = "Organizations";

        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, List<string>> filter)
            => GenericMethods.LookAll(_tableName, filter, ReplaceFields);

        private static Dictionary<int, Dictionary<string, string>> ReplaceFields(Dictionary<int, Dictionary<string, string>> filteredtable, Dictionary<string, Dictionary<int, Dictionary<string, string>>> db)
        {
            var templeDictionry = new Dictionary<int, Dictionary<string, string>>();
            foreach (var item in filteredtable)
            {
                templeDictionry.Add(item.Key, new Dictionary<string, string>());
                foreach (var itemValue in item.Value)
                    templeDictionry[item.Key].Add(itemValue.Key, itemValue.Value);
            }

            foreach (var item in templeDictionry)
            {
                templeDictionry[item.Key].Add("townName", db["Tows"][int.Parse(item.Value["town_id"])]["name"]);
            }
            return templeDictionry;
        }

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();
        
        public static void Delete(int id)
        {
            DBAdapter.Delete(id, "Organizations");
        }
    }

    public static class Contracts
    {
        private static readonly string _tableName = "Contracts";

        public static Card.Contract LookAtCard(DataGridViewRow data)
        {
            var returanbleValues = new Dictionary<string, string>()
            {
                { "number", data.Cells[1].Value.ToString() },
                { "startDate", data.Cells[2].Value.ToString() },
                { "endDate", data.Cells[3].Value.ToString() },
                { "ispolnitel_id", data.Cells[5].Value.ToString() },
                { "zacazchik_id", data.Cells[7].Value.ToString() }
            };
            return new Card.Contract(returanbleValues);
        }

        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, List<string>> filter)
            => GenericMethods.LookAll(_tableName, filter, ReplaceFields);

        private static Dictionary<int, Dictionary<string, string>> ReplaceFields(Dictionary<int, Dictionary<string, string>> filteredtable, Dictionary<string, Dictionary<int, Dictionary<string, string>>> db)
        {
            var templeDictionry = new Dictionary<int, Dictionary<string, string>>();
            foreach (var item in filteredtable)
            {
                templeDictionry.Add(item.Key, new Dictionary<string, string>());
                foreach (var itemValue in item.Value)
                    templeDictionry[item.Key].Add(itemValue.Key, itemValue.Value);
            }

            foreach (var item in templeDictionry)
            {
                templeDictionry[item.Key].Add("ispolnitelName", db["Organizations"][int.Parse(item.Value["ispolnitel_id"])]["fullName"]);
                templeDictionry[item.Key].Add("zacazchikName", db["Organizations"][int.Parse(item.Value["zacazchik_id"])]["fullName"]);
            }
            return templeDictionry;
        }

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Delete(int id)
        {
            DBAdapter.Delete(id, "Contracts");

        }
    }

    public static class Town
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();
    }

    public static class Statistic
    {
        public static Report MakeReport(DateTime dateStart, DateTime dateFinish, List<int> town)
        {
            //if (PermissionGuard.CanStatistic())
            //    throw new Exception();

            var data = DBAdapter.GetDateStatistic(dateStart, dateFinish, town);

            var report = ReportMaker.CreateReport(data);

            return report;
        }
    }

    public static class GenericMethods
    {
        public static Dictionary<int, Dictionary<string, string>> LookAll(
            string tableName,
            Dictionary<string,List<string>> filter,
            Func<Dictionary<int, Dictionary<string, string>>, Dictionary<string, Dictionary<int, Dictionary<string, string>>>, Dictionary<int, Dictionary<string, string>>> ReplaceFields)
        {

            if (PermissionGuard.CanLookAll(tableName))
            {
                foreach (var filt in filter)
                    if (filt.Value.Count == 0 || filt.Value[0] == null) filter.Remove(filt.Key);
                return DBAdapter.LookAll(tableName, filter, ReplaceFields);
            }
            else
            {
                throw new Exception("У вас не достаточно прав");
            }
        }
    }
}

