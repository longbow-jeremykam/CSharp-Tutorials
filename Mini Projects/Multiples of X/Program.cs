using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiples_of_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter how many multiples of {0} to print?: ", number);
            int numM = Convert.ToInt32(Console.ReadLine());

            int[] multiples = new int[numM];

            for (int i = 0; i < multiples.Length; i++)
            {
                multiples[i] = number * (i + 1);
            }

            foreach (int multiple in multiples)
            {
                Console.Write(multiple + " ");
            }

            Console.ReadKey();
        }
    }
}
