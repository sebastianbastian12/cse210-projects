using System;

public class PromptGenerator
{

    public string _invitationProgram = "";
    public string _invitationQuestion = "";
    public string _journalQuestion = "";

    public List<PromptGenerator> _journalQuestions = new List<PromptGenerator>();
    public List<Menu_Option> _menuOptions = new List<Menu_Option>();
    public List<Entry> _userEntries = new List<Entry>();

    public void greetingAndMenu()
    {
        Console.WriteLine($"{_invitationProgram}");
        
        int count = 1;
        foreach (var option in _menuOptions)
        {
            Console.Write($"{count}");
            option.DisplayingMenuOptions();
            count++;
        }

        Console.Write($"{_invitationQuestion}");
    }

    public void gettingOption()
    {

        string chosenOption = Console.ReadLine();
        Journal journal = new Journal();
        if (chosenOption == "1")
        {
            string _currentDate = DateTime.Now.ToString("MM/dd/yyyy");

            Random randomQuestion = new Random();
            int _randomIndex = randomQuestion.Next(0, 5);
            string _question = _journalQuestions[_randomIndex]._journalQuestion;
            Console.WriteLine($"{_question}");


            string _userEntry = Console.ReadLine();

            Entry entry = new Entry();
            entry._date = _currentDate;
            entry._promptText = _question;
            entry._entryText = _userEntry;

            _userEntries.Add(entry);

            
            journal.AddEntry(_userEntries);
           
            greetingAndMenu();
            gettingOption();
        }

        else if (chosenOption == "2")
        {   
            journal._userEntries = _userEntries;
            journal.DisplayAll();
            greetingAndMenu();
            gettingOption();
        }

        else if (chosenOption == "3")
        {
            Console.Write("What is the filename? ");
            string _loadFile = Console.ReadLine();
            journal.LoadFromFile(_loadFile);

            greetingAndMenu();
            gettingOption();
        }

        else if (chosenOption == "4")
        {
            journal.AddEntry(_userEntries);
            Console.Write("Enter the name of the file: ");
            string _saveFile = Console.ReadLine();
            journal.SaveToFile(_saveFile);
            greetingAndMenu();
            gettingOption();
        }

        else if (chosenOption == "5")
        {
            Console.Write("Have a nice day!");
        }

        else
        {
            Console.WriteLine("Wrong option, try again.");
            greetingAndMenu();
            gettingOption();
        }
    }
}