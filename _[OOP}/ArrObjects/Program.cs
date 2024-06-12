using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] garage =
            {
                new Car("Mustang"),
                new Car("Lambo"),
                new Car("Nissan GT")
            };

            foreach(Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
