using System;

namespace Guess_A_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess A Number (1 - 100): ");
            int number = int.Parse(Console.ReadLine());

            Random randomNumber = new Random();
            int rndNum = randomNumber.Next(1, 100);

            while (rndNum != number)
            {
                if (rndNum > number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("Guess A Number (1 - 100): ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!");
        }
    }
}
