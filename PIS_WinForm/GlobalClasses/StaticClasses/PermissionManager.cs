using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PIS_WinForm
{
    class PermissionManager
    {
        public static void ValidateUser(string login, string password)
        {
            DBAdapter.SearchUser(login, password);
        }
    }
}
