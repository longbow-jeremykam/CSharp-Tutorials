using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstP = null, secondP = null;

            Console.WriteLine("Enter a password");
            firstP = Console.ReadLine();
            while (firstP == null || firstP == "" || firstP == " ") {
                Console.WriteLine("Please enter a password");
                firstP = Console.ReadLine();
            }

            Console.WriteLine("Confirm password");
            secondP = Console.ReadLine();
            while (secondP == null || secondP == "" || secondP == " ")
            {
                Console.WriteLine("Please confirm password");
                secondP = Console.ReadLine();
            }

            if (firstP != secondP)
            {
                Console.WriteLine("Passwords do not match");
            }
            else
            {
                Console.WriteLine("Passwords match");
            }

            Console.ReadKey();
        }
    }
}
