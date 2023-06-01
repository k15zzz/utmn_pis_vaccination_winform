using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS_WinForm
{
    public static class PermissionGuard
    {

        public static bool CanLookAll(string table) => throw new NotImplementedException();

        public static bool CanAdd(string table) => throw new NotImplementedException();

        public static bool CanEdit(string table) => throw new NotImplementedException();

        public static string GetTown(string table) => throw new NotImplementedException();

        public static void ValidateUser(string login, string password)
        {
            DBAdapter.SearchUser(login, password);
        }
    }
}
