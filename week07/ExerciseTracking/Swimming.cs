class Swimming : Activity
{
    private int Laps;
    private const double LapLengthMiles = 50 / 1609.34; // 50 meters converted to miles

    public Swimming(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance() => Laps * LapLengthMiles;
    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60;
    public override double GetPace() => DurationMinutes / GetDistance();
}