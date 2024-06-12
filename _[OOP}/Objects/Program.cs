using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();

            human1.age = 56;
            human1.name = "Lenny";

            human2.age = 99;
            human2.name = "Brad";

            human1.eat();
            human1.sleep();

            human2.eat();
            human2.sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public void eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
