class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' recorded! +{Points} points.");
    }

    public override bool IsComplete() => false;
    public override string GetStatus() => "[∞]";
}