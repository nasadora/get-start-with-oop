using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.HR
{
    class ContractEmployee : Employee, Common.IContractable
    {
        public string ContractDocumentCode { get; set; }
        public double ContractSalary { get; set; }

        public ContractEmployee()
            : this(Common.Gender.Male)
        {
        }

        public ContractEmployee(Common.Gender gender)
            : base(gender)
        {
        }

        public ContractEmployee(Common.Gender gender, byte Age)
            : base(gender, Age)
        {
        }

        public override double Salary
        {
            get { return this.ContractSalary; }
        }

        public override bool Interview()
        {
            return true;
        }

        string Common.IContractable.GetContractNumber()
        {
            return this.ContractDocumentCode;
        }

        bool Common.IContractable.IsValid()
        {
            return (this.ContractDocumentCode != String.Empty);
        }
    }
}
