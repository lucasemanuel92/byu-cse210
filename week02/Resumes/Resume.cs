using System;

public class Resume() {
    public string _name;
    // Need to intialize the list using the 
    public List<Job> _jobs = new List<Job>();

    public void Display() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: {_jobs} ");

       
    }

}