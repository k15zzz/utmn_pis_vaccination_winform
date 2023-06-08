namespace Card
{
    public class Animal
    {
        internal string category;
        internal string sex;
        internal string regNum;
        internal string burthYear;
        internal string town_id;
        internal string name;
        internal string chipNumber;
        internal string photos;
        internal string specMarcks;
        public Animal(Dictionary<string, string> filter)
        {
            regNum = filter["regNum"];
            category = filter["category"];
            sex = filter["sex"];
            burthYear = filter["burthYear"];
            town_id = filter["town_id"];
            name = filter["name"];
            chipNumber = filter["e-chipNumber"];
            specMarcks = filter["specMarcks"];
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
