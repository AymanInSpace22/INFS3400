using System;
using System.Collections.Generic;
using System.Text;

namespace Base_Abstract_Interfaces_Extension
{

    // this is an example of interfaces
    // project - add item - interface
    // you put it next to the inherited class as you see below
    // then you can create method for it

    class PartTimeEmployee : Employee, IClockin, IClockOut
    {
        // fields unique to part time
        private double hourlyRate;

        // property for the field
        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }


        // these are the interface methods
        public void ClockIn()
        {
            Console.WriteLine("Thank you for clocking in");
        }

        public void ClockOut()
        {
            Console.WriteLine("Thank you for clocking out");
        }
    }
}
