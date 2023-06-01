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
                    "Куратор ВетСлужбы", 
                    new Dictionary<string, string>() 
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Просмотр" },
                        { "МунКонтрактов",  "Просмотр" }
                    } 
                },
                {
                    "Куратор по отлову",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Просмотр" },
                        { "МунКонтрактов",  "Просмотр" }
                    }
                },
                {
                    "Куратор приюта",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Просмотр" },
                        { "МунКонтрактов",  "Просмотр" }
                    }
                },
                {
                    "Оператор ВетСлужбы",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Введение" },
                        { "МунКонтрактов",  "Просмотр" }
                    }
                },
                {
                    "Оператор по Отлову",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Нет доступа" },
                        { "МунКонтрактов",  "Нет доступа" }
                    }
                },
                {
                    "Подписант ВетСлужбы",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Просмотр" },
                        { "МунКонтрактов",  "Просмотр" }
                    }
                },
                {
                    "Подписант по отлову",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Просмотр" },
                        { "МунКонтрактов",  "Просмотр" }
                    }
                },
                {
                    "Подписант приюта",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Просмотр" },
                        { "МунКонтрактов",  "Просмотр" }
                    }
                },
                {
                    "Куратор ОМСУ",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Просмотр" },
                        { "МунКонтрактов",  "Просмотр" }
                    }
                },
                {
                    "Оператор ОМСУ",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Введение" },
                        { "МунКонтрактов",  "Введение" }
                    }
                },
                {
                    "Подписант ОМСУ",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Просмотр" },
                        { "Организаций",    "Просмотр" },
                        { "МунКонтрактов",  "Просмотр" }
                    }
                },
                {
                    "Оператор приюта",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Введение" },
                        { "Организаций",    "Нет доступа" },
                        { "МунКонтрактов",  "Нет доступа" }
                    }
                },
                {
                    "filter",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Введение" },
                        { "Организаций",    "Нет доступа" },
                        { "МунКонтрактов",  "Нет доступа" }
                    }
                },
                {
                    "Ветврач приюта",
                    new Dictionary<string, string>()
                    {
                        { "Животных",       "Введение" },
                        { "Организаций",    "Нет доступа" },
                        { "МунКонтрактов",  "Нет доступа" }
                    }
                }
        };

        public static void SetGroup(string group) => _group = group;

        public static void SetTown(string town) => _town = town;

        public static bool CanLookAll(string nameReestr) => GetPermissionVisable(nameReestr);

        public static bool CanAdd(string nameReestr) => GetPermissionAction(nameReestr);

        public static bool CanEdit(string nameReestr) => GetPermissionAction(nameReestr);

        public static bool CanDelete(string nameReestr) => GetPermissionAction(nameReestr);

        public static string GetTown() => _town;

        public static void ValidateUser(string login, string password) => DBAdapter.SearchUser(login, password);

        private static bool GetPermissionAction(string nameReestr) => GetPermission(nameReestr) == "Введение";

        private static bool GetPermissionVisable(string nameReestr) => GetPermission(nameReestr) == "Просмотр";

        private static string GetPermission(string nameReestr) => _permissions[_group][nameReestr];
    }
}
