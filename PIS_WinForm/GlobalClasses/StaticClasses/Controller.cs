
﻿using PIS_WinForm.Forms;
using PIS_WinForm;



namespace Controller
{
    public static class Animal
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

        public static void Edit(string[,] filter, string[,] sort) => throw new NotImplementedException();

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


        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

       //public static void Add(string[,] filter, string[,] sort) => Model.Animal.Add(animal);

        public static void Delete(int id)
        {
            var dict = DBAdapter.GetAll("Animals" );
            if (dict.ContainsKey(id))
            {
                dict.Remove(id);
            }
            else
            {
                MessageBox.Show("Такого животного не существует в реестре");
            }

        }

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
}
