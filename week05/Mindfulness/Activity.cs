class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {Name}...");
        Console.WriteLine(Description);
        Console.Write("\nEnter duration (in seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nGreat job! You have completed the activity.");
        Console.WriteLine($"You spent {Duration} seconds in {Name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }
}
