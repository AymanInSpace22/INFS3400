using System;

namespace Base_Abstract_Interfaces_Extension
{

    // base class constructors
    // abstract classes
    // interfaces
    // extension methods


    // i think you have to put static in front of the class program when you use the extension method 
    static class Program
    {
        static void Main(string[] args)
        {
            /*Employee e1 = new Employee();
            e1.IdNumber = 123;
            e1.Name = "Galvin";
            Console.WriteLine(e1.ToString());


            Employee e2 = new Employee("Cory", 456);
            Console.WriteLine(e2.ToString());
            */

            // working with base class constructor
            FullTimeEmployee ft1 = new FullTimeEmployee("Smith", 789, 2000);
            Console.WriteLine(ft1.ToString());

            PartTimeEmployee pt1 = new PartTimeEmployee();
            pt1.Name = "Wes";
            pt1.IdNumber = 129;
            pt1.HourlyRate = 10.50;

            pt1.ClockIn();
            pt1.ClockOut();


            // this is for the extension method found below
            int randomValue = 1;
            int anotherValue = randomValue.AddTen();
            int aThirdValue = anotherValue.AddTen();
            int aFourthValue = aThirdValue.AddTen();
            int aFifthValue = aFourthValue.AddTen();
            Console.WriteLine(anotherValue);
            Console.WriteLine(aThirdValue);
            Console.WriteLine(aFourthValue);
            Console.WriteLine(aFifthValue);
         

            Console.ReadKey();

        }

        // this is an example of the extension method
        public static int AddTen(this int num)
        {
            return num = num + 10;
            // or you could do it like this
            // return nume += 10;
        }
    }
}
