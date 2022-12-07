using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    internal class FourOperatorCalculator
    {
        public static void fourWayCalculator() //Done //a basic 4 operation calculator (+ - * /)
        {
            static int Add(int firstAddition, int secondAddition) // adds the given numbers
            {
                return firstAddition + secondAddition;
            }
            static int Subtract(int firstSubtraction, int secondSubtraction) // subtracts given numbers
            {
                return firstSubtraction - secondSubtraction;
            }
            static int Multiply(int firstMultiplication, int secondMultiplication) // multiplies the given numbers
            {
                return firstMultiplication * secondMultiplication;
            }
            static float Divide(float firstDivision, float secondDivision) // divides the given numbers
            {
                return firstDivision / secondDivision;
            }
            static void Calculator() //a basic calculator that has addition subtraction multiplication and division
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

                    switch (calculatorToDo)
                    {
                        case "1":
                            Console.WriteLine("Enter first number of addition: ");
                            firstCalculatorNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number of addition: ");
                            secondCalculatorNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("= " + Add(firstCalculatorNumber, secondCalculatorNumber));
                            calculatorGame = false;
                            break;
                        case "2":
                            Console.WriteLine("Enter first number of subtraction: ");
                            firstCalculatorNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number of subtraction: ");
                            secondCalculatorNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("= " + Subtract(firstCalculatorNumber, secondCalculatorNumber));
                            calculatorGame = false;
                            break;
                        case "3":
                            Console.WriteLine("Enter first number of multiplication: ");
                            firstCalculatorNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number of multiplication: ");
                            secondCalculatorNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("= " + Multiply(firstCalculatorNumber, secondCalculatorNumber));
                            calculatorGame = false;
                            break;
                        case "4":
                            Console.WriteLine("Enter first number of division: ");
                            firstCalculatorNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number of division: ");
                            secondCalculatorNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("= " + Divide(firstCalculatorNumber, secondCalculatorNumber));
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
            Calculator();
        }
    }
}
