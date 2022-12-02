using System;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Math.Calculator();
            ProgrammingChallenges.higherOrLower();
        }     
        class Math 
        {
        public static int Add(int firstAddition, int secondAddition) // adds the given numbers
        {
            return firstAddition + secondAddition;
        }
        public static int Subtract(int firstSubtraction, int secondSubtraction) // subtracts given numbers
        {
            return firstSubtraction - secondSubtraction;
        }
        public static int Multiply(int firstMultiplication, int secondMultiplication) // multiplies the given numbers
        {
            return firstMultiplication * secondMultiplication;
        }
        public static float Divide(float firstDivision, float secondDivision) // divides the given numbers
        {
            return firstDivision / secondDivision;
        }
        public static void Calculator() //a basic calculator that has addition subtraction multiplication and division
        {
            int firstCalculatorNumber;
            int secondCalculatorNumber;
            bool calculatorGame;
            string calculatorToDo;
            calculatorGame = true;
            while (calculatorGame == true)
            {
                Console.WriteLine("For addition press 1, for substraction press 2, for multiplication press 3, for division press 4 ");
                calculatorToDo = Console.ReadLine();
                
                switch(calculatorToDo)
                {
                    case "1":
                        Console.WriteLine("Enter first number of addition: ");
                        firstCalculatorNumber =  int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number of addition: ");
                        secondCalculatorNumber =  int.Parse(Console.ReadLine());
                        Console.WriteLine("= " + Add(firstCalculatorNumber,secondCalculatorNumber));
                        calculatorGame = false;
                        break;
                    case "2":
                        Console.WriteLine("Enter first number of subtraction: ");
                        firstCalculatorNumber =  int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number of subtraction: ");
                        secondCalculatorNumber =  int.Parse(Console.ReadLine());
                        Console.WriteLine("= " + Subtract(firstCalculatorNumber,secondCalculatorNumber));
                        calculatorGame = false;
                        break;
                    case "3":
                        Console.WriteLine("Enter first number of multiplication: ");
                        firstCalculatorNumber =  int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number of multiplication: ");
                        secondCalculatorNumber =  int.Parse(Console.ReadLine());
                        Console.WriteLine("= " + Multiply(firstCalculatorNumber,secondCalculatorNumber));
                        calculatorGame = false;
                        break;
                    case "4":
                        Console.WriteLine("Enter first number of division: ");
                        firstCalculatorNumber =  int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number of division: ");
                        secondCalculatorNumber =  int.Parse(Console.ReadLine());
                        Console.WriteLine("= " + Divide(firstCalculatorNumber,secondCalculatorNumber));
                        calculatorGame = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Would you like to try again? If so, please press 1 or else press any other key: ");
                        string invalidInput = Console.ReadLine();
                        if (invalidInput is not "1")
                        {
                            calculatorGame = false;
                        }
                        break;
                }   
                        
            }
        }
        }
        class ProgrammingChallenges
        {
            public static void higherOrLower() 
            {
                Random rand = new Random();
                int higherOrLowerRandom = rand.Next(1,101); // a random number between 1 and 100 
                
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
                Console.WriteLine("It took you " + higherOrLowerGuessNo +" amount of guesses");
            }
        }
    }
}
