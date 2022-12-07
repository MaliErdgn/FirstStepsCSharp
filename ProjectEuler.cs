using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    internal class ProjectEuler
    {
        public static void projectEuler()//Done the first 4
        {
            #region Question 1 
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.
            int eulerAnswer1 = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    eulerAnswer1 += i;
                }
            }
            Console.WriteLine("Question 1 \r\n\r\nIf we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.\r\n\r\nFind the sum of all the multiples of 3 or 5 below 1000.\r\nAnswer: " + eulerAnswer1 + "\r\nConfirmed\r\n\r\n\r\n");
            #endregion
            #region Question 2
            int eulerAnswer2 = 0;
            int eulerFibonacci1 = 0;
            int eulerFibonacci2 = 1;
            int eulerFibonacciNextTerm = eulerFibonacci1 + eulerFibonacci2;
            do
            {
                if (eulerFibonacciNextTerm % 2 == 0)
                {
                    eulerAnswer2 += eulerFibonacciNextTerm;
                }
                eulerFibonacci1 = eulerFibonacci2;
                eulerFibonacci2 = eulerFibonacciNextTerm;
                eulerFibonacciNextTerm = eulerFibonacci1 + eulerFibonacci2;
            } while (eulerFibonacciNextTerm < 4000000);
            Console.WriteLine("Question 2 \r\n\r\nBy considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.\r\nAnswer: " + eulerAnswer2 + "\r\nConfirmed\r\n\r\n\r\n");
            #endregion
            #region Question 3
            long eulerNum = 600851475143;
            long eulerTestFactor = 1;
            string eulerPrimeString = "";
            while (++eulerTestFactor <= eulerNum)
            {
                eulerPrimeString += (eulerNum % eulerTestFactor == 0) ? " " + eulerTestFactor : "";

                while (eulerNum % eulerTestFactor == 0) eulerNum /= eulerTestFactor;
            }
            Console.WriteLine("Question 3 \r\n\r\nThe prime factors of 13195 are 5, 7, 13 and 29.\r\n\r\nWhat is the largest prime factor of the number 600851475143 ?\r\nAnswer:" + eulerPrimeString + "\r\nConfirmed\r\n\r\n\r\n");
            #endregion
            #region Question 4
            int eulerX;
            int eulerY = 0;
            string eulerProduct = "", eulerAnswer4 = "";
            List<int> eulerAnswer4List = new List<int>();
            for (eulerX = 100; eulerX < 999; eulerX++)
            {
                for (eulerY = 100; eulerY < 999; eulerY++)
                {
                    eulerProduct = Convert.ToString(eulerX * eulerY);


                    if (eulerProduct == new String(eulerProduct.Reverse().ToArray()))
                    {

                        eulerAnswer4 = eulerProduct;
                        eulerAnswer4List.Add(Convert.ToInt32(eulerAnswer4));
                    }
                }
            }
            Console.WriteLine("Question 4 \r\n\r\nA palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\r\n\r\nFind the largest palindrome made from the product of two 3-digit numbers.\r\nAnswer:" + eulerAnswer4List.Max() + "\r\nConfirmed\r\n\r\n\r\n");
            #endregion
        }
    }
}
