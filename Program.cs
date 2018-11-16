using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {

        static void Main(string[] args)
        {
            getAppInfo(); //show the app info

            greetUser(); //greet the user

            while (true)
            {

                // create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {

                    //get user's input
                    string input = Console.ReadLine();

                    //check if input is a number 
                    if (!int.TryParse(input, out guess))
                    {
                        //show error message
                        printColorMessage(ConsoleColor.Red, "Please input  an actual number...");
                        continue;

                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {                      

                        //show error message
                        printColorMessage(ConsoleColor.Red, "Wrong number, please try again...");

                    }
                }

               //print success message
                printColorMessage(ConsoleColor.Green, "Good guess, Congrats!");

                //Ask if the user wants to play again
                Console.WriteLine("Play again? [Y or N]");

                //get the answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
                
               // Console.Read();
            }
        }

        static void getAppInfo()  {
             /// set vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Amalya Avagimyan";

            //Change the font color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //show app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //set coor back to default
            Console.ResetColor();
        }

        static void greetUser()
        {
            //ask user's name
            Console.WriteLine("What is your name?");

            //get user's input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's start the game...", inputName);
        }

        static void printColorMessage(ConsoleColor  color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
