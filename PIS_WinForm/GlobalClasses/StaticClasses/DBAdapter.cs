﻿using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace PIS_WinForm
{
    public static class DBAdapter
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
                                { "role",   "6" },
                                { "organization_id", "1"}
                            }
                        },
                        {
                            2, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "login",      "master" }, // {colum, value} 
                                { "password",   "master" },
                                { "role",       "99" },
                                { "organization_id", "1"}
                            }
                        },
                        {
                            3, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "login",      "towntest" }, // {colum, value} 
                                { "password",   "1" },
                                { "role",       "9" },
                                { "organization_id", "1"}
                            }
                        },
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
                                { "sex",   "жен." },
                                { "burthYear",      "2005" },
                                { "e-chipNumber",   "7423423" },
                                { "name",   "Варя" },
                                { "photos",   "на фотках кошка" },
                                { "specMarcks", "черная, красивая, отсутствует хвост"}
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
                                { "photos",   "на фотках кошка" },
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
                                { "specMarcks", "рыжая, красивая, отсутствует нос и хвост"}
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
                                { "aderss",   "ул. Прокопия. д. 2" },
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
                                { "aderss",   "ул. Прокопия. д. 1" },
                                { "type",      "Приют" },
                                { "UrFace",   "Андрей Юрий Андреич" },
                                { "town_id",   "2" },
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
                                { "name",      "Тюмень" }, // {colum, value} 
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
                    "Vactination", // table
                    new Dictionary<int, Dictionary<string,string>>()
                    {
                        {
                            1, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "type",      "бешенство" }, // {colum, value} 
                                { "date",       "12.02.2002" },
                                { "numerOfSeries",   "434234234" },
                                { "dateOfExpire",   "12.03.2015" },
                                { "doljnostOfDoc",   "Вет-врач-инъекционист" },
                                { "org_id",   "2" },
                                { "contract_id",   "1" }
                            }
                        },
                        {
                            2, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "type",      "бешенство" }, // {colum, value} 
                                { "date",       "12.02.2023" },
                                { "numerOfSeries",   "434234234" },
                                { "dateOfExpire",   "12.03.2000" },
                                { "doljnostOfDoc",   "Вет-врач-инъекционист" },
                                { "org_id",   "1" },
                                { "contract_id",   "1" }
                            }
                        },
                        {
                            3, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "type",      "бешенство" }, // {colum, value} 
                                { "date",       "12.02.2002" },
                                { "numerOfSeries",   "434234234" },
                                { "dateOfExpire",   "12.03.2022" },
                                { "doljnostOfDoc",   "Вет-врач-инъекционист" },
                                { "org_id",   "2" },
                                { "contract_id",   "1" }
                            }
                        },
                        {
                            4, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "type",      "бешенство" }, // {colum, value} 
                                { "date",       "12.02.2010" },
                                { "numerOfSeries",   "434234234" },
                                { "dateOfExpire",   "12.03.2012" },
                                { "doljnostOfDoc",   "Вет-врач-инъекционист" },
                                { "org_id",   "2" },
                                { "contract_id",   "1" }
                            }
                        },
                        {
                            5, // id 
                            new Dictionary<string, string>()  // atributes
                            {
                                { "type",      "бешенство" }, // {colum, value} 
                                { "date",       "12.02.2002" },
                                { "numerOfSeries",   "434234234" },
                                { "dateOfExpire",   "12.03.2014" },
                                { "doljnostOfDoc",   "Вет-врач-инъекционист" },
                                { "org_id",   "1" },
                                { "contract_id",   "1" }
                            }
                        }
                    }
                },
#endregion
            };

        //var item = db["table"][1]["atribute"]; // 1 - это id записи
        static public int NewIdAnimal()
        {
            var animals = _db["Animals"];

            int id = 1;
            for (int i = 1; i < animals.Count + 1; i++)
            {
                if (animals.ContainsKey(i))
                {
                    id += 1;
                }
            }
            return id;
        }

        static public bool EditAnimal(Card.Animal animal)
        {
            var id = animal.id;
            Dictionary<string, string> card = new Dictionary<string, string>()
            {
                { "regNum",  animal.regNum }, // {colum, value} 
                { "town_id",   animal.town_id },
                { "сategory",  animal.category },
                { "sex",  animal.sex },
                { "burthYear",   animal.burthYear },
                { "e-chipNumber",   animal.chipNumber },
                { "name", animal.name },
                { "photos",  animal.photos },
                { "specMarcks", animal.specMarcks}
            };
            _db["Animals"][id]= card;
            return true;
        }

        static public bool AddAnimal(Card.Animal animal)
        {
            var id = animal.id;
            Dictionary<string, string> card = new Dictionary<string, string>()
            {
                { "regNum",  animal.regNum }, // {colum, value} 
                { "town_id",   animal.town_id },
                { "сategory",  animal.category },
                { "sex",  animal.sex },
                { "burthYear",   animal.burthYear },
                { "e-chipNumber",   animal.chipNumber },
                { "name", animal.name },
                { "photos",  animal.photos },
                { "specMarcks", animal.specMarcks}
            };
            _db["Animals"].Add(id, card);
            return true;
        }

        static public Dictionary<int, Dictionary<string, string>> GetAll(string table) => _db[table];
        
        static public Dictionary<int, Dictionary<string, string>> LookAll(
            string table,
            Dictionary<string, List<string>> filter,
            Func<Dictionary<int, Dictionary<string, string>>, Dictionary<string, Dictionary<int, Dictionary<string, string>>>, Dictionary<int, Dictionary<string, string>>> changeIdOnName)
        {
            var returnableList = new Dictionary<int, Dictionary<string, string>>();
            var fullTable = _db[table];

            if (filter.Count == 0) return changeIdOnName(fullTable, _db);

            foreach (var item in fullTable)
                foreach (var filterPoint in filter)
                    foreach (var value in filterPoint.Value)
                        if (!returnableList.ContainsKey(item.Key) && item.Value[filterPoint.Key] == value)
                            returnableList.Add(item.Key, new Dictionary<string, string>(fullTable[item.Key]));

            return changeIdOnName(returnableList, _db);           
        }

        static public Dictionary<int, Dictionary<string, string>> GetDateStatistic(DateTime dateStart, DateTime dateFinish, List<int> town)
        {
            var _vactination = GetAll("Vactination");
            var vactination = new Dictionary<int, Dictionary<string, string>>();
            var result = new Dictionary<int, Dictionary<string, string>>();


            foreach (var item in _vactination)
            {
                var date = DateTime.Parse(item.Value["date"]);

                if (dateStart <= date && date <= dateFinish)
                    vactination.Add(item.Key, item.Value);
            }

            var organizations = GetAll("Organizations");
            var touwns = GetAll("Tows");
            var townService = GetAll("TownsServises");


            foreach (var item in vactination)
            {
                var idOrg = int.Parse(item.Value["org_id"]);

                var idTown = int.Parse(organizations[idOrg]["town_id"]);

                if (town.Contains(idTown))
                {
                    var nameTown = touwns[idTown]["name"];
                    var priceTown = townService[idTown]["price"];

                    result.Add(item.Key, item.Value);

                    result[item.Key]["town_name"] = nameTown;
                    result[item.Key]["town_id"] = idTown.ToString();
                    result[item.Key]["price"] = priceTown;
                }
            }

            return result;
        }

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
                        { "town",   _db["Organizations"][int.Parse(user.Value["organization_id"])]["town_id"]}
                    };
                 }
            }
            throw new Exception("Пользователь не найден!");
        }

        static public void Delete(int id, string table)
        {
            _db[table].Remove(id);
            if (table == "Contracts")
            {
               foreach(var row in _db["Vactination"])
                {
                    if (_db["Vactination"][row.Key]["contract_id"] == id.ToString())
                        _db["Vactination"].Remove(row.Key);
                }
            }
            else if (table == "Organizations")
            {
                foreach (var row in _db["Vactination"])
                {
                    if (_db["Vactination"][row.Key]["org_id"] == id.ToString())
                        _db["Vactination"].Remove(row.Key);
                }
            }
        }
    }
}
