using Model;

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
