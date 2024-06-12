using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = 100000000;

            Console.WriteLine(car.Speed);

            Console.ReadKey();

        }
    }

    class Car
    {
        private int speed;
        
        public Car(int s)
        {
            this.speed = s;
        }

        //getter & setter
        public int Speed
        {
            get
            {

            return speed; }
            set
            {
                if(value > 500)
                {
                    value = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
