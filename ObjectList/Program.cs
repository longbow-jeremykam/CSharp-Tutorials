using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>()
            {
                new Player("Crucible"),
                new Player("Felxiing"),
                new Player("RTPosh")
            };

            foreach (Player p in players)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }

    class Player
    {
        public String username;

        public Player(String name)
        {
            this.username = name;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
