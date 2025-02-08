class ReflectionActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity helps you reflect on past experiences where you showed strength.") { }

    public void Run()
    {
        Start();
        Random random = new Random();
        Console.WriteLine($"\n{Prompts[random.Next(Prompts.Count)]}\n");
        ShowSpinner(3);

        int timeSpent = 0;
        while (timeSpent < Duration)
        {
            Console.WriteLine(Questions[random.Next(Questions.Count)]);
            ShowSpinner(5);
            timeSpent += 5;
        }
        End();
    }
}