using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        Console.WriteLine($"The name of the user is {userName}");

        int userNumber = PromptUserNumber();
        Console.WriteLine($"The favorite number of the user is {userNumber}");

        int squaredNumber = SquareNumber(userNumber);
        Console.WriteLine($"The square of the favorite number of the user is {squaredNumber}");

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter your name, please.");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number, please.");
        string value = Console.ReadLine();
        int userNumber = int.Parse(value);
        return userNumber;
    }

    static int SquareNumber(int number)
    {
         int SquareNumber = number * number;
         return SquareNumber;
    }

    static void DisplayResult(string userName, int userNumber)
    {
        Console.WriteLine($"Brother {userName} the square of your favorite number is {userNumber}");
    }

}