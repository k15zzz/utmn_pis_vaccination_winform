using System;
using Model;
using PIS_WinForm.GlobalClasses;
using PIS_WinForm.GlobalClasses.NonStaticClasses;
using PIS_WinForm;
using PIS_WinForm.Forms;

namespace Controller
{
    public static class Animal
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Edit(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Contract
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Edit(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Organization
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Edit(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();

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
        public static PIS_WinForm.GlobalClasses.NonStaticClasses.Report MakeReport(DateTime dateStart, DateTime dateFinish, List<int> town) 
        {
            //try
            //{
                var report = Model.Statistic.MakeReport(dateStart, dateFinish, town);
                return report;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}
