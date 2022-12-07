using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    internal class TempatureConverter
    {
        public static void tempatureConverter() //Done //do conversion between tempature types
        {
            Console.WriteLine("Choose conversion type:\nCelcius to Kelvin (1)\nCelcius to Fahrenheit (2)\nFahrenheit to Kelvin (3)\nFahrenheit to Celcius (4)\nKelvin to Celcius (5)\nKelvin to Fahrenheit (6)\r\n");
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
                    tempatureConverterReturnedValue = (float)((tempatureConverterInputValue * 1.8) + 32);
                    Console.WriteLine(tempatureConverterInputValue + " celcius = " + tempatureConverterReturnedValue + " Fahrenheit");
                    break;
                case "3":
                    Console.WriteLine("Enter the Fahrenheit value: ");
                    tempatureConverterInputValue = float.Parse(Console.ReadLine());
                    tempatureConverterReturnedValue = (float)((tempatureConverterInputValue - 32) * 5 / 9 + 273.15);
                    Console.WriteLine(tempatureConverterInputValue + " fahrenheit = " + tempatureConverterReturnedValue + " Kelvin");
                    break;
                case "4":
                    Console.WriteLine("Enter the Fahrenheit value: ");
                    tempatureConverterInputValue = float.Parse(Console.ReadLine());
                    tempatureConverterReturnedValue = (float)((tempatureConverterInputValue - 32) * 5 / 9);
                    Console.WriteLine(tempatureConverterInputValue + " fahrenheit = " + tempatureConverterReturnedValue + " celcius");
                    break;
                case "5":
                    Console.WriteLine("Enter the Kelvin value: ");
                    tempatureConverterInputValue = float.Parse(Console.ReadLine());
                    tempatureConverterReturnedValue = (float)(tempatureConverterInputValue - 273.15);
                    Console.WriteLine(tempatureConverterInputValue + " Kelvin = " + tempatureConverterReturnedValue + " celcius");
                    break;
                case "6":
                    Console.WriteLine("Enter the Kelvin value: ");
                    tempatureConverterInputValue = float.Parse(Console.ReadLine());
                    tempatureConverterReturnedValue = (float)((tempatureConverterInputValue - 273.15) * 9 / 5 + 32);
                    Console.WriteLine(tempatureConverterInputValue + " Kelvin = " + tempatureConverterReturnedValue + " Fahrenheit");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
