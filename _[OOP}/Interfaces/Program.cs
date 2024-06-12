using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();

            rabbit.flee();

            Hawk hawk = new Hawk();

            hawk.hunt();

            Fish fish = new Fish();

            fish.hunt();
            fish.flee();

            Console.ReadKey();
        }

        interface Prey
        {
            void flee();
        }

        interface Predator
        {
            void hunt();
        }

        class Rabbit : Prey
        {
            public void flee()
            {
                Console.WriteLine("The rabbit flees");
            }
        }

        class Hawk : Predator
        {
            public void hunt()
            {
                Console.WriteLine("The hawk hunts for food");
            }

        }

        class Fish : Prey, Predator
        {
            public void flee()
            {
                Console.WriteLine("The fish swims away");
            }

            public void hunt()
            {
                Console.WriteLine("The fish hunts for food");
            }
        }
    }
}
