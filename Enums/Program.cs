using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
            //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

            String name = PlanetRadius.Earth.ToString();
            int radius = (int) PlanetRadius.Earth;

            Console.WriteLine("Planet: " + name);
            Console.WriteLine("Radius: " + radius + "km");
            Console.WriteLine("Volume: " + CalcVolume(PlanetRadius.Earth) + "km3");

            Console.ReadKey();
        }

        public static double CalcVolume(PlanetRadius radius)
        {
            //add the .0 for double values changes the result (for some reasons)
            return (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        }

        public enum Planets
        {
            Mercury = 1,
            Venus = 2,
            Earth = 3,
            Mars = 4,
            Jupiter = 5,
            Saturn = 6,
            Uranus = 7,
            Neptune = 8,
            Pluto = 9
        }

        public enum PlanetRadius
        {
            Mercury = 2439,
            Venus = 6051,
            Earth = 6371,
            Mars = 3389,
            Jupiter = 69911,
            Saturn = 58232,
            Uranus = 25362,
            Neptune = 24622,
            Pluto = 1188
        }
    }
}
