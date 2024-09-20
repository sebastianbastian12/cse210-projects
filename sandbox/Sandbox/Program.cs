using System;

class Program
{
    static void Main(string[] args)
    {
        /*Printing information in the console*/
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is in C#.");

        /*Declaring variables with their data types*/
        int a = 5;
        int b = 6;
        string name = "Pepito Perez";
        Console.WriteLine($"The sum is {a + b}");
        Console.WriteLine($"My name os {name}");

        /*If statements*/
        if (b > a)
        {
            Console.WriteLine("Is major");
        }

        /*Inputs in C#*/
        Console.WriteLine("Enter your name please");
        string yourName = Console.ReadLine();
        Console.WriteLine($"Your name is {yourName}");

    }
}