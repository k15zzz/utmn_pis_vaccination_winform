using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using PIS_WinForm;
using PIS_WinForm.GlobalClasses.NonStaticClasses;
using PIS_WinForm.GlobalClasses.StaticClasses;

namespace Model
{
    public static class Animal
    {
        private static readonly string _tableName = "Animals";
        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, List<string>> filter)
        {
            try
            {
                PermissionGuard.CanLookAll(_tableName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach (var filt in filter)
            {
                if (filt.Value.Count == 0 || filt.Value[0] == null) filter.Remove(filt.Key);
            }
            return DBAdapter.LookAll(_tableName,
                filter,
                ReplaceFields);
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
        
        public static void Delete(int id) 
        {
            if (PermissionGuard.CanDelete("Animal"))
            {
                var dict = DBAdapter.GetAll("Animals");
                if (dict.ContainsKey(id))
                {
                  //  Controller.Animal.Delete(id);
                }
                else
                {
                    MessageBox.Show("Такого животного не существует в реестре");
                }
            }
            else
            {
                MessageBox.Show("У вас нет прав на это действие");
            }
        }
    }

    public static class Organizations
    {

        public static void LookAll(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();
        public static void Delete(int id)
        {
            if (PermissionGuard.CanDelete("Organizations"))
            {
                var dict = DBAdapter.GetAll("Organizations");
                if (dict.ContainsKey(id))
                {
                //    Controller.Organization.Delete(id);
                }
                else
                {
                    MessageBox.Show("Такой организации не существует в реестре");
                }
            }
            else
            {
                MessageBox.Show("У вас нет прав на это действие");
            }
        }
}

    public static class Contracts
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();
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

}

