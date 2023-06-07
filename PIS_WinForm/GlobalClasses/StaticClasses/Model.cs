using System;
using PIS_WinForm;
using PIS_WinForm.GlobalClasses.NonStaticClasses;
using PIS_WinForm.GlobalClasses.StaticClasses;

namespace Model
{
    public static class Animal
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();
    }

    public static class Organizations
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Add(string[,] filter, string[,] sort) => throw new NotImplementedException();
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
