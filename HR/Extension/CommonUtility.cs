using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.HR.Extension
{
    static class CommonUtility
    {
        // implement extension method
        public static string GetFullname(this HR.Employee e, bool FnThenLN = true)
        {
            var order = FnThenLN ? "{0} {1}" : "{1} {0}";
            return String.Format(order, e.Firstname, e.Lastname);
        }
    }
}
