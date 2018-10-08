using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.HR
{
    abstract class PermanentEmployee : Employee
    {
        public double BaseSalary { get; set; }

        public PermanentEmployee(Common.Gender gender)
            : base(gender)
        {
        }

        public PermanentEmployee(Common.Gender gender, byte Age)
            : base(gender, Age)
        {
        }

        public override double Salary
        {
            get { return this.BaseSalary; }
        }
    }
}
