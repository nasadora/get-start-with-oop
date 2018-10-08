using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetStartWithOOP.Common;

namespace GetStartWithOOP.HR.OldSchool
{
    class Employee
    {
        public int ID { get; private set; }
        public string Firstname { get; set; }
        public string Lasrname { get; set; }
        public Gender Gender { get; private set; }

        public void Employ()
        {
        }
    }
}
