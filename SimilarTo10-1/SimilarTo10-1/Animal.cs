using System;
using System.Collections.Generic;
using System.Text;

namespace SimilarTo10_1
{
    class Animal
    {
        // auto-implemented properties
        public string Name { get; set; }
        public int Legs { get; set; }


        // ToString - include GetType()
        public new string ToString()
        {
            return (GetType() + " Our animal has a name: " + Name + " with " + Legs + " legs ");
        }
    }
}
