namespace Card
{
    public class Animal
    {

        private string category;
        private string gender;
        private string yearBirth;
        private string town;
        private string name;
        private string chip;
        private string signs;
        public Animal(Dictionary<string, string> filter)
        {
            category = filter["category"];
            gender = filter["gender"];
            yearBirth = filter["yearBirth"];
            town = filter["town"];
            name = filter["name"];
            chip = filter["chip"];
            signs = filter["signs"];
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
