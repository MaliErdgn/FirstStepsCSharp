using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    internal class FizzBuzz
    {
        public static void fizzBuzz()//Done //The simple FizzBuzz game
        {
            string fizzRepeatNumber;
            Console.WriteLine("Which number do you want to play FizzBuzz untill?");
            fizzRepeatNumber = Console.ReadLine();
            int fizzRepeatNumberInt = int.Parse(fizzRepeatNumber);
            void FizzBuzzString(int fizzRepeatNumberInt)
            {
                foreach (int i in Enumerable.Range(1, fizzRepeatNumberInt))
                {
                    if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            FizzBuzzString(fizzRepeatNumberInt);
        }
    }
}
