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

        public static bool Edit(Card.Animal animal)
        {
            try
            {
                return Model.Animal.Edit(animal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int id)
        {

            if (PermissionGuard.CanDelete("Animals"))
            {
                var dict = DBAdapter.GetAll("Animals");
                if (dict.ContainsKey(id))
                {
                    Model.Animal.Delete(id);
                }
                else
                {
                    MessageBox.Show("������ ��������� �� ���������� � �������");
                }
            }
            else
            {
                MessageBox.Show("� ��� ��� ���� �� ��� ��������");
            }
        }

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Contract
    {
        public static Card.Contract LookAtCard(DataGridViewRow data) => Model.Contracts.LookAtCard(data);

        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, List<string>> filter)
        {
            try
            {
                return Model.Contracts.LookAll(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Delete(int id)
        {

            if (PermissionGuard.CanDelete("Contracts"))
            {
                var dict = DBAdapter.GetAll("Contracts");
                if (dict.ContainsKey(id))
                {
                    Model.Contracts.Delete(id);
                }
                else
                {
                    MessageBox.Show("������ ��������� �� ���������� � �������");
                }
            }
            else
            {
                MessageBox.Show("� ��� ��� ���� �� ��� ��������");
            }
        }
    }

    //private static bool ChechOnEmptyFields() => throw new NotImplementedException();


    public static class Organization
    {
        public static Card.Organization LookAtCard(DataGridViewRow data) => Model.Organizations.LookAtCard(data);

        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, List<string>> filter)
        {
            try
            {
                return Model.Organizations.LookAll(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();


        public static void Delete(int id)
        {
            if (PermissionGuard.CanDelete("Organizations"))
            {
                var dict = DBAdapter.GetAll("Organizations");
                if (dict.ContainsKey(id))
                {
                    Model.Organizations.Delete(id);
                }
                else
                {
                    MessageBox.Show("����� ����������� �� ���������� � �������");
                }
            }
            else
            {
                MessageBox.Show("� ��� ��� ���� �� ��� ��������");
            }

        }

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Town
    {
        public static Dictionary<int, Dictionary<string, string>> LookAll() => DBAdapter.GetAll("Tows");

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
}

