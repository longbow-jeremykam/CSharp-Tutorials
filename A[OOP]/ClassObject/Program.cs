using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }
    /*
    public static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program!");
        }

        public static void Waiting()
        {
            Console.WriteLine("I am waiting!");
        }

        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting!");
        }
    }
    */
}


