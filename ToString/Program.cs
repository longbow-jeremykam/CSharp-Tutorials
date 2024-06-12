using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car1);

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
            this.model = m_o;
            this.year = y;
            this.color = c;
        }

        public void Drive()
        {
            Console.WriteLine("I drive the " + color + " " + make + " " + model);
        }

        public override string ToString()
        {
            return "Car Make: " + make + "\nCar Model: " + model + "\nYear: " + year + "\nColor: " + color;
        }
    }
}
