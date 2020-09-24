using System;

namespace ThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomnum = rnd.Next(1, 11);
            int userinput;
            int counter = 0;

            while (counter < 3)
            {
                Console.WriteLine("what is my number");
                userinput = Int32.Parse(Console.ReadLine());

                if (randomnum == userinput)
                {
                    Console.WriteLine("you won");
                    break;
                }
                else
                {
                    Console.WriteLine("try again");
                    counter = counter + 1;
                }


            }

        }
    }
}