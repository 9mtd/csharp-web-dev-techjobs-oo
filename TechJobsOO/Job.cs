using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }



        // DONE: Add the two necessary constructors.
        //Part a. Code a constructor to initialize the id field with a unique value.
        //This constructor should take no parameters.
           public Job()
        {
            Id = nextId;
            nextId++;
        }

        //Code a second constructor that takes 5 parameters and assigns values to
        //name, employerName, employerLocation, jobType, and jobCoreCompetency.
        //Also, this constructor should call the first in order to initialize the id field.

        public Job(string name, string employer, string employerLocation, string positionType, string coreCompetency) : this()
        {
            Name = name;
            EmployerName = new Employer { Value = employer};
            EmployerLocation = new Location { Value = employerLocation};
            JobType = new PositionType { Value = positionType};
            JobCoreCompetency = new CoreCompetency { value = coreCompetency};
        }

        // DONE: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // DONE: Create ToString() method. Return a blank line.
        public override string ToString()
        {
            if (Id == 0)
            {
                return "empty field";
            }
            return $"\nId: {Id}\n Name: {Name}\n Employer: {EmployerName}\n Location: {EmployerLocation}\n Position Type: {JobType}\n Core Competency: {JobCoreCompetency}\n";
        }

        }
}
