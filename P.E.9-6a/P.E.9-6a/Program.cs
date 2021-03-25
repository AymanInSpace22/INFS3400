using System;

namespace P.E._9_6a
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale[] sales = new Sale[10];
            int x;
            string entryString;
            for(x = 0; x < sales.Length; ++x)
            {
                sales[x] = new Sale();
                Console.Write("Enter Inventory number #{0} <<  ", x + 1);
                sales[x].InventoryNumber = Console.ReadLine();

                Console.Write("Enter amount of sale >> ");
                entryString = Console.ReadLine();
                sales[x].Amount = Convert.ToDouble(entryString);
            }

            for(x = 0; x < sales.Length; ++x)
            {
                Console.WriteLine("Sale #{0} Amount")
                //Console.WriteLine("Inventory # : {0} Amount: {1} Tax: {2}", (x + 1), sales[x].InventoryNumber, sales[x].Amount.ToString("C"));
                Console.WriteLine("Tax is {0}", sales[x].Tax.ToString("C"));
            }

        }
    }

    class Sale
    {
        private string inventoryNumber;
        private double amount;
        private double tax;

        // constants
        public const double LIMIT = 100;
        public const double FIRST_RATE = .08;
        public const double SECOND_RATE = .06;
        public string InventoryNumber
        {
            get
            {
                return inventoryNumber;
            }
            set
            {
                inventoryNumber = value;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public double Tax
        {
            get
            {
                return tax;
            }
        }

        private void CalcTax()
        {
            if (amount < 100)
                tax = amount * .08;
            else
                tax = (LIMIT * FIRST_RATE) + (amount - LIMIT) * SECOND_RATE;
        }

    }
}
