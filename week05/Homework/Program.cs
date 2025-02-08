using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Iruoghene Omarayeirue", "Programming With Class");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Iruoghene Omarayeirue", "MAthematics", "Sec 8.5", "4-6");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Iruoghene Omarayeirue", "Writing", "Comprehension");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}

