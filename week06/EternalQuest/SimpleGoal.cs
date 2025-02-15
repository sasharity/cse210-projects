class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        completed = false;
    }

    public override void RecordEvent()
    {
        completed = true;
        Console.WriteLine($"Goal '{Name}' completed! +{Points} points.");
    }

    public override bool IsComplete() => completed;
    public override string GetStatus() => completed ? "[X]" : "[ ]";
}