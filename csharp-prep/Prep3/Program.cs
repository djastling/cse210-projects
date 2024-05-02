using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,10);
        int guess;
        int count = 0;

        do {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if (number > guess) {
                Console.WriteLine("Higher");
            }
            else if (number < guess) {
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guess the number!");
            }
            count++;
        }
        while (number != guess);
        Console.Write($"It took you {count} guesses to get the number.");
    }
}