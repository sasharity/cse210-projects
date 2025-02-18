class Cycling : Activity
{
    private double Speed;

    public Cycling(DateTime date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance() => (Speed * DurationMinutes) / 60;
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed;
}