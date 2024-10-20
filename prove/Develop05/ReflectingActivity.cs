using System;
using System.Collections.Generic;

public class ReflectingActivity: Activity{
    public List<string> _prompts = new List<string>
    {   
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless." };
    public List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"};

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    Random random = new Random();
    public void GetStartingMessage(){
        DisplayStartingMessage();
    }

    public void Run(){

        Console.WriteLine("Get ready...");
        ShowSpinner(500);
        Console.WriteLine();
        DisplayPrompt();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each one of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        ShowCountDown(1000);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(1000);
            Console.WriteLine();
        }

        Console.WriteLine("\nWell done!!");
        ShowSpinner(500);
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(500);
        Console.Clear();
    }

    public string GetRandomPrompt(){
        
        int i = random.Next(_prompts.Count);
        string randomPrompt = _prompts[i];
        return $"Consider the following prompt:\n ---{randomPrompt}.---\nWhen you have something in mind, press enter to continue.";
    }

    public void DisplayPrompt(){
        Console.WriteLine(GetRandomPrompt());
    }

    public string GetRandomQuestion(){
        int j = random.Next(_questions.Count);
        string randomQuestion = _questions[j];
        return $"> {randomQuestion}";
    }
       
    public void DisplayQuestions(){
        Console.Write(GetRandomQuestion());
    }
}