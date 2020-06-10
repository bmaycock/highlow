using System;
using System.ComponentModel;

namespace High_Low
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 1 and 10. Try and guess it within the lowest amount of guesses.");
            int guess = 0;
            int tries = 1;
            int num = rand.Next(1, 11);
            while (guess != num)
            {
                Console.WriteLine("Please guess a number between 1 and 10: ");
                guess = int.Parse(Console.ReadLine());
                if (guess > num)
                {
                    Console.WriteLine("Lower.");
                    tries = (tries + 1);
                }
                else if (guess < num)
                {
                    Console.WriteLine("Higher.");
                    tries = (tries + 1);
                }
                else
                {
                    Console.WriteLine("Correct!");
                }
            }
            Console.WriteLine("It took "+tries+" guesses to get the correct answer");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }

    }
}
