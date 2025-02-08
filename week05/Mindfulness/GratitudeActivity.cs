class GratitudeActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "What is something you are grateful for today?",
        "Name a person who has made a positive impact on your life.",
        "What is an opportunity you are thankful for?",
        "List a simple pleasure that brings you joy.",
        "What is a personal strength you are grateful for?"
    };

    public GratitudeActivity() : base("Gratitude Activity", "This activity helps you express gratitude and appreciate the positives in your life.") { }

    public void Run()
    {
        Start();
        Random random = new Random();
        Console.WriteLine($"\n{Prompts[random.Next(Prompts.Count)]}\n");
        ShowCountdown(3);

        List<string> responses = new List<string>();
        int timeSpent = 0;

        while (timeSpent < Duration)
        {
            Console.Write("Write something you are grateful for: ");
            responses.Add(Console.ReadLine());
            timeSpent += 5;
        }

        Console.WriteLine($"\nYou listed {responses.Count} things you are grateful for!");
        End();
    }
}
