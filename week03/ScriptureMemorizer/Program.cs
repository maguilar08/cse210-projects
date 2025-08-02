using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him,and he shall direct thy paths.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (scripture.IsCompletelyHidden())
                break;

            scripture.HideRandomWords(3); 
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());


    }
}