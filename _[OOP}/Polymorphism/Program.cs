using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] racers = { car, bicycle, boat };

            foreach (Vehicle v in racers)
            {
                v.Go();
            }

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bike is moving");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
    }
}
