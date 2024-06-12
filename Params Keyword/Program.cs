using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //params keyword = used to combine a variable number of arguments.
            //                 The parameter type must be a single - dimensional array

            double total = Checkout(3.99, 5.75, 15, 1.1, 22.99);
            Console.WriteLine(total);

            Console.ReadKey();
        }
        static double Checkout(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;

            }
            return total;
        }
    }
}
