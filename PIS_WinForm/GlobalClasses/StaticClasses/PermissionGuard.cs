using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS_WinForm.GlobalClasses.StaticClasses
{
    public static class PermissionGuard
    {

        public static bool CanLookAll() => throw new NotImplementedException();

        public static bool CanAdd() => throw new NotImplementedException();

        public static bool CanEdit() => throw new NotImplementedException();

        public static string GetTown() => throw new NotImplementedException();

        public static void ValidateUser(string login, string password)
        {
            DBAdapter.SearchUser(login, password);
        }
    }
}
