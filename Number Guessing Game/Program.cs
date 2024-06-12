using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random random = new Random();

            int toGuess = random.Next(1, 10);

            Console.WriteLine("Guess a number between 1 - 10");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input != toGuess) {
                Console.WriteLine("Too bad. :(");
            }
            else
            {
                Console.WriteLine("You gussed the number!");
            }

            Console.WriteLine(toGuess);

            Console.ReadKey();
            */

            Random random = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                int guesses = 0;
                int toGuess = random.Next(1, 100);
                int guess = -1;

                Console.WriteLine("Guess a number between 1 - 100");
                guess = Convert.ToInt32(Console.ReadLine());

                while (toGuess != guess)
                {
                    guesses++;
                    if (guess < toGuess)
                    {
                        Console.WriteLine("Your guess is too low!");
                    }

                    if (guess > toGuess)
                    {
                        Console.WriteLine("Your guess is too high!");
                    }

                    Console.WriteLine("Guess a number between 1 - 100");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("You guessed the number!");
                Console.WriteLine("Number of guesses: " + guesses);

                Console.WriteLine("Play again? (Y/N)");
                String response = Console.ReadLine().ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Quitted");
            Console.ReadKey();
        }
    }
}
