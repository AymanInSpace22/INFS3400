using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Job
    {
        // fields
        private string description;
        private double time;
        private double hourly;
        private double total;

        // properties
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public double Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                CalcTotal();
            }
        }

        public double Hourly
        {
            get
            {
                return hourly;
            }
            set
            {
                hourly = value;
                CalcTotal();
            }
        }

        public double Total
        {
            get
            {
                return total;
            }
        }


        private void CalcTotal()
        {
            // we are using the Math.Round to round to 2 decimal places
            // 
            total = Math.Round((Time * Hourly),2,MidpointRounding.AwayFromZero);
        }

        public static Job operator+(Job j1, Job j2)
        {
            Job addedJob = new Job();
            addedJob.Description = j1.Description + " and " + j2.Description;
            addedJob.Time = j1.Time + j2.Time;
            addedJob.Hourly = (j1.Hourly + j2.Hourly) / 2;
            return addedJob;
        }
    }
}
