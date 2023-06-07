using PIS_WinForm;
{
    public static class Animal
    {
        private static readonly string _tableName = "Animals";
        public static Dictionary<int, Dictionary<string, string>> LookAll(Dictionary<string, List<string>> filter)
        {
            try
            {
                PermissionGuard.CanLookAll(_tableName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            var cleanedFilters = new Dictionary<string, List<string>>();

            foreach (var fString in filter)
                if (fString.Value[0] != null) cleanedFilters.Add(fString.Key, fString.Value);


            return DBAdapter.LookAll(_tableName,
                cleanedFilters,
                ReplaceFields);
        }
        private static Dictionary<int, Dictionary<string, string>> ReplaceFields(Dictionary<int, Dictionary<string, string>> filteredtable, Dictionary<string, Dictionary<int, Dictionary<string, string>>> db)
        {
            foreach(var item in filteredtable)
                item.Value["town_id"] = db["Tows"][int.Parse(item.Value["town_id"])]["name"];

            return filteredtable;
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
