﻿using System;

namespace CSharp_Number_Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                response = "";

                while (guess != number)
                {
                    Console.Write("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    
                    guesses++;

                }
                Console.WriteLine("\nNumber: " + number);
                Console.WriteLine("\nYOU WIN!");
                Console.WriteLine("\nGuesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N):");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }
                else if(response == "N")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("\nInvalid response! Exiting game.");
                    playAgain = false;
                }

            }

            Console.WriteLine("Thanks for playing! ... I guess\n\n\n\n");

            Console.ReadKey();
        }
    }
}
