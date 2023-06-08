using System.Diagnostics;

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
        internal string number;
        internal string startDate;
        internal string endDate;
        internal string ispolnitel_id;
        internal string zacazchik_id;
        public Contract(Dictionary<string, string> filter)
        {
            number = filter["number"];
            startDate = filter["startDate"];
            endDate = filter["endDate"];
            ispolnitel_id = filter["ispolnitel_id"];
            zacazchik_id = filter["zacazchik_id"];
        }
    }

    public class Organization
    {
        internal string fullName;
        internal string INN;
        internal string KPP;
        internal string aderss;
        internal string type;
        internal string UrFace;
        internal string town_id;
        public Organization(Dictionary<string, string> filter)
        {
            fullName = filter["fullName"];
            INN = filter["INN"];
            KPP = filter["KPP"];
            aderss = filter["aderss"];
            type = filter["type"];
            UrFace = filter["UrFace"];
            town_id = filter["town_id"];
        }
    }

    public class User
    {
        // овер дохера полей
        public User() => throw new NotImplementedException();
    }
}
