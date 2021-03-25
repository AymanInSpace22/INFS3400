using System;
using System.Collections.Generic;
using System.Text;

namespace Base_Abstract_Interfaces_Extension
{
    class FullTimeEmployee : Employee
    {
        // fields
        private double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        // constructor
        public FullTimeEmployee(string name, int idNumber, double salary) : base(name, idNumber)
        {
            this.Salary = salary;
        }


        public override string ToString()
        {
            return string.Format(base.ToString() + " this employee is a " +
                "full time employee and has a salary of {0} ", Salary.ToString("C"));
        }
    }
}
