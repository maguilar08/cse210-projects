using System;

class Program
{   
    //Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber( number);
        DisplayResult(name, squareNumber);
    }

    //DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number =int.Parse(Console.ReadLine());
        return number;
    }

    //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber( int number)
    {
        int squareNumber = number * number ;   
        return squareNumber;
    }

    //DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {squareNumber}");
    }
}