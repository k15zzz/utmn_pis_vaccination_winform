using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS_WinForm
{
    static class DBAdapter
    {
        private static Dictionary<string, Dictionary<int, Dictionary<string, string>>> _db =
            new Dictionary<string, Dictionary<int, Dictionary<string, string>>>()
            {

#region role
                {
                    "role", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        {1, new Dictionary<string, string>(){{ "name", "Куратор ВетСлужбы"}}},
                        {2, new Dictionary<string, string>(){{ "name", "Куратор по отлову"}}},
                        {3, new Dictionary<string, string>(){{ "name", "Куратор приюта"}}},
                        {4, new Dictionary<string, string>(){{ "name", "Оператор ВетСлужбы"}}},
                        {5, new Dictionary<string, string>(){{ "name", "Оператор по Отлову"}}},
                        {6, new Dictionary<string, string>(){{ "name", "Подписант ВетСлужбы"}}},
                        {7, new Dictionary<string, string>(){{ "name", "Подписант по отлову"}}},
                        {8, new Dictionary<string, string>(){{ "name", "Подписант приюта"}}},
                        {9, new Dictionary<string, string>(){{ "name", "Куратор ОМСУ"}}},
                        {10, new Dictionary<string, string>(){{ "name", "Оператор ОМСУ"}}},
                        {11, new Dictionary<string, string>(){{ "name", "Подписант ОМСУ"}}},
                        {12, new Dictionary<string, string>(){{ "name", "Оператор приюта"}}},
                        {13, new Dictionary<string, string>(){{ "name", "filter"}}},
                        {14, new Dictionary<string, string>(){{ "name", "Ветврач приюта"}}},
                    }
                },
#endregion
#region user
                {
                    "user", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        { 
                            1, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "login",      "boss" }, // {colum, value} 
                                { "password",   "p4ssw0rd" },
                                { "role",       "6" },
                                { "town",       "2" },
                            }
                        }
                    }
                },
#endregion
#region animals
                {
                    "Animals", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        {
                            1, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "regNum",      "123-123" }, // {colum, value} 
                                { "town_id",   "1" },
                                { "сategory",   "Кошка" },
                                { "sex",   "сука" },
                                { "burthYear",      "2005" },
                                { "e-chipNumber",   "7423423" },
                                { "name",   "Варя" },
                                { "photos",   "на фотках кошка" },
                                { "specMarcks", "черная, красивая, отсутцвует хвост"}
                            }
                        },
                        {
                            2, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "regNum",      "345-234" }, // {colum, value} 
                                { "town_id",   "1" },
                                { "сategory",   "Кошка" },
                                { "sex",   "муж." },
                                { "burthYear",      "2004" },
                                { "e-chipNumber",   "74234423" },
                                { "name",   "Падик" },
                                { "photos",   "на фотках собака" },
                                { "specMarcks", "серая, красивая, отсутцвует нос"}
                            }
                        },
                        {
                            3, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "regNum",      "123-456" }, // {colum, value} 
                                { "town_id",   "2" },
                                { "сategory",   "Собака" },
                                { "sex",   "муж." },
                                { "burthYear",      "2000" },
                                { "e-chipNumber",   "2342387" },
                                { "name",   "Аба" },
                                { "photos",   "на фотках собака, красивая" },
                                { "specMarcks", "рыжая, красивая, отсутцвует нос и хвост"}
                            }
                        }
                    }
                },
                #endregion
#region organisations
                {
                    "Organizations", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        {
                            1, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "fullName",      "ООО Аргон и сварка" }, // {colum, value} 
                                { "INN",   "2353645786" },
                                { "KPP",   "45676543" },
                                { "aderss",   "ул. Ппрокопия. д. 2" },
                                { "type",      "Приют" },
                                { "UrFace",   "Андрей Юрий Андреич" },
                                { "town_id",   "1" },
                            }
                        },
                        {
                            2, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "fullName",      "ООО Клеточный кот" }, // {colum, value} 
                                { "INN",   "45342342" },
                                { "KPP",   "423609813" },
                                { "aderss",   "ул. Ппрокопия. д. 1" },
                                { "type",      "Приют" },
                                { "UrFace",   "Андрей Юрий Андреич" },
                                { "town_id",   "1" },
                            }
                        },
                    }
                },
                #endregion
#region contracts
                {
                    "Contracts", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        {
                            1, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "number",      "1" }, // {colum, value} 
                                { "startDate",   "12.02.2002" },
                                { "endDate",   "13.02.2002" },
                                { "ispolnitel_id",   "1" },
                                { "zacazchik_id",      "2" }
                            }
                        }
                    }
                },
#endregion
#region Towns
                {
                    "Tows", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        {
                            1, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "name",      "Залупенск" }, // {colum, value} 
                            }
                        },
                        {
                            2, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "name",      "Новосибирск" }, // {colum, value} 
                            }
                        },
                    }
                },
#endregion
#region TownsServises
                {
                    "TownsServises", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        {
                            1, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "town_id",      "1" }, // {colum, value} 
                                { "servise",   "Вакцинация" },
                                { "price",   "100" },
                            }
                        },
                        {
                            2, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "town_id",      "2" }, // {colum, value} 
                                { "servise",   "Вакцинация" },
                                { "price",   "72" },
                            }
                        },
                    }
                },
#endregion
#region vactination
                {
                    "vactination", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        {
                            1, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "type",      "бешенство" }, // {colum, value} 
                                { "date",   "12.02.2002" },
                                { "numerOfSeries",   "434234234" },
                                { "dateOfExpire",   "12.03.2002" },
                                { "doljnostOfDoc",   "Вет-врач-инъекционист" },
                                { "org_id",   "1" },
                                { "contract_id",   "1" }
                            }
                        }
                    }
                },
#endregion
            };

        static public Dictionary<int, Dictionary<string, string>> GetAll(string table) => _db[table];

        static public Dictionary<string, string> SearchUser(string login, string password) 
        {
            var users = _db["user"];

            foreach (var user in users)
            {
                if (user.Value["login"] == login && user.Value["password"] == password)
                {
                    return new Dictionary<string, string>() 
                    { 
                        { "role",  user.Value["role"]},
                        { "town",   user.Value["town"]}
                    };
                }
            }

            throw new Exception("Пользователь не найден!");
        }
    }
}
