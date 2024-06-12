using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of columns:");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a symbol:");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
