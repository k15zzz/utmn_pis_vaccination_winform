namespace Card
{
    public class Animal
    {
        //burthYear, town_id,regNum, chipNumber, name, photos, specMarcks
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
