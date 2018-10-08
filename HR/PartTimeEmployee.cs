using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetStartWithOOP.Common;

namespace GetStartWithOOP.HR
{
    sealed class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public double WorkingHours { get; set; }
        public override double Salary { get { return this.HourlyRate * this.WorkingHours; } }

        public PartTimeEmployee() : this(Gender.Male)
        {
        }

        public PartTimeEmployee(Gender gender)
            : base(gender)
        {
        }

        public PartTimeEmployee(Gender gender, byte Age) : base(gender, Age)
        {
        }

        // override keyword use to implement new version logic
        public override string GetInfo()
        {
            var sb = new StringBuilder(base.GetInfo());
            sb.AppendLine();
            sb.AppendFormat("\tTotal parttime salary is {0} and had work {2}",
                this.Salary, this.HourlyRate, this.WorkingHours);

            return sb.ToString();
        }

        public override bool Interview()
        {
            return true;
        }
    }
}
