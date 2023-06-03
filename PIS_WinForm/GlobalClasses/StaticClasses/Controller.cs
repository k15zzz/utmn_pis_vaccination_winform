using PIS_WinForm.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        public static void Add(Card.Animal animal)
        {
            Model.Animal.Add(animal);
        }

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Contract
    {
        public static void LookAll(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }

    public static class Organization
    {
        public static void LookAll(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Edit(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        private static bool ChechOnEmptyFields() => throw new NotImplementedException();
    }
}
