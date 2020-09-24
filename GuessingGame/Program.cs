using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);

            Console.WriteLine("Enter a number from 1 to 10.");
            int userNumber = Int32.Parse(Console.ReadLine());
            bool guessState = false;

            while (!guessState)
            {
                if (randomNumber == userNumber)
                {
                    Console.WriteLine("You won!");
                    guessState = true;
                }
                else
                {
                    Console.WriteLine("Try again! Enter a number from 1 to 10.");
                    userNumber = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}
