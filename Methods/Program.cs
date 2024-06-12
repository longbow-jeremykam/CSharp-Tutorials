using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            String name = "Penny";
            int age = 19;

            singHappyBirthday(name, age);
            */
            Console.WriteLine("Enter a number:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a 2nd number:");
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Multiply(x, y);
            Console.WriteLine(x + " x " + y + " = " + z);

            Console.ReadKey();
        }

        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }

        /*
        static void singHappyBirthday(String n, int a)
        {
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday Dear " + n);
            Console.WriteLine("You are " + a + " years old!");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine();
        }
        */
    }
}
