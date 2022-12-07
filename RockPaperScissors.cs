using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    internal class RockPaperScissors
    {
        public static void rockPaperScissors() //Done //play rock paper scissors with computer
        {
            int rockPaperScissorsPlayerScore = 0;
            int rockPaperScissorsCPUScore = 0;
            bool rockPaperScissorsGame = true;
            while (rockPaperScissorsGame == true)
            {
                Console.WriteLine("Choose between rock paper and scissors. If you wanna leave the game write -1: ");
                string rockPaperScissorsChoice = Console.ReadLine();
                if (rockPaperScissorsChoice == "-1")
                {
                    break;
                }
                var rockPaperScissorslist = new List<string> { "rock", "paper", "scissors" };
                var rockPaperScissorsRandom = new Random();
                int rockPaperScissorsCPUIndex = rockPaperScissorsRandom.Next(rockPaperScissorslist.Count);
                string rockPaperScissorsCPUChoice = (string)(rockPaperScissorslist[rockPaperScissorsCPUIndex]);
                Console.WriteLine("Your Choice: " + rockPaperScissorsChoice);
                Console.WriteLine("Computer's Choice: " + rockPaperScissorsCPUChoice);
                if (((rockPaperScissorsChoice == "rock") && (rockPaperScissorsCPUChoice == "scissors")) || ((rockPaperScissorsChoice == "paper") && (rockPaperScissorsCPUChoice == "rock")) || ((rockPaperScissorsChoice == "scissors") && (rockPaperScissorsCPUChoice == "paper")))
                {
                    Console.WriteLine("You Win!");
                    rockPaperScissorsPlayerScore += 1;
                }
                else if (rockPaperScissorsChoice == rockPaperScissorsCPUChoice)
                {
                    Console.WriteLine("Draw!");
                }
                else if (((rockPaperScissorsChoice == "rock") && (rockPaperScissorsCPUChoice == "paper")) || ((rockPaperScissorsChoice == "paper") && (rockPaperScissorsCPUChoice == "scissors")) || ((rockPaperScissorsChoice == "scissors") && (rockPaperScissorsCPUChoice == "rock")))
                {
                    Console.WriteLine("You Lose!");
                    rockPaperScissorsCPUScore += 1;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Player " + rockPaperScissorsPlayerScore + "-" + rockPaperScissorsCPUScore + " Computer");
            }
        }
    }
}
