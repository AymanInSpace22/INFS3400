using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // these are the fields
            Cat cat01 = new Cat();
            cat01.name = "Kitty";
            cat01.age = 3;
            cat01.Meow();
        }
    }

    class Cat
    {
        public string name;
        public int age;


        // this is the method
        public void Meow()
        {
            Console.WriteLine(name + " says meow!");
        }
    }
}
