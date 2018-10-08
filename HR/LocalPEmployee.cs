using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.HR
{
    class LocalPEmployee : PermanentEmployee
    {
        public double Allowance { get; set; }
        public string IDNumber { get; set; }

        public LocalPEmployee()
            : this(Common.Gender.Male)
        {
        }

        public LocalPEmployee(Common.Gender gender)
            : base(gender)
        {
        }

        public LocalPEmployee(Common.Gender gender, byte Age)
            : base(gender, Age)
        {
        }

        // override keyword use to implement new version logic
        public override string GetInfo()
        {
            var sb = new StringBuilder(base.GetInfo());
            sb.AppendLine();
            sb.AppendFormat("\tIs a Local staff with salary of {0}.",
                this.Salary);
            sb.AppendLine();
            sb.AppendFormat("\tIdentity card number is {0}.",
                this.IDNumber);

            return sb.ToString();
        }

        public override double Salary
        {
            get { return this.BaseSalary + this.Allowance; }
        }

        public override bool Interview()
        {
            return true;
        }
    }
}
