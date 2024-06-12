using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String playerThrow = "";
            String computerThrow = "";

            int playerPt = 0,
                computerPt = 0;

            while (playAgain)
            {
                while (playerPt != 3 && computerPt != 3)
                {
                    Console.WriteLine(playerPt + " - " + computerPt);

                    while (playerThrow != "ROCK" && playerThrow != "PAPER" && playerThrow != "SCISSORS")
                    {
                        Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                        playerThrow = Console.ReadLine().ToUpper();
                    }

                    String[] items = new string[3]{ "ROCK", "PAPER", "SCISSORS" };
                    int rand = random.Next(0, items.Length);

                    computerThrow = items[rand];
                    Console.WriteLine(computerThrow);

                    //player throws rock
                    if (playerThrow.Equals(items[0]))
                    {
                        if (computerThrow.Equals(items[0]))
                        {
                            Console.WriteLine("Draw! No one wins");
                        }
                        else if (computerThrow.Equals(items[1]))
                        {
                            Console.WriteLine("You lose this round! Computer wins");
                            computerPt++;
                        }
                        else if (computerThrow.Equals(items[2]))
                        {
                            Console.WriteLine("You win this round!");
                            playerPt++;
                        }
                    }
                    else if (playerThrow.Equals(items[1]))
                    {
                        if (computerThrow.Equals(items[0]))
                        {
                            Console.WriteLine("You win this round!");
                            playerPt++;
                        }
                        else if (computerThrow.Equals(items[1]))
                        {
                            Console.WriteLine("Draw! No one wins");
                        }
                        else if (computerThrow.Equals(items[2]))
                        {
                            Console.WriteLine("You lose this round! Computer wins");
                            computerPt++;
                        }
                    }
                    else if (playerThrow.Equals(items[2]))
                    {
                        if (computerThrow.Equals(items[0]))
                        {
                            Console.WriteLine("You lose this round! Computer wins");
                            computerPt++;
                        }
                        else if (computerThrow.Equals(items[1]))
                        {
                            Console.WriteLine("You win this round!");
                            playerPt++;
                        }
                        else if (computerThrow.Equals(items[2]))
                        {
                            Console.WriteLine("Draw! No one wins");
                        }
                    }

                    playerThrow = "";
                    computerThrow = "";
                }

                if (playerPt == 3)
                {
                    Console.WriteLine("Player wins the game!");
                }
                else if (computerPt == 3)
                {
                    Console.WriteLine("Computer wins the game");
                }

                Console.WriteLine("Play Again? (Y/N)");
                String response = Console.ReadLine().ToUpper();

                if (response.Equals("Y"))
                {
                    playerPt = 0;
                    computerPt = 0;
                    playerThrow = "";
                    computerThrow = "";
                }
                else if (response.Equals("N"))
                {
                    Console.WriteLine("Quitted");
                    playAgain = false;
                }
            }
        }
    }
}
