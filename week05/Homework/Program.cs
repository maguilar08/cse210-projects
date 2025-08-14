using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment firstOne = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(firstOne.GetSummary() + "\n");

        MathAssignment second = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(second.GetSummary());
        Console.WriteLine(second.GetHomeworkList() + "\n");

        WritingAssignment third = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(third.GetSummary());
        Console.WriteLine(third.GetWritingInformation() + "\n");
    }
}