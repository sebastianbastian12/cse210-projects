using System;
using System.Collections.Generic;

 public class Activity{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write($"\nHow long, in seconds, would you like for your session? ");

        string chosenTime = Console.ReadLine();
        _duration = int.Parse(chosenTime);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed the {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds){
        List<string> spinnerCharacters = new List<string>{ "|" , "/", "-", "\\", "|", "/", "-", "\\"};


        foreach (string character in spinnerCharacters)
        {
            Console.Write(character);
            Thread.Sleep(seconds);
            Console.Write("\b \b"); 
        }    
    } 

    public void ShowCountDown(int seconds){

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
    }
}