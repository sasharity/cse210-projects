using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int square = SquareNumber(usernumber);
        Console.WriteLine($"{username}, the square of your number is {square}");

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your username?");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your User Number?");
        int usernumber = int.Parse(Console.ReadLine());
        return usernumber;
    }

    static int SquareNumber(int usernumber)
    {
        int square = usernumber * usernumber;
        return square;
    }
}