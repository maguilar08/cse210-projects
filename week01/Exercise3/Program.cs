using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello World! This is the Exercise3 Project.");*/
        /*
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);
        */

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {

            Console.Write("What is your guess? ");
           guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higuer");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        } 
    }
}