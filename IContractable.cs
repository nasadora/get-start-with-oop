using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.Common
{
    interface IContractable
    {
        String GetContractNumber();
        bool IsValid();
    }
}
