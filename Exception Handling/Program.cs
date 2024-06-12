using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            double result;

            try
            {
                Console.WriteLine("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY NUMBERS Please!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Dividing by zero is not allowed!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong. Please try again");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }

            Console.ReadKey();
        }
    }
}
