using System;

namespace MiniGamesAppLibrary
{
    public class HigherLower
    {
        private int secretNumber;

        public void HigherLowerMain()
        {
            Console.WriteLine("\nWelcome to the HigherLower game.");
            Console.WriteLine("A random number from 1 to 50 will be generated.");

            secretNumber = RandomGen(); // Generate secret number once

            int yourNumber;
            bool guessed = false;

            while (!guessed)
            {
                Console.Write("Please make a guess: ");
                yourNumber = Convert.ToInt32(Console.ReadLine());

                if (yourNumber > secretNumber)
                {
                    Console.WriteLine("\nToo high! Try again.");
                }
                else if (yourNumber < secretNumber)
                {
                    Console.WriteLine("\nToo low! Try again.");
                }
                else
                {
                    Console.WriteLine($"\nYou guessed it!!! It was {secretNumber}");
                    guessed = true; // Set guessed to true to exit the loop
                }
            }

            Console.Write("\n1: Play again!  2: Back to menu  -> ");
            int whatNext = Convert.ToInt32(Console.ReadLine());
            switch (whatNext)
            {
                case 1: HigherLowerMain();
                    break;
                case 2:
                    return;
                default:
                    Console.WriteLine("Something went wrong!?!?");
                    break;
            }
        }

        private int RandomGen()
        {
            Random random = new Random();
            return random.Next(1, 51); // Generate a random number from 1 to 50
        }
    }
}
