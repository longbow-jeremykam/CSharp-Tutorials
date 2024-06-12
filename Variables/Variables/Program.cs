using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration

            x = 5; //initialization

            int y = 321; //declaration + initialization

            int z = x + y;

            int age = 21; //whole integer

            double height = 300.5; //decimal

            bool alive = false; //true or false

            char symbol = '@'; //characters

            String name = "Bro"; //string of text

            Console.WriteLine("Hello");

            Console.WriteLine("Your age is " + age);

            Console.WriteLine("Your height is " + height + "cm");

            Console.WriteLine("Are you alive? " + alive);

            Console.WriteLine("Your symbol is " + symbol);

            String username = symbol + name;

            Console.WriteLine("Your username is " + username);

            Console.ReadLine();
        }
    }
}
