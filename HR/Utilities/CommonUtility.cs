using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.HR.Utilites
{
    static class CommonUtility
    {
        public static string GetFullname(HR.Employee e, bool FnThenLN = true)
        {
            var order = FnThenLN ? "{0} {1}" : "{1} {0}";
            return String.Format(order, e.Firstname, e.Lastname);
        }
    }
}
