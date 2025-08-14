using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from menu: ");
            string choice = Console.ReadLine();

            // This is enough if we don´t add the counter
            // if (choice == "1")
            //     new BreathingActivity().Run();
            // else if (choice == "2")
            //     new ListingActivity().Run();
            // else if (choice == "3")
            //     new ReflectingActivity().Run();
            // else if (choice == "4")
            //     break;

            if (choice == "1")
                breathingActivity.Run();
            else if (choice == "2")
                reflectingActivity.Run();
            else if (choice == "3")
                listingActivity.Run();
            else if (choice == "4")
                break;
        }
        Console.WriteLine($"- Breathing Activity was performed {breathingActivity.GetTimesPerformed()} times.");
        Console.WriteLine($"- Reflecting Activity was performed {reflectingActivity.GetTimesPerformed()} times.");
        Console.WriteLine($"- Listing Activity was performed {listingActivity.GetTimesPerformed()} times.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}