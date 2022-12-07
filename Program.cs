using FirstSteps;

namespace FirstStepsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! \r\nTo Play Higher or Lower type in 1 \r\nTo Use Calculator type in 2 \r\nTo Play FizzBuzz type in 3 \r\nTo Learn how old you are in seconds type in 4 \r\nTo use Name Generator type in 5 \r\nTo see the answers of project euler type in  6\r\nTo Play Rock Paper Scissors type in 7 \r\nTo use TempatureConverter type in 8 \r\n");
            string whatToPlay = Console.ReadLine();
            switch (whatToPlay)
            {
                case "1":
                    HigherOrLower.HigherOrLowerGame();
                    break;
                case "2":
                    FourOperatorCalculator.fourWayCalculator();
                    break;
                case "3":
                    FizzBuzz.fizzBuzz();
                    break;
                case "4":
                    CalculateAgeInSeconds.calculateAgeInSeconds();
                    break;
                case "5":
                    NameGenerator.nameGenerator();
                    break;
                case "6":
                    ProjectEuler.projectEuler();
                    break;
                case "7":
                    RockPaperScissors.rockPaperScissors();
                    break;
                case "8":
                    TempatureConverter.tempatureConverter();
                    break;
            }
        }    
        
    }
}
