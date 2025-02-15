class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    
    // private int totalPoints = 0;

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Bad Habit");
            Console.WriteLine("5. Exit"); 
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ShowGoals(); break;
                case "4": BadHabit("Skipped a day", "This happens when you are not focused"); break; // Now calls function to create Bad Habit
                case "5": return; // Exit program
                default: Console.WriteLine("Invalid option. Try again."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist 4. Bad Habit");
        string type = Console.ReadLine();
        
        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                break;
            
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
    private void RecordEvent()
    {
        ShowGoals();
        Console.Write("Enter goal number to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name}");
        }
    }
    private void BadHabit(string name, string description)
    {
        Console.Write("Enter penalty points: ");
        int penalty = int.Parse(Console.ReadLine());
        goals.Add(new BadHabitGoal(name, description, penalty));
        Console.WriteLine($"Bad Habit '{name}' added with a penalty of {penalty} points.");
    }
}
