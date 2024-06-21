using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, };
            double[] doubArr = { 1, 2, 3 };
            string[] strArr = { "1", "2", "3" };

            PrintArr(strArr);

            Console.ReadKey();
        }

        public static void PrintArr<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

    }
}
