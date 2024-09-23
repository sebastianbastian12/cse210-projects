using System;

public class Resume
{
    /*Member variable*/
    public string _employeeName = "";

     /*Member list*/
    public List<Job> _jobs = new List<Job>();

    public void showingEmployeeJobExperience()
    {
        Console.WriteLine($"Employee Name: {_employeeName}");
        Console.WriteLine("Jobs:");

        foreach (var job in _jobs)
        {
            job.DisplayEmployeeJobDetails();
        }
    }

}