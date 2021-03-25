using System;

namespace WizardProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Harry", "Unlocking charm");
          
            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Draco", "Babbling Curse");

            wizard02.CastSpell();

            Console.ReadKey();


        }
    }
}
