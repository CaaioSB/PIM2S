using Etherchain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Desktop
{
    class AppDesktop
    {
        private static Employee _actualEmployee;

        internal static Employee ActualEmployee { get => _actualEmployee; set => _actualEmployee = value; }

        internal static void startup()
        {
            App.DatabaseSql.ExceptionCall = (Exception ex, string detail) =>
            {
                Console.WriteLine(detail);
                throw ex;
            };
        }
    }
}
