using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetStartWithOOP.Common;

namespace GetStartWithOOP.HR
{
    abstract class Employee
    {
        public int EmployeeID { get; private set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private readonly Gender gender;
        public Gender Gender { get { return this.gender; } }
        public byte Age { get; protected set; }

        //public Employee()
        //{
        //}

        public Employee(Gender gender)
        {
            this.gender = gender;
        }

        public Employee(Gender gender, byte Age)
        {
            this.gender = gender;
            this.Age = Age;
        }

        public void Employ()
        {
            if (this.Interview())
            {
                this.EmployeeID = KeyGenerator.GetNextEmplyeeID();
            }
        }

        // abstract keyword able overriding and start as draft version by preserved the API defination
        // Abstract property
        public abstract double Salary { get; }
        // Abstract method
        public abstract bool Interview();

        // virtual keyword able overriding and start as version 1
        public virtual string GetInfo()
        {
            return String.Format("Employee [{3:00000}] {0} {1} is {2}", 
                this.Firstname, this.Lastname, this.Gender, this.EmployeeID);
        }

        public sealed override string ToString()
        {
            return this.GetInfo();
        }
    }
}
