using System;

public class BreathingActivity: Activity{

    public  BreathingActivity(string name, string description, int duration) : base(name, description, duration){
    }

    public void GetStartingMessage(){
        DisplayStartingMessage();
    }

    public void Run(){  

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Get ready...");
        ShowSpinner(500);
        Console.WriteLine();
        Console.WriteLine();

        while (DateTime.Now < endTime){
            Console.Write("Breath in...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.WriteLine();
        }   
        Console.WriteLine("Well done!!");
        ShowSpinner(500);
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(500);
        Console.Clear();
    }
}