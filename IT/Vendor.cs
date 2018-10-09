using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.IT
{
    class Vendor : Common.IContractable
    {
        public int VendorID { get; private set; }
        public string Name { get; set; }
        internal string VendorContractCode { get; set; }

        string Common.IContractable.GetContractNumber()
        {
            return this.VendorContractCode;
        }

        bool Common.IContractable.IsValid()
        {
            return (this.VendorContractCode != String.Empty);
        }
    }
}
