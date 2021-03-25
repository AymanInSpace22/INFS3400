using System;
using System.Collections.Generic;
using System.Text;

namespace Base_Abstract_Interfaces_Extension
{

    // by putting public it will enable you to use this class as a library to use in other projects
    public abstract class Employee
    {
        // fields
        private string name;
        private int idNumber;

        public string Name
        {
            // returns the name field
            get { return name; }
            // sets the name field
            set { name = value; }
        }
        
        public int IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        // constructor
        public Employee(string name, int idNumber)
        {
            this.Name = name;
            this.IdNumber = idNumber;
        }

        public Employee()
        {

        }


        // ToString Method
        public override string ToString()
        {
            return Name + " has an id number of " + IdNumber;
            // another way of doing the above return
            // return String.Format("{0} has an id number of {1} ", Name, IdNumber);
        }

    }
}
