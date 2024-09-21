using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number to sum, type the number 0 to finish.");
        Console.WriteLine("Enter your first number");
        List<int> numbers = new List<int>();
        int numberValue = 0;
        int total = 0;
        double avg = 0;
        int max = 0;

        do {
            string value = Console.ReadLine();
            numberValue = int.Parse(value);
            numbers.Add(numberValue);
            Console.WriteLine("Enter your next number");
        }while(numberValue != 0);
        Console.WriteLine("Ok! We are done. Here important details:");
        Console.WriteLine($"Your entered numbers are:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
            total+=number;
        }
        Console.WriteLine($"The total sum of these numbers is {total}");
        avg = numbers.Average();
        Console.WriteLine($"The average of these numbers is {avg}");
        max = numbers.Max();
        Console.WriteLine($"The max number of these numbers is {max}");

    }
}