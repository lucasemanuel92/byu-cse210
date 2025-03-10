using System;
// To access the class it needs to be public
public class Job()  {
    // Despite the class being public, each element needs also to be called public or else it won't access 
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // This will work as a frame read to be shown in the main class, it's void because it won't return anything in here
    public void Display() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}