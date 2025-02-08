class ListingActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity helps you list positive aspects of life.") { }

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
            Console.Write("Enter an item: ");
            responses.Add(Console.ReadLine());
            timeSpent += 5;
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        End();
    }
}