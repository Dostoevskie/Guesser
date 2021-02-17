using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace guesser
{
    class Guesser
    {

        const string wordToGuess = "Giraffe";

        const int maxAttempts = 10;

        static void Main(string[] args)
        {
            
            int amountOfGuesses = 0;
            int countdownTimer = 5;


            // Introduction to the program
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("          ===================================================");
            Console.WriteLine("          | This program asks you to guess a string.        |");
            Console.WriteLine("          | You have a total of " + maxAttempts + " guesses to get it right. |");
            Console.WriteLine("          | Good luck!.                                     |");
            Console.WriteLine("          ===================================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            // Main
            while (true)
            {
                Console.WriteLine("Please make a guess: ");
                string guess = Console.ReadLine();

                amountOfGuesses++;

                // If the guess is right this runs
                if (guess == wordToGuess && amountOfGuesses < maxAttempts + 1)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("     O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O");
                    Console.WriteLine("     |                                         |");
                    Console.WriteLine("     |    AMAZING! You guessed the word! :D    |");
                    Console.WriteLine("     |                                         |");
                    Console.WriteLine("     O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Terminating application in: " + countdownTimer + " seconds");

                    // Countdown to program termination
                    while (true)
                    {
                        countdownTimer--;

                        Thread.Sleep(1000);

                        Console.WriteLine("");
                        Console.WriteLine("                            " + countdownTimer);

                        if (countdownTimer == 0)
                        {
                            Environment.Exit(0);
                        }
                    }
                }

                // If the guess is wrong this runs
                else if (guess != wordToGuess && amountOfGuesses < maxAttempts + 1)
                {
                    Console.Clear();
                    Console.WriteLine("===============================================");
                    Console.WriteLine("");
                    Console.WriteLine("Awww, you missed :( ");
                    Console.WriteLine("");
                    Console.WriteLine("You have " + (maxAttempts - amountOfGuesses) + " attempts left. Please try again.");
                    Console.WriteLine("");
                    Console.WriteLine("===============================================");
                }

                // This next 9 if statements are hints for each wrong answer

                if (guess != wordToGuess && amountOfGuesses == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         ----------------------------------------------------------------");
                    Console.WriteLine("         | HINT: The word you are looking for has a length of " + (wordToGuess.Length) + " letters |");
                    Console.WriteLine("         ----------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                if (guess != wordToGuess && amountOfGuesses == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         ---------------------------------------------------------------");
                    Console.WriteLine("         | HINT: The word you are looking for is the name of an animal |");
                    Console.WriteLine("         ---------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                if (guess != wordToGuess && amountOfGuesses == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         --------------------------------------------------------------");
                    Console.WriteLine("         | HINT: The animal you are looking for has spots on its body |");
                    Console.WriteLine("         --------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                if (guess != wordToGuess && amountOfGuesses == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         ----------------------------------------------------------");
                    Console.WriteLine("         | HINT: The animal you are looking for is fond of leaves |");
                    Console.WriteLine("         ----------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                if (guess != wordToGuess && amountOfGuesses == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         --------------------------------------------------");
                    Console.WriteLine("         | HINT: The animal you are looking for has horns |");
                    Console.WriteLine("         --------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                if (guess != wordToGuess && amountOfGuesses == 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         ---------------------------------------------------");
                    Console.WriteLine("         | HINT: The animal you are looking for has hooves |");
                    Console.WriteLine("         ---------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                if (guess != wordToGuess && amountOfGuesses == 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         ----------------------------------------------------------------");
                    Console.WriteLine("         | HINT: The animal you are looking for usually lives in africa |");
                    Console.WriteLine("         ----------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                if (guess != wordToGuess && amountOfGuesses == 8)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         ----------------------------------------------------------------------");
                    Console.WriteLine("         | HINT: The animal you are looking for has a weirdly colored toungue |");
                    Console.WriteLine("         ----------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                if (guess != wordToGuess && amountOfGuesses == 9)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("         -----------------------------------------------------");
                    Console.WriteLine("         | HINT: The animal you are looking for is very tall |");
                    Console.WriteLine("         -----------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }


                // If you run out of attempts this runs
                if (amountOfGuesses == maxAttempts + 1)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                 You did not manage to guess the word :(");
                    Console.WriteLine("");
                    Console.WriteLine("                                 You were looking for the word: " + wordToGuess);
                    Console.WriteLine("");
                    Console.WriteLine("                                 Thank you for playing!");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                 Terminating application in: " + countdownTimer + " seconds");


                    // Countdown to program termination
                    while (true)
                    {
                        countdownTimer--;

                        Thread.Sleep(1000);

                        Console.WriteLine("");
                        Console.WriteLine("                                                             " + countdownTimer);

                        if (countdownTimer == 0)
                        {
                            Environment.Exit(0);
                        }
                    }

                }

            }
        }
    }
}
