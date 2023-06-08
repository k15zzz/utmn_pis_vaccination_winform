using System;
using Model;
using PIS_WinForm;
using PIS_WinForm.GlobalClasses;
using PIS_WinForm.GlobalClasses.NonStaticClasses;
using PIS_WinForm.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Controller
{
    public static class Animal
    {
        public static Card.Animal LookAtCard(DataGridViewRow data) => Model.Animal.LookAtCard(data);

        public static bool Add(Card.Animal animal)
        {
            try
            {
                return Model.Animal.Add(animal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, List<string>> filter)
        {
            try
            {
                return Model.Animal.LookAll(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Delete(int id)
        {
            DBAdapter.Delete(id, "Animals");
        }

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Contract
    {
        public static void LookAll(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Delete(int id)
        {
            DBAdapter.Delete(id, "Contracts");
        }
        }
        
        //private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Organization
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Edit(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void LookAll(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();


        public static void Delete(int id)
        {
            DBAdapter.Delete(id, "Organizations");
        }

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Town
    {
        public static Dictionary<int, Dictionary<string, string>> LookAll() => DBAdapter.GetAll("Tows");

        public static void Edit(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();
        
        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Statistic
    {
        public static Dictionary<int, Dictionary<string, string>> LookAll() => DBAdapter.GetAll("Tows");
        
        public static PIS_WinForm.GlobalClasses.NonStaticClasses.Report MakeReport(DateTime dateStart, DateTime dateFinish, List<int> town) 
        {
            try
            {
                var report = Model.Statistic.MakeReport(dateStart, dateFinish, town);
                return report;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

