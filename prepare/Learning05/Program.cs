using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Pepito Perez", "Astrophysics");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("Fernando Sorio", "Differential Calculus", "7.3", "8-19" );
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Bernardo Roncancio", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment1.GetWritingInformation());


    }
}