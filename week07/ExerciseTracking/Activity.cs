abstract class Activity
{
    protected DateTime Date;
    protected int DurationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        Date = date;
        DurationMinutes = durationMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({DurationMinutes} min) - " +
               $"Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
