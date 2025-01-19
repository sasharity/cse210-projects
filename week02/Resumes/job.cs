using System;

public class Job

{
   public string _companyName = "Naphtali"; 
    public string _jobTitle = "Customer Relationship Officer";
    public int _startYear = 2020;
    public int _endYear = 2023;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}
 