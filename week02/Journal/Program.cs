using System;
using System.Data;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userInput = "";

        while (userInput != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the Journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Chose an option: ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            if (userInput == "1")
            {
                string prompt = promptGenerator.GetRandomPromt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                Console.Write("P.S.: ");
                string postscript = Console.ReadLine();
                Entry entry = new Entry(date, prompt, response, postscript);
                journal.AddEntry(entry);
                Console.WriteLine("---------------Entry Added---------------");
            }
            else if (userInput == "2")
            {
                journal.DisplayAll();
                Console.WriteLine("---------------My Journal---------------");
            }
            else if (userInput == "3")
            {
                Console.Write("Enter filename to save: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("---------------Journal Saved---------------");
            }
            else if (userInput == "4")
            {
                Console.Write("Enter filename to load the journal: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("---------------Journal Loaded---------------");
            }
            else if (userInput == "5")
            {
                Console.WriteLine("---------------Have a good day!---------------");
            }
            else
            {
                Console.WriteLine("---------------!!Invalid Option!!---------------");
            }    
        }
    }
}