using System;
using System.Collections.Generic;

public class ListingActivity: Activity{

    private int _count = 1;
    List<string> _prompts = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    List<string> _userEntries = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void GetStartingMessage()
    {
        DisplayStartingMessage();
    }

    public void Run()
    {
      
        Console.WriteLine("Get ready...");
        ShowSpinner(500);
        Console.WriteLine("\n List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(1000);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }

        Console.WriteLine($"You listed {_userEntries.Count} items!");
        Console.Write("Do you want to see your records? 'Yes/No' ");
        
        string response = Console.ReadLine();
       
        if (response == "Yes" || response == "yes" || response == "YES"){
            Console.WriteLine("\nYour records:");
            showUserEntries();
        }

        else{
            Console.WriteLine("Ok! :)");
        }
        Console.WriteLine("\nWell done!!");
        ShowSpinner(1000);
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(500);
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        string randomPrompt = _prompts[i];
        Console.WriteLine($"---{randomPrompt}.---");
    }

    public List<string> GetListFromUser()
    {
        Console.Write(">");
        string userEntry = Console.ReadLine();
        _userEntries.Add(userEntry);
        return _userEntries;
    }

    public void showUserEntries(){
        foreach (var entry in _userEntries)
        {
            Console.WriteLine($"{_count}. {entry}");
            _count+=1;
        }
        _count = 1;
    }
}
