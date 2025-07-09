using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello World! This is the Exercise1 Project.");*/

        Console.Write("What is your First Name? ");
        string name = Console.ReadLine();

        Console.Write("What is your Last Name? ");
        string last_name = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine($"Your name is {last_name}, {name} {last_name}.");

    }
}