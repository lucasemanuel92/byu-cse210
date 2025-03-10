using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new object from the class using the model "Class ObjectName = new Class()"
        Job job1 = new Job();
        // To access each element of the class use the model "object._elementOfTheObject = 'value I Want' "
        job1._jobTitle = "Software Engineer Intern";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer Intern";
        job2._company = "Samsung Engineer";
        job2._startYear = 2016;
        job2._endYear = 2020;


        
        Resume myResume = new Resume();
        myResume._name = "Lucas Carvalho";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}