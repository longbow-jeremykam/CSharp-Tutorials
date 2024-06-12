using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            if (!name.Equals(""))
            {
                Console.WriteLine("Hello " + name);
                
            }
            else
            {
                Console.WriteLine("You did not enter your name!");
            }

            Console.ReadKey();
        }
    }
}
