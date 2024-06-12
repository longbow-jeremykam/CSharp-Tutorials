using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] cars = { "BMW", "Aston Martin", "Bugatti", "Mercedes"};

            foreach(String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
