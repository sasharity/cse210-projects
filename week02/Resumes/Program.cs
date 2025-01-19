using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._companyName = "Naphtali";
        job1._jobTitle = "Customer Relationship Officer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._companyName = "Greatlas School";
        job2._jobTitle = "Head Teacher";
        job2._startYear = 2016;
        job2._endYear = 2020;

        Resume personResume = new Resume();
        personResume._name = "Iruoghene Omarayeirue";
        personResume.jobs.Add(job1);
        personResume.jobs.Add(job2);

        personResume.Display();

        // personResume._jobs[1]._jobTitle
    }
}