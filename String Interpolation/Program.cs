using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstName = "George";
            String lastName = "Blake";
            int age = 31;

            //Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            //Console.WriteLine("You are " + age + " years old!");

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age, 15} old");

            Console.ReadKey();
        }
    }
}
