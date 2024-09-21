using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,101);
        Console.WriteLine($"The magic is {magicNumber}");
        int guessedNumber = 0;

       do {
            Console.WriteLine("What is the magic number?");
            string Number = Console.ReadLine();
            guessedNumber = int.Parse(Number);

            if (guessedNumber == magicNumber)
            {
                Console.WriteLine("Great! You guessed.");
            }
            else if (guessedNumber > magicNumber)
            {
                Console.WriteLine("Lower than this.");
            }
            else
            {
                Console.WriteLine("Higher than this.");
            }
        } while(guessedNumber != magicNumber);    
    }
}