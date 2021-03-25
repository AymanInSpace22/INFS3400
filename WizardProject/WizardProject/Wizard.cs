using System;
using System.Collections.Generic;
using System.Text;

namespace WizardProject
{
    class Wizard
    {

        private string name;
        private string favoriteSpell;
        private int spellToken;
        private int experience;




        public void CastSpell()
        {
            if (spellToken > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellToken--;
                experience += 1;
            }
            else
            {
                Console.WriteLine(name + " is out of spell tokens");
            }
        }

        public void PracticeSpells()
        {
            Console.WriteLine(name + " practices to regain spell tokens");
            spellToken = 2;
        }

        // constructor
        public Wizard()
        {
            spellToken = 2;
            experience = 0;
        }

        public Wizard(string name, string favoriteSpell)
        {
            this.name = name;
            this.favoriteSpell = favoriteSpell;
            spellToken = 2;
            experience = 0;
        }

    }
}
