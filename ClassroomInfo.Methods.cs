using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.Common
{
    partial class ClassroomInfo
    {
        public string GetInfo()
        {
            return String.Format("Classroom with name {0}", this.Roomname);
        }
    }
}
