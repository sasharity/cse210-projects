using System;

class Program
{
    static void Main(string[] args)
    {
        // //For Number 1 and 2 core requirements
        // Console.Write("What is the magic number?"); 
        // string entered_number = Console.ReadLine();
        // int magic_number = int.Parse(entered_number);

        // For Number 3 core requirement,
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,100);

        int guess= -1;
        while (guess != magic_number)
        {
            Console.Write("What is your guess?"); 
            string entered_guess = Console.ReadLine();
            guess = int.Parse(entered_guess);
            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it");
            }
        }
        
        
    }
}