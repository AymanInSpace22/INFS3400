using System;
using static System.Console;

namespace InheritancePoject1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism (Latin for Many forms)
            // Implicit reference conversion
            animal a1; 
            a1 = new Dog();
            a1.Name = "Mattie";
            animal.Info(a1);
            a1.Move();

            Dog d2 = new Dog();
            d2.Name = "Jake";
            d2.NumLegs = 4;
            animal.Info(d2);

            a1 = new Bird();
            a1.Move();

            



            /* Dog Mattie = new Dog();
             Mattie.NumLegs = 4;

             Dog d1 = new Dog();
             d1.Name = "Cali";
             d1.NumLegs = 4;

             // we are going to use these built in methods on our first three chapter ten assignments
             // WriteLine(d1.GetType());
             //WriteLine(d1.ToString());
             //WriteLine(d1.GetHashCode());

             Dog d3 = new Dog();
             d3.Name = "Cali";
             d3.NumLegs = 3;


             Bird Polly = new Bird();
             Polly.NumLegs = 2;

             Bird b1 = new Bird();

             GoldenRetriever Cora = new GoldenRetriever();
             Cora.NumLegs = 4;


             d1.Move();
             b1.Move();
            */

            /* if(d1.Equals(d3))
             {
                 WriteLine("They are equal");
             }
             else
             {
                 WriteLine("They are NOT equal");
             }*/
            ReadKey();
        }
    }
}
