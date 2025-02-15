class BadHabitGoal : Goal
{
    public BadHabitGoal(string name, string description, int penalty)
        : base(name, description, -penalty) 
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Oops! '{Name}' was recorded. -{-Points} points deducted.");
    }

    public override bool IsComplete() => false;
    public override string GetStatus() => "[!BAD HABIT!]";
}