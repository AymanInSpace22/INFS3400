using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePoject1
{
    class animal
    {
        // fields
        private int numLegs;
        private string name;


        // property
        public int NumLegs //{ get; set; }
        {
            get
            {
                return numLegs;
            }
            set
            {
                numLegs = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value == "")
                {
                    Console.WriteLine("Bad value, please enter a name");
                }
                name = value;
            }
        }

        public virtual void Move()
        {
            Console.WriteLine("Our animals can move");
        }

        public override int GetHashCode()
        {
            return numLegs.GetHashCode();
           // return base.GetHashCode();
        }


        public static void Info(animal a)
        {
            Console.WriteLine(a.Name);
        }

    }
}
