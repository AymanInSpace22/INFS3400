using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePoject1
{
    class Dog : animal
    {


        public Dog()
        {
      
        }

        public override string ToString()
        {
            return Name + " " + NumLegs;
        }

        public override bool Equals(object obj)
        {
            bool isEqual = true;
            Dog temp = (Dog)obj;
            if(this.Name == temp.Name && this.NumLegs == temp.NumLegs)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }

            return isEqual;
           // return base.Equals(obj);
        }

        public override void Move()
        {
            Console.WriteLine("Our dog runs");
        }

    }
}
