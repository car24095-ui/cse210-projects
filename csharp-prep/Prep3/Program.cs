using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random magic = new Random();
        int number = magic.Next(1, 101);

        int guess = 101;
        while (guess != number)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
        }
        
        Console.WriteLine("You guessed it!");

    }
}