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
                                { "password",   "p4ssw0rd" },
                                { "password",   "p4ssw0rd" }
                            } 
                        }
                    }
                }
            };

        //var item = db["table"][1]["atribute"]; // 1 - это id записи

        static public void SearchUser(string login, string password) 
        {
            var users = _db["user"];

            foreach (var user in users)
            {
                if (user.Value["login"] == login && user.Value["password"] == login)
                {

                }
            }
        }
    }
}
