using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reverser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any message: ");
            string message = Console.ReadLine();

            char[] arr = message.ToArray();

            for (int i = arr.Length - 1; i >= 0; i--) {
                Console.Write(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
