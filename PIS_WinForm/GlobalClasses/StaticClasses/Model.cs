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

            if (filter["town_id"][0] == null) filter.Remove("town_id");

            return DBAdapter.LookAll(_tableName,
                filter,
                ReplaceFields);
        }


        public static void Add(Card.Animal animal)
        {
            
        }

        private static Dictionary<int, Dictionary<string, string>> ReplaceFields(Dictionary<int, Dictionary<string, string>> filteredtable, Dictionary<string, Dictionary<int, Dictionary<string, string>>> db)
        {
            for (var i = 1; i<= filteredtable.Count; i++)
            {
                filteredtable[i]["town_id"] = db["Tows"][int.Parse(filteredtable[i]["town_id"])]["name"];
            }
            return filteredtable;
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
