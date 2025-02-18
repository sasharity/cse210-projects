class Running : Activity
{
    private double Distance;

    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / DurationMinutes) * 60;
    public override double GetPace() => DurationMinutes / Distance;
}