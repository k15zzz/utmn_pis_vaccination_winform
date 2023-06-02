using PIS_WinForm;
{
    public static class Animal
    {
        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, string> filter, Dictionary<string, string> sort)
        {
            try
            {
                PermissionGuard.CanLookAll("Animals");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DBAdapter.LookAll("Animals", filter);
        }


        public static void Add(Card.Animal animal)
        {
            
        }
    }

    public static class Organizations
    {

        public static void LookAll(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();
    }

    public static class Contracts
    {
        public static void LookAll(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

        public static void Add(Dictionary<string, string> filter, Dictionary<string, string> sort) => throw new NotImplementedException();

    }
}
