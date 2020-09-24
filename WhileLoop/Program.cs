using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 11);

            Console.WriteLine("Enter a number from 1 to 10.");
            int userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber == randomNumber)
            {
                Console.WriteLine($"You guessed the number. It was {randomNumber}");
            }
            else
            {
                Console.WriteLine($"You didn't guess the number. It was {randomNumber}, not {userNumber}.");
            }
        }
    }
}
