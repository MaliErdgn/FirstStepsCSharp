using System;
using HtmlAgilityPack;

namespace FirstStepsCSharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            ProgrammingChallenges.NameGenerator();
        }     

        
        class ProgrammingChallenges
        {
            public static void higherOrLower() //Done
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
            }//play game where you try to guess the number (between 1-100)
            public static void tempatureConverter() //Done
            {
                Console.WriteLine("Choose conversion type:\nCelcius to Kelvin (1)\nCelcius to Fahrenheit (2)\nFahrenheit to Kelvin (3)\nFahrenheit to Celcius (4)\nKelvin to Celcius (5)\nKelvin to Fahrenheit (6)");
                string tempatureConverterInput = Console.ReadLine();
                float tempatureConverterReturnedValue;
                float tempatureConverterInputValue;
                switch (tempatureConverterInput)
                {
                    case "1":
                        Console.WriteLine("Enter the Celcius value: ");
                        tempatureConverterInputValue = float.Parse(Console.ReadLine());
                        tempatureConverterReturnedValue = (float)(tempatureConverterInputValue + 273.15);
                        Console.WriteLine(tempatureConverterInputValue + " celcius = " + tempatureConverterReturnedValue + " Kelvin");
                     break;
                    case "2":
                        Console.WriteLine("Enter the Celcius value: ");
                        tempatureConverterInputValue = float.Parse(Console.ReadLine());
                        tempatureConverterReturnedValue = (float)((tempatureConverterInputValue*1.8)+32);
                        Console.WriteLine(tempatureConverterInputValue + " celcius = " + tempatureConverterReturnedValue + " Fahrenheit");
                        break;
                    case "3":
                        Console.WriteLine("Enter the Fahrenheit value: ");
                        tempatureConverterInputValue = float.Parse(Console.ReadLine());
                        tempatureConverterReturnedValue = (float)((tempatureConverterInputValue-32)*5/9+273.15);
                        Console.WriteLine(tempatureConverterInputValue + " fahrenheit = " + tempatureConverterReturnedValue + " Kelvin");
                        break;
                    case "4":
                        Console.WriteLine("Enter the Fahrenheit value: ");
                        tempatureConverterInputValue = float.Parse(Console.ReadLine());
                        tempatureConverterReturnedValue = (float)((tempatureConverterInputValue-32)*5/9);
                        Console.WriteLine(tempatureConverterInputValue + " fahrenheit = " + tempatureConverterReturnedValue + " celcius");
                        break;
                    case "5":
                        Console.WriteLine("Enter the Kelvin value: ");
                        tempatureConverterInputValue = float.Parse(Console.ReadLine());
                        tempatureConverterReturnedValue = (float)(tempatureConverterInputValue-273.15);
                        Console.WriteLine(tempatureConverterInputValue + " Kelvin = " + tempatureConverterReturnedValue + " celcius");
                        break;
                    case "6":
                        Console.WriteLine("Enter the Kelvin value: ");
                        tempatureConverterInputValue = float.Parse(Console.ReadLine());
                        tempatureConverterReturnedValue = (float)((tempatureConverterInputValue-273.15)*9/5+32);
                        Console.WriteLine(tempatureConverterInputValue + " Kelvin = " + tempatureConverterReturnedValue + " Fahrenheit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }//do conversion between tempature types
            public static void rockPaperScissors() //Done
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
                    var rockPaperScissorslist = new List<string>{ "rock","paper","scissors"};
                    var rockPaperScissorsRandom = new Random();
                    int rockPaperScissorsCPUIndex = rockPaperScissorsRandom.Next(rockPaperScissorslist.Count);
                    string rockPaperScissorsCPUChoice = (string)(rockPaperScissorslist[rockPaperScissorsCPUIndex]);
                    Console.WriteLine("Your Choice: "+rockPaperScissorsChoice);
                    Console.WriteLine("Computer's Choice: "+rockPaperScissorsCPUChoice);
                    if (((rockPaperScissorsChoice == "rock") && (rockPaperScissorsCPUChoice == "scissors")) || ((rockPaperScissorsChoice == "paper") && (rockPaperScissorsCPUChoice == "rock")) || ((rockPaperScissorsChoice == "scissors") && (rockPaperScissorsCPUChoice == "paper")))
                    {
                        Console.WriteLine("You Win!");
                        rockPaperScissorsPlayerScore += 1;
                    }
                    else if (rockPaperScissorsChoice == rockPaperScissorsCPUChoice)
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (((rockPaperScissorsChoice == "rock")&&(rockPaperScissorsCPUChoice == "paper"))||((rockPaperScissorsChoice == "paper")&&(rockPaperScissorsCPUChoice == "scissors"))||((rockPaperScissorsChoice == "scissors")&&(rockPaperScissorsCPUChoice == "rock")))
                    {
                        Console.WriteLine("You Lose!");
                        rockPaperScissorsCPUScore += 1;
                    }
                    else 
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    Console.WriteLine("Player "+ rockPaperScissorsPlayerScore + "-" + rockPaperScissorsCPUScore + " Computer");
                }
            }//play rock paper scissors with computer
            public static void FourWayCalculator() //Done
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
                Calculator();
            }//a basic 4 operation calculator (+ - * /)
            public static void CalculateAgeInSeconds() //Done
            {
                DateTime CalculateAgeInSecondsCurrentDate = DateTime.Now;
                Console.WriteLine("Enter your birthdate in the format DD MM YYYY: ");
                string CalculateAgeInSecondsBirthDate = Console.ReadLine();
                string[] CalculateAgeInSecondsBDList = CalculateAgeInSecondsBirthDate.Split(" ");
                DateTime CalculateAgeInSecondsSpan = new DateTime(int.Parse(CalculateAgeInSecondsBDList[2]), int.Parse(CalculateAgeInSecondsBDList[1]), int.Parse(CalculateAgeInSecondsBDList[0]));
                TimeSpan CalculateAgeInSecondsDiff = CalculateAgeInSecondsCurrentDate - CalculateAgeInSecondsSpan;
                string CalculateAgeInSecondsDiffString = CalculateAgeInSecondsDiff.TotalSeconds.ToString();
                string[] CalculateAgeInSecondsOutput = CalculateAgeInSecondsDiffString.Split(",");
                Console.WriteLine(CalculateAgeInSecondsOutput[0] + " seconds have passed since you were born!");

            }//Calculates the total amount of times past your birthdate
            public static void NameGenerator()//Done 
            {
                static void nameAndSurnameList(int NameGeneratorLoopAmount) //Creates lists of names and surnames
                {
                    var html = @"https://www.ssa.gov/oact/babynames/decades/century.html"; //link of names list
                    HtmlWeb web = new HtmlWeb();
                    var htmlDoc = web.Load(html);
                    var htmlSurname = @"https://www.thoughtco.com/most-common-us-surnames-1422656"; //link of surnames list
                    HtmlWeb webSurname = new HtmlWeb();
                    var htmlSurnameDoc = webSurname.Load(htmlSurname);
                    List<string> nameList = new List<string>();
                    List<string> surnameList = new List<string>();
                    foreach (int i in Enumerable.Range(1, 100)) //adds the male names to the name list
                    {
                        var node = htmlDoc.DocumentNode.SelectSingleNode($"//*[@id=\"content\"]/section[2]/div/div[2]/table/tbody/tr[{i}]/td[2]");
                        nameList.Add(node.InnerText);
                    }
                    foreach (int i in Enumerable.Range(1, 100)) //adds the female names to the name list
                    {
                        var node = htmlDoc.DocumentNode.SelectSingleNode($"//*[@id=\"content\"]/section[2]/div/div[2]/table/tbody/tr[{i}]/td[4]");
                        nameList.Add(node.InnerText);
                    }
                    foreach (int i in Enumerable.Range(1, 100)) //adds the surnames to the name list
                    {
                        var node = htmlSurnameDoc.DocumentNode.SelectSingleNode($"//*[@id=\"mntl-sc-block_1-0-5\"]/div/table/tbody/tr[{i}]/td[2]/p");
                        surnameList.Add(node.InnerText);
                    }
                    foreach (int j in Enumerable.Range(1, NameGeneratorLoopAmount)) 
                    {
                        var NameGeneratorRandom = new Random();
                        int NameGeneratorNameIndex = NameGeneratorRandom.Next(nameList.Count);
                        int NameGeneratorSurnameIndex = NameGeneratorRandom.Next(surnameList.Count);
                        Console.WriteLine(nameList[NameGeneratorNameIndex] + " " + surnameList[NameGeneratorSurnameIndex]);
                    }
                }
                Console.WriteLine("How many random names do you want? ");
                var NameGeneratorAmount = Console.ReadLine(); //The amount of times the names will be generated     
                nameAndSurnameList(int.Parse(NameGeneratorAmount));         
            }// Gives you random names
        }
    }
}
