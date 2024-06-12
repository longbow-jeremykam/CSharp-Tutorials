using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<String> food = new List<string>()
            {
                "fries",
                "pizza",
                "hamburger",
                "hotdog",
                "fries"
            };

            //food.Add("tacos");
            //food.Remove("hotdog");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            String[] foodArr = food.ToArray();

            foreach (String item in foodArr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
