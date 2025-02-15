class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public int GetTargetCount() { return _targetCount; }
    public void SetTargetCount(int targetCount) { _targetCount = targetCount; }

    public int GetCurrentCount() { return _currentCount; }
    public void SetCurrentCount(int currentCount) { _currentCount = currentCount; }

    public int GetBonus() { return _bonus; }
    public void SetBonus(int bonus) { _bonus = bonus; }

    public override void RecordEvent()
    {
        _currentCount++;
        int gainedPoints = Points;
        if (_currentCount == _targetCount)
        {
            gainedPoints += _bonus;
            Console.WriteLine($"Goal '{Name}' completed! Bonus {_bonus} points awarded!");
        }
        Console.WriteLine($"Recorded '{Name}' progress. +{gainedPoints} points.");
    }

    public override bool IsComplete() => _currentCount >= _targetCount;
    public override string GetStatus() => $"[{_currentCount}/{_targetCount}]";
}