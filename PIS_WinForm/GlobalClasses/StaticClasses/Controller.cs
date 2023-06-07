using PIS_WinForm.Forms;
using PIS_WinForm;

namespace Controller
{
    public static class Animal
    {
        public static void LookAll(Dictionary<string, List<string>> filter)
        {
            Dictionary<int, Dictionary<string, string>> cards;
            try
            {
                cards = Model.Animal.LookAll(filter);
            }
            
            catch (Exception ex)
            {
                throw ex;
            }

            AnimalListForm _form = new AnimalListForm(cards);
            _form.ShowDialog();
        }

        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

       //public static void Add(string[,] filter, string[,] sort) => Model.Animal.Add(animal);

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

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Organization
    {
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
}
