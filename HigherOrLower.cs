using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    public class HigherOrLower
    {
        public static void HigherOrLowerGame()
        {
            Random rand = new Random();
            int higherOrLowerRandom = rand.Next(1, 101); // a random number between 1 and 100 

            string guess;
            int higherOrLowerGuessNo = 0;
            bool higherOrLowerGame = true;

            Console.WriteLine("In this game the user is going to try to guess the random number between 1 and 100");

            while (higherOrLowerGame == true)
            {
                Console.WriteLine("Enter a number: ");
                guess = Console.ReadLine();
                if (higherOrLowerRandom == int.Parse(guess))
                {
                    Console.WriteLine("You win!");
                    higherOrLowerGame = false;

                }
                else if (higherOrLowerRandom > int.Parse(guess))
                {
                    Console.WriteLine("Higher!");
                }
                else if (higherOrLowerRandom < int.Parse(guess))
                {
                    Console.WriteLine("Lower!");
                }
                higherOrLowerGuessNo += 1;
            }
            Console.WriteLine("It took you " + higherOrLowerGuessNo + " amount of guesses");
        }
    }
}
