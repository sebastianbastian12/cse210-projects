using System;

public class Menu {

    private BreathingActivity _breathingActivity;
    private ReflectingActivity _reflectingActivity;
    private ListingActivity _listingActivity;

    public Menu(BreathingActivity breathingActivity, ReflectingActivity reflectingActivity, ListingActivity listingActivity){
        _breathingActivity = breathingActivity;
        _reflectingActivity = reflectingActivity;
        _listingActivity = listingActivity;
    }

    public void MenuOptions(){

    while(true){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write($"Select a choice from the menu: ");
            string choice = Console.ReadLine();
        

        switch(choice){
            case "1":
            _breathingActivity.GetStartingMessage();
            _breathingActivity.Run();
            break;

            case "2":
            _reflectingActivity.GetStartingMessage();
            _reflectingActivity.Run();
            break;

            case "3":
            _listingActivity.GetStartingMessage();
            _listingActivity.Run();
                break;

            case "4":
                return;
            
            default:
                Console.Clear();
                Console.WriteLine("Invalid option! Try Again please.\n");
                break;
            }
        }
    }
}