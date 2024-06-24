using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Spinner_Probability
{
    internal class Program
    {
        private static readonly Dictionary<String, int> itemProbs = new Dictionary<string, int>{

            {"Uncommon", 2520},
            {"Rare", 3650},
            {"Epic", 3110},
            {"Legendary", 600},
            {"Relic", 80},
            {"Contraband", 30},
            {"Unobtainable", 10}
        };

        private static readonly Random rand = new Random();
        static void Main(string[] args)
        {
            bool repeat = true;
            int numOfCatches = 0;
            int numOfSpins = 0;
            while (repeat) {
                for (int i = 0; i < 1; i++)
                {
                    numOfSpins++;
                    String itemR = GetRandomItem();
                    Console.WriteLine((i+1)+ ". \tRarity of Item: " + itemR);
                        
                    if (itemR.Equals("Contraband") || itemR.Equals("Relic") || itemR.Equals("Unobtainable"))
                    {
                        Console.WriteLine("AMAZING!");
                        numOfCatches++;
                        Console.WriteLine("Number of Spins: " + numOfSpins);
                        break;
                    }
                }
                Console.WriteLine("\nStolen: " + numOfCatches);

                Console.WriteLine();
                Console.WriteLine("Respin? Y/N?");
                repeat = (Console.ReadLine().ToUpper() == "N") ? false : true;

            }
        }

        public static String GetRandomItem()
        {
            int totalRange = 0;

            // Calculate total range based on scaled probabilities
            foreach (var itemRange in itemProbs.Values)
            {
                totalRange += itemRange;
            }

            int randomNumber = rand.Next(1, totalRange + 1);

            int cumulativeRange = 0;
            foreach (var kvp in itemProbs)
            {
                cumulativeRange += kvp.Value;
                if (randomNumber <= cumulativeRange)
                {
                    return kvp.Key; // Return the item
                }
            }

            return "Uncommon";
        }
    }
}
