using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "main";
            Console.WriteLine(thread.Name);

            Thread newThread1 = new Thread(() => CountDown("Timer #1"));
            Thread newThread2 = new Thread(() => CountUp("Timer #2"));

            newThread1.Start();
            newThread2.Start();

            Console.WriteLine(thread.Name + " is complete!");

            Console.ReadKey();
        }

        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer 1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 1 is complete!");
        }

        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer 2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 2 is complete!");
        }
    }
}
