using System;

class Program
{
    static void Main(string[] args)
    {
    /*Beginning of the program, greeting and menu options*/
       Console.WriteLine("Welcome to the Journal Program!");
       Menu_Option option1 = new Menu_Option(); 
       Menu_Option option2 = new Menu_Option(); 
       Menu_Option option3 = new Menu_Option(); 
       Menu_Option option4 = new Menu_Option(); 
       Menu_Option option5 = new Menu_Option(); 

       option1._menuOption = "Write";
       option2._menuOption = "Display";
       option3._menuOption = "Load";
       option4._menuOption = "Save";
       option5._menuOption = "Quit";

       
       PromptGenerator prompt = new PromptGenerator();
       prompt._invitationProgram = "Please select one of the following choices(The Number only please): ";
       prompt._menuOptions.Add(option1);
       prompt._menuOptions.Add(option2);
       prompt._menuOptions.Add(option3);
       prompt._menuOptions.Add(option4);
       prompt._menuOptions.Add(option5);

       prompt._invitationQuestion = "What would you like to do? ";
       prompt.greetingAndMenu();
       

        /*Adding the random questions for the user*/
        PromptGenerator addingQuestion1 = new PromptGenerator();
        PromptGenerator addingQuestion2 = new PromptGenerator();
        PromptGenerator addingQuestion3 = new PromptGenerator();
        PromptGenerator addingQuestion4 = new PromptGenerator();
        PromptGenerator addingQuestion5 = new PromptGenerator();

        addingQuestion1._journalQuestion = "Who was the most interesting person I interacted with today?";
        addingQuestion2._journalQuestion = "What was the best part of my day?";
        addingQuestion3._journalQuestion = "What did I learn today in 'Come follow me'?";
        addingQuestion4._journalQuestion = "If I had one thing I could do over today, what would it be?";
        addingQuestion5._journalQuestion = "What did I joy most in my last visit at the Temple?";

        /*Adding the random questions to a list*/
        prompt._journalQuestions.Add(addingQuestion1);
        prompt._journalQuestions.Add(addingQuestion2);
        prompt._journalQuestions.Add(addingQuestion3);
        prompt._journalQuestions.Add(addingQuestion4);
        prompt._journalQuestions.Add(addingQuestion5);

     

        /*Getting the option type by the user*/
        prompt.gettingOption();

        /*Adding user entries*/

    }
}