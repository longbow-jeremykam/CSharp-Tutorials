using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
    }

    class Animal
    {
        //virtual = has default implementation, can be overrided by subclasses
        //abstract = no default implementation, must be overrided by subclasses
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
}
