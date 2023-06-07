using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS_WinForm
{
    public static class PermissionGuard
    {
        private static string _group;
        private static string _town = null;

        private static Dictionary<string, Dictionary<string, string>> _permissions = 
            new Dictionary<string, Dictionary<string, string>>()
        {
                { 
                    "1", 
                    new Dictionary<string, string>() 
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Просмотр" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    } 
                },
                {
                    "2",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Просмотр" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "3",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Просмотр" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "4",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Введение" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "5",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Нет доступа" },
                        { "Contracts",  "Нет доступа" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "6",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Просмотр" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "7",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Просмотр" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "8",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Просмотр" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "9",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Просмотр" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "1" },
                        { "statusTown",     "1"}
                    }
                },
                {
                    "10",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Введение" },
                        { "Contracts",  "Введение" },
                        { "Статистика",     "1"},
                        { "statusTown",     "1"}
                    }
                },
                {
                    "11",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Просмотр" },
                        { "Organizations",    "Просмотр" },
                        { "Contracts",  "Просмотр" },
                        { "Статистика",     "1" },
                        { "statusTown",     "1"}
                    }
                },
                {
                    "12",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Введение" },
                        { "Organizations",    "Нет доступа" },
                        { "Contracts",  "Нет доступа" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "13",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Введение" },
                        { "Organizations",    "Нет доступа" },
                        { "Contracts",  "Нет доступа" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },
                {
                    "14",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Введение" },
                        { "Organizations",    "Нет доступа" },
                        { "Contracts",  "Нет доступа" },
                        { "Статистика",     "0" },
                        { "statusTown",     "0"}
                    }
                },


                {
                    "99",
                    new Dictionary<string, string>()
                    {
                        { "Animals",       "Введение" },
                        { "Organizations",    "Введение" },
                        { "Contracts",  "Введение" },
                        { "Статистика",     "1" },
                        { "statusTown",     "0"}
                    }
                }
        };

        public static void ValidateUser(string login, string password) 
        { 
            try
            {
                var infoUser = DBAdapter.SearchUser(login, password);

                _group = infoUser["role"];
                _town = GetPermission("statusTown") == "1" ? infoUser["town"] : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        public static string GetTown() => _town;

        public static bool CanLookAll(string nameReestr) => GetPermissionVisable(nameReestr);

        public static bool CanAdd(string nameReestr) => GetPermissionAction(nameReestr);

        public static bool CanEdit(string nameReestr) => GetPermissionAction(nameReestr);

        public static bool CanDelete(string nameReestr) => GetPermissionAction(nameReestr);

        public static bool CanStatistic() => GetPermission("Статистика") == "1";

        private static bool GetPermissionAction(string nameReestr) => GetPermission(nameReestr) == "Введение";

        private static bool GetPermissionVisable(string nameReestr) => GetPermission(nameReestr) == "Просмотр";

        private static string GetPermission(string nameReestr) => _permissions[_group][nameReestr];
    }
}
