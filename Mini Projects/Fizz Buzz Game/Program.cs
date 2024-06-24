using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + ": Fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + ": Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + ": Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
