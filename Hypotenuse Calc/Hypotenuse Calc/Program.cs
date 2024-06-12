using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of triangle: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height of triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The hypotenuse of the triangle is " + c);
            Console.WriteLine("Length = " + a);
            Console.WriteLine("Height = " + b);
            Console.ReadKey();
        }
    }
}
