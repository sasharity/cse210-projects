using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_number = -1;
        while (user_number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when done.");
            Console.Write("Enter a number:");
            string list_numbers = Console.ReadLine();
            user_number = int.Parse(list_numbers);

            if (user_number != 0)
            {
                numbers.Add (user_number);
            }
            // else
            // {
            //     Console.WriteLine($"The sum is {sum}");
            // }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");

        float average = ((float) sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");
        
        int largest_number = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest_number)
            largest_number = number;
        }
        Console.WriteLine($"The largest number is {largest_number}");   
    }
}