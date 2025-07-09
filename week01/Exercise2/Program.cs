using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello World! This is the Exercise2 Project.");*/

        Console.Write("What´s your grade percentage? ");
        string grade = Console.ReadLine();
        int percentageGrade = int.Parse(grade);
        /*
        if (percentageGrade >= 90)
        {
            Console.WriteLine("Your grade is A. ");
            Console.WriteLine("Congrgatulations keep on it");
        }
        else if (percentageGrade >= 80)
        {
            Console.WriteLine("Your grade is B. ");
            Console.WriteLine("Congrgatulations keep on it");
        }
        else if (percentageGrade >= 70)
        {
            Console.WriteLine("Your grade is C. ");
            Console.WriteLine("Congrgatulations keep on it");
        }
        else if (percentageGrade >= 60)
        {
            Console.WriteLine("Your grade is D. ");
            Console.WriteLine("Don't worry, you'll get it next time. Keep trying!");
        }
        else 
        {
            Console.WriteLine("Your grade is F. ");
            Console.WriteLine("Don't worry, you'll get it next time. Keep trying!");
        }
        */
        /*------------------------------------------------------------------------------*/

        String letter = "";

        if (percentageGrade >= 90)
        {
            letter = "A";
        }
        else if (percentageGrade >= 80)
        {
            letter = "B";
        }
        else if (percentageGrade >= 70)
        {
            letter = "C";
        }
        else if (percentageGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (percentageGrade >= 60)
        {
            Console.WriteLine("Congratulations you passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}