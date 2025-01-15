using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string grade = Console.ReadLine();
        int the_grade = int.Parse(grade);
        string letter = "";
        if (the_grade >= 90)
        {
            letter = "A";
        }
        else if (the_grade >= 80)
        {
            letter = "B";
        }
        else if (the_grade >= 70)
        {
            letter = "C";
        }
        else if (the_grade >= 60)
        {
            letter = "D";
        }
        else if (the_grade < 60)
        {
            letter = "F";
        }    
        
        Console.WriteLine($"Your grade is {letter}");

        if (the_grade >= 70)
        {
            Console.WriteLine($"You passed the course");
        }
        else
        {
            Console.WriteLine($"You did not pass the course. Try harder next time");
        }
    }
}
