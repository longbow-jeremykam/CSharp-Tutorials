using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("HAPPY NEW YEAR!");

            Console.ReadKey();
        }
    }
}
