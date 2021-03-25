using static System.Console;

namespace ReviewMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comment Section
            /* Methods always have parantheses
             * Access Modifier: Public or private. Private is the default
             * Private: only use it within that class
             * Public: Anyone can use it
             * If you do a reutrn, make sure the proper return type is in place
             */

            Add(5, 5);
            int answer = NewAdd(5, 5);
            WriteLine(answer);


            //DisplaySalesTax(50);

        }

        /*private static void DisplaySalesTax(double salesAmount)
        {
            const double RATE = .07;
            double tax = salesAmount * RATE;
            WriteLine("The tax on {0} is {1}", salesAmount.ToString("C"), tax.ToString("C"));
        }*/

       private static void Add(int x, int y)
        {
            int answer = x + y;
            WriteLine("{0} + {1} = {2}", x, y, answer);
        }

        private static int NewAdd(int x, int y)
        {
            int answer = x + y;
            return answer;
        }

    }
}
