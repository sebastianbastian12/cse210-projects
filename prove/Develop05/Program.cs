using System;

class Program
{
    static void Main(string[] args)
    {
       
     BreathingActivity breathingActivity1 = new BreathingActivity("Breathing activity", 
     "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", 0);


    ReflectingActivity reflectingActivity1 = new ReflectingActivity("Reflecting Activity",
    "This acitvity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in the other aspects of your life.", 0);

    ListingActivity listingActivity1 =  new ListingActivity("Listing Activity",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);

    Menu menu = new Menu(breathingActivity1, reflectingActivity1, listingActivity1);
    menu.MenuOptions();

    }
}