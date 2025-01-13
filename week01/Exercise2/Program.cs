using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();
        int grade =int.Parse(number);

        /*

        // CORE REQUIREMENTS
        
        //1.
        if (grade >= 90)
            Console.WriteLine($"You have A on your grade.");
        else if (grade >= 80)
            Console.WriteLine($"You have B on your grade.");
        else if (grade >= 70)
            Console.WriteLine($"You have C on your grade.");
        else if (grade >= 60)
            Console.WriteLine($"You have D on your grade.");
        else if (grade < 60)
            Console.WriteLine($"You have F on your grade.");

        //2.
        if (grade >= 70)
            Console.WriteLine("Congratulations you passed the course.");
        else
            Console.WriteLine("You didn´t pass the course. Don't be discouraged! Every challenge is an opportunity to learn and grow."); 
        
        */

        //3.
        string letter = "";

        if (grade >= 90)
            letter = "A";
        
        else if (grade >= 80)
            letter = "B";
        
        else if (grade >= 70)
            letter = "C";
        
        else if (grade >= 60)
            letter = "D";

        else if (grade < 60)
            letter = "F";

        Console.WriteLine($"You grade is {letter}.");

        if (grade >= 70)
            Console.WriteLine("Congratulations you passed the course.");
        else
            Console.WriteLine("You didn´t pass the course.");

    }
}