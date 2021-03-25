using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Display("rectangle");

            Console.ReadLine();

        }

        private static void Display(string shape, double width = 1, double height = 1)
        {
            shape = shape.ToUpper();
            Console.WriteLine("Area of " + shape + " is: " + (width * height));
        }
    }
}
