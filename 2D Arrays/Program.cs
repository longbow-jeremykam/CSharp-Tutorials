using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] ford = { "Mustang", "F-150", "Explorer"};
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Camry", "Corolla", "Rav4" };

            String[,] parkingLot =
            {
                { "Mustang", "F-150", "Explorer"},
                { "Corvette", "Camaro", "Silverado" },
                { "Camry", "Corolla", "Rav4" }
            };

            parkingLot[0, 2] = "Fusion";

            /*
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }*/

            for(int i = 0; i<parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
