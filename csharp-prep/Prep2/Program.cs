using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage, please.");
        string percentage = Console.ReadLine();
        int gradePercentage = int.Parse(percentage);

        string grade = "";

        if (gradePercentage >= 90)
        {
            grade = "A";
        }
        else if (gradePercentage >=80)
        {
            grade = "B";
        }

        else if (gradePercentage >= 70)
        {
            grade = "C";
        }

        else if (gradePercentage >= 60)
        {
            grade = "D";
        }

        else {
            grade = "F";
        }

        Console.WriteLine($"Your grade for this semerster is {grade}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the semester");
        }
        else {
            Console.WriteLine("You need to improve to passed the semester");
        }
    }
}