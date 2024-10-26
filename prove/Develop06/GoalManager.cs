using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    List<string> _menuOptions = new List<string>
    {
        "1.Create New Goal",
        "2.List Goals ",
        "3.Save Goals",
        "4.Load Goals",
        "5.Record Event",
        "6.Quit"
    };

    List<string> _createGoalOptions = new List<string>
    {
        "1.Simple Goal",
        "2.Eternal Goal",
        "3.Checklist Goal",
    };

    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        while(true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options: ");
            foreach (var option in _menuOptions)
            {
                Console.WriteLine($"{option}");
            }

            Console.Write("\nSelect a choice from the menu: ");
            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoalDetails();
                    break;

                case"3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid option! Try again please.");
                    break;
            }
        }
      
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        int count = 1;
        foreach (var goalName in _goals)
        {
            
            Console.WriteLine($"{count}. {goalName.GetName()}");
            count+=1;
        }
    }

    public void ListGoalDetails()
    {
        int count = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{count}. [{(goal.IsComplete() ? "X": "")}] {goal.GetDetailsString()}");
            count += 1;
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine($"The types of goals are: ");
        foreach (var type in _createGoalOptions)
        {
            Console.WriteLine($"{type}");
        }
        Console.Write("Which type of goal would you like to create? ");
        string createGoalChoice = Console.ReadLine();
        Console.WriteLine();
        
        switch(createGoalChoice)
        {
            case"1":

            Console.Write("What is the name of your goal? ");
            string name1 = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description1 = Console.ReadLine();
            Console.Write("What us the amount of points associated with this goal? ");
            string points1 = Console.ReadLine();
            
            SimpleGoal simpleGoal = new SimpleGoal(name1, description1, points1);
            _goals.Add(simpleGoal);

            break;

            case"2":

            Console.Write("What is the name of your goal? ");
            string name2 = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description2 = Console.ReadLine();
            Console.Write("What us the amount of points associated with this goal? ");
            string points2 = Console.ReadLine();

            EternalGoal EternalGoal = new EternalGoal(name2, description2, points2);
            _goals.Add(EternalGoal);

            break;

            case"3":

            Console.Write("What is the name of your goal? ");
            string name3 = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description3 = Console.ReadLine();
            Console.Write("What us the amount of points associated with this goal? ");
            string points3 = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished to bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the point bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoal checkListGoal = new CheckListGoal (name3, description3, points3, target, bonus);
            _goals.Add(checkListGoal);

            break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("What goal did you accomplish? ");
        int goalAccomplished = int.Parse(Console.ReadLine());

        _goals[goalAccomplished - 1].RecordEvent();

        Console.WriteLine();
        int pointsEarned = int.Parse(_goals[goalAccomplished - 1].GetPoints());
        _score +=pointsEarned;
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName =  Console.ReadLine();
        Console.WriteLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            for (int i = 0; i < _goals.Count; i++)
            {
                outputFile.WriteLine($"{_goals[i].GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (var line in lines)
        {
            string [] parts = line.Split(",");

            if(parts.Length >= 2)
            {
                string firtPart = parts[0];
                string secondPart = parts[1];
            }
          
        }
    }
}