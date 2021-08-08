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
        public Job(string name, Employer employer, Location employerLocation, PositionType positionType, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = employerLocation;
            JobType = positionType;
            JobCoreCompetency = coreCompetency;
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
    }
}
