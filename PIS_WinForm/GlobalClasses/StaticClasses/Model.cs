using PIS_WinForm;

namespace Model
{
    public static class Animal
    {
        public static void LookAll(string[,] filter, string[,] sort) => throw new NotImplementedException();

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
        private static List<string> category = new List<string>() { "Кошка", "Собака"};
        private static List<string> sex = new List<string>() { "муж", "жен" };
        //private static Dictionary<string, List<string>> fields =
        //    new Dictionary<string, List<string>>()
        //    {
        //        {"category", new List<string>() {"Кошка", "Собака"} },
        //        {"sex", new List<string>() {"муж.", "жен."} }
        //        //burthYear, town_id,regNum, e-chipNumber, name, photos, specMarcks
        //    };
        private static bool ChechOnEmptyFields(Card.Animal animal)
        {
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
}
