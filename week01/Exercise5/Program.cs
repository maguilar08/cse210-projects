using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }
     static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int favoriteNumber)
    {
        int squereNumber = favoriteNumber * favoriteNumber;
        return squereNumber;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name},  the square of your number is {squareNumber}");
    }

}