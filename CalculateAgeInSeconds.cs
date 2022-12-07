using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    internal class CalculateAgeInSeconds
    {
        public static void calculateAgeInSeconds() //Done //Calculates the total amount of times past your birthdate
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

        }
    }
}
