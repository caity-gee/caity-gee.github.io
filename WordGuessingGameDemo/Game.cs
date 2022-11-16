using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessingGameDemo
{
    public class Game
    {
        //array to store our pool of words
        //store user input
        //target number
        //random numbers
        //let's declare a boolean that will be used to keep the loop running
        bool running = true;
        //add a var to store user input
        int guesses = 0;
        string guess;
        int target;
        //initialize the array and populate it with values
        string[] answerBankArray = new string[4] { "cat", "hat", "rat", "bat" };
        //we'll instantate a random number object
        Random randomNumber = new Random();

        public void Play()
        {

            while (running)
            {
                //let's pick a random number that will then reference an index position in our answerbankarray
                target = randomNumber.Next(answerBankArray.Length);
                //ask the player a question
                Console.WriteLine("Guess what word I'm thinking of...is it ");
                //creae a for loop to go through the array and output each of the values stored there
                for (int i = 0; i < answerBankArray.Length; i++)
                {
                    //conditional branching to format the output text
                    if (i == (answerBankArray.Length - 1))
                    {
                        Console.Write("or " + answerBankArray[i] + "? ");
                    }
                    else
                    {
                        Console.Write(answerBankArray[i] + ", ");
                    }
                }

                //store the user input
                guess = Console.ReadLine();
                //normalize the data
                guess = guess.ToLower();

                //now for the game logic
                if (guess == answerBankArray[target])
                {
                    guesses++;
                    Console.WriteLine("Congratulations! You guessed correctly.");
                    running = false;
                    Console.ReadLine();

                }
                else
                {
                    //incrementing guess after each guess
                    guesses++;
                    Console.WriteLine($"You guessed {guess}. That was incorrect.");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    Play();
                }
            }
            Console.WriteLine($"It took you {guesses} attempts to guess correctly.");
            Console.ReadKey();
        }
    }
}
