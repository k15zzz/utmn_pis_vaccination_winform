namespace Card
{
    public class Animal
    {
        //burthYear, town_id,regNum, chipNumber, name, photos, specMarcks
        internal string category { get; }
        internal string sex { get; }
        internal string regNum { get; }
        internal string burthYear { get; }
        internal string town_id { get; }
        internal string name { get; }
        internal string chipNumber { get; }
        internal string photos { get; }
        internal string specMarcks { get; }
        public Animal(Dictionary<string, string> filter)
        {
            // нет пункта на форме
            regNum = filter["regNum"];
            category = filter["category"];
            sex = filter["gender"];
            burthYear = filter["yearBirth"];
            town_id = filter["town"];
            name = filter["name"];
            chipNumber = filter["chip"];
            specMarcks = filter["signs"];
            photos = filter["photos"];
        }
    }

    public class Contract
    {
        // овер дохера полей
        public Contract() => throw new NotImplementedException();
    }

    public class Organization
    {
        // овер дохера полей
        public Organization() => throw new NotImplementedException();
    }

    public class User
    {
        // овер дохера полей
        public User() => throw new NotImplementedException();
    }
}
