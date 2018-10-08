using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.Common
{
    static class KeyGenerator
    {
        static KeyGenerator()
        {
            NEXT_EMPLOYEE_ID = 10;
        }

        private static int NEXT_EMPLOYEE_ID /* = 1 */;
        public static int GetNextEmplyeeID()
        {
            return NEXT_EMPLOYEE_ID++;
        }
    }
}
