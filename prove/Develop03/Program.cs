using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> _scripture = new List<Scripture>();

        Reference reference = new Reference("Nephi 1", 3, 7);
        
        Scripture scripture = new Scripture(reference, "7 And it came to pass that I, Nephi, said unto my father: I \n will go and do the things which the Lord hath commanded, \n for I know that the Lord giveth no commandments unto the \n children of men, save he shall prepare a way for them that \n they may accomplish the thing which he commandeth them.");


        Reference reference2 = new Reference("DyC", 4, 3, 4);

        Scripture scripture2 = new Scripture(reference2, " 3 Therefore, if ye have desires to serve God ye are called to the work; \n 4 For behold the field is white already to harvest; and lo, he \n that thrusteth in his sickle with his might, the same layeth up \n in store that he perisheth not, but bringeth salvation to his \n soul;");


        _scripture.Add(scripture);
        _scripture.Add(scripture2);

        Random randomScripture = new Random();
        int i = randomScripture.Next(0,2);
        Scripture chosenScripture = _scripture[i];
        Console.WriteLine(chosenScripture.GetDisplayString());

        while (!chosenScripture.IsCompletelyHidden())
        {   
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string enter = Console.ReadLine();
            

            if (enter.ToLower() == "quit")
            {
                break;
            }

            chosenScripture.HideRandomWords(4);
            Console.Clear();
            Console.WriteLine(chosenScripture.GetDisplayString());
            chosenScripture.IsCompletelyHidden();
        }

        if(chosenScripture.IsCompletelyHidden()){
            Console.WriteLine("All words have been hidden");
        }

    }
}