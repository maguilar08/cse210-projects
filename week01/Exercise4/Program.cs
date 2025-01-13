using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        
        int number = -1;
        while (number !=0)
        {
            Console.Write("Enter a number (Type 0 to quit): ");
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);

            if (number !=0)
            {
                numbers.Add(number);
            } 
        }

        int sum = 0;
        foreach (int numero in numbers)
        {
            sum += numero;
        }
        Console.WriteLine($"The Sume is {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int max = numbers[0];

        foreach (int numero in numbers)
        {
            if (numero> max)
            {
                max = numero;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}