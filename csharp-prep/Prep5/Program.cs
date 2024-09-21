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
        Console.WriteLine($"The favorite number of the user squared is {squaredNumber}");

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
        Console.WriteLine("Enter your number, please.");
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
        Console.WriteLine($"The name of the user {userName} and squared favorite user's number {userNumber}");
    }

}