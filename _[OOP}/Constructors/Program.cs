using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car("Toyota", "Camry", 2020, "Red");
            newCar.Drive();

            Car newCar2 = new Car("Ford", "Drive", 2022, "Black");
            newCar2.Drive();

            Console.ReadKey();
        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String m_a, String m_o, int y, String c)
        {
            this.make = m_a;
            this.model= m_o;
            this.year = y;
            this.color = c;
        }

        public void Drive()
        {
            Console.WriteLine("I drive the " + color + " " + make + " " + model);
        }
    }
}
