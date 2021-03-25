using System;

namespace ConsoleApp5
{
    class Program
    {

        // this is 9-10a


        static void Main(string[] args)
        {
            // create a job class
            // 4 data fields - Description, TIme, Hourly, Total
            // properties for each field except total
            // total - readonly - (round to two decimals)
            // overload operator + (added two jobs)
            // creates new job - containing descriptions for both and the sum of time
            // and average
            // Display total fee for each job

            Job j1 = new Job();
            Job j2 = new Job();

            j1.Description = "wash windows";
            j1.Time = 3.5;
            j1.Hourly = 25;

            j2.Description = "rake leaves";
            j2.Time = 2;
            j2.Hourly = 18.50;

            Console.WriteLine("Job: {0} is {1} per hour {2} hours.\n    total = {3}",
                j1.Description, j1.Hourly.ToString("C"), j1.Time, j1.Total);
            Console.WriteLine("Job: {0} is {1} per hour {2} hours.\n    total = {3}",
                j2.Description, j2.Hourly.ToString("C"), j2.Time, j2.Total);

            Job j3 = j1 + j2;
                Console.WriteLine("Job: {0} is {1} per hour {2} hours.\n    total = {3}",
                j3.Description, j3.Hourly.ToString("C"), j3.Time, j3.Total);

            Console.ReadKey();
        }
    }

}
