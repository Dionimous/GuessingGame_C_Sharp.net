using System;

namespace GuessingGame
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Developer Information
            getAppInfo();
            
            
            // User Info
            Console.WriteLine("What's your name: ");
            // Get User Name
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + ". Ready to play");
            
            while (true)
            {
                // Game Build
                Random random = new Random();
                int winningNumber = random.Next(1, 5);
                // UserGuessNumber
                int userGuessNumber = 0;
                // Ask User for number
                Console.WriteLine("Guess a number between 1 thur 5");
                while ( userGuessNumber != winningNumber)
                {
                    string userInputNumber = Console.ReadLine();
                
                    // userGuessNumber = Int32.Parse(userInputNumber);
                    if (!int.TryParse(userInputNumber, out userGuessNumber))
                    {
                        Console.WriteLine("Numbers only");
                    }

                    if (userGuessNumber != winningNumber)
                    {
                        Console.WriteLine(userGuessNumber + ", is not, Guess again");
                    }
                    else
                    {
                        Console.WriteLine("Win");
                    }
                }
                // Continue Playing
                Console.WriteLine("Play Again?, 'Y' Or 'N'");

                string userAnswer = Console.ReadLine().ToUpper();
                
                if (userAnswer.Equals("Y"))
                {
                    continue;
                }
                else if(userAnswer.Equals("N"))
                {
                    Console.WriteLine("Thanks for playing");
                    break;
                }
            }
        }

        static void getAppInfo()
        {
            // Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dion Ramos";
            
            // Cool Green Inform
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            // Info About the App
            Console.WriteLine(appName + ", version " + appVersion +
                              " and develop by " + appAuthor);
            // Reset Console Color
            Console.ResetColor();
        }
    }
}