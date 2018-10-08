using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.HR
{
    class ForentPEmployee : PermanentEmployee, Common.IContractable
    {
        public string ContractReferenceCode { get; set; }
        public string PassportNumber { get; set; }

        public ForentPEmployee()
            : this(Common.Gender.Male)
        {
        }

        public ForentPEmployee(Common.Gender gender)
            : base(gender)
        {
        }

        public ForentPEmployee(Common.Gender gender, byte Age)
            : base(gender, Age)
        {
        }

        // override keyword use to implement new version logic
        public override string GetInfo()
        {
            var sb = new StringBuilder(base.GetInfo());
            sb.AppendLine();
            sb.AppendFormat("\tIs a Forent staff with salary of {0}.",
                this.Salary);
            sb.AppendLine();
            sb.AppendFormat("\tPassport number is {0} with contract {1}.",
                this.PassportNumber, this.ContractReferenceCode);

            return sb.ToString();
        }

        public sealed override bool Interview()
        {
            return true;
        }

        public string GetContractNumber()
        {
            return this.ContractReferenceCode;
        }

        public bool IsValid()
        {
            return (this.ContractReferenceCode != String.Empty);
        }
    }
}
