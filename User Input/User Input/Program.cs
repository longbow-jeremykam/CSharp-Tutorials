using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");
            Console.ReadKey();

        }
    }
}
