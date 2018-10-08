using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetStartWithOOP.Common;

namespace GetStartWithOOP.HR.OldSchool
{
    class PartTimeEmployee
    {
        public int ID { get; private set; }
        public string Firstname { get; set; }
        public string Lasrname { get; set; }
        public Gender Sex { get; private set; }

        public double HourlyRate { get; set; }
        public double WorkingHours { get; set; }
        public double Salary { get { return this.HourlyRate * this.WorkingHours; } }

        public void Employ()
        {
        }
    }
}
