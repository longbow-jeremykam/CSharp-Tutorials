using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Battle_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit player = new Unit(60000, 3000, 3000, "Vasto Lorde Unleashed");
            Unit enemy = new Unit(10000, 1500, 4500, "Murcielago: Segunda Etapa");

            while (!player.IsDead() && !enemy.IsDead()) 
            {
                Console.WriteLine("Player turn!\nWhat will you do? A - Attack or H - Heal?");

                string nextAction = Console.ReadLine().ToUpper();

                switch (nextAction)
                {
                    case "A":
                        {
                            player.Attack(enemy);
                            break;
                        }
                    case "H":
                    default:
                        {
                            player.Heal();
                            break;
                        }
                }

                Console.WriteLine("Enemy Turn!");

                if (enemy.CurrentHp < enemy.MaxHp * 0.75 || Unit.rand.NextDouble() >= 0.5)
                {
                    enemy.Heal();
                }
                else
                {
                    enemy.Attack(player);

                }

                Console.WriteLine("\nCurrent HP:\nPlayer: {0}\tEnemy: {1}", player.CurrentHp, enemy.CurrentHp);

                if (!player.IsDead())
                {
                    if (!enemy.IsDead())
                    {
                        Console.WriteLine(player.Name + " and " + enemy.Name + " prepare to strike the next round...");
                    }
                    else
                    {
                        Console.WriteLine("Player wins the game! " + player.Name + " is victorious!");
                    }
                }
                else
                {
                    Console.WriteLine("Player loses the game! " + enemy.Name + " is victorious!");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
