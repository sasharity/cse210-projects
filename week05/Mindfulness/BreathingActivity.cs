class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity helps you relax by guiding deep breathing.") { }

    public void Run()
    {
        Start();
        for (int i = 0; i < Duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(10);
            Console.WriteLine("Breathe out...");
            ShowCountdown(7);
        }
        End();
    }
}
