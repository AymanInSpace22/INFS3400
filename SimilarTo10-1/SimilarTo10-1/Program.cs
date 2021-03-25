using System;

namespace SimilarTo10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two classes - Animal - Leopard
            // Auto implemented properties
            // ToString Method - include GetType()


            // instantiate objects
            Animal a1 = new Animal();
            Leopard l1 = new Leopard();

            a1.Name = "Honey";
            a1.Legs = 4;

            l1.Name = "Sabor";
            l1.Legs = 4;
            l1.Spots = 100;

            Console.WriteLine(a1.ToString());
            Console.WriteLine(l1.ToString() + " and " + l1.Spots + " spots ");

            Console.ReadKey();

        }
    }
}
