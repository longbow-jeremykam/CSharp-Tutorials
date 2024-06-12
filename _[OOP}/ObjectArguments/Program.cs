using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "yellow");

            Car car2 = copyObj(car1);

            Console.WriteLine(car2.color + " " + car2.model);

            Console.ReadKey();
        }
        
        public static Car copyObj(Car c)
        {
            return new Car(c.model, c.color);
        }
    }

    class Car
    {
        public string model;
        public string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
