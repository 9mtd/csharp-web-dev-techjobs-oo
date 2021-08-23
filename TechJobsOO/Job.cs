using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public const string DataNotAvailable = "Data not available";

        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }



        //Add the two necessary constructors.
        //Code a constructor to initialize the id field with a unique value.
        //This constructor should take no parameters.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        //Code a second constructor that takes 5 parameters and assigns values to
        //name, employerName, employerLocation, jobType, and jobCoreCompetency.
        //This constructor should call the first in order to initialize the id field.

        public Job(string name, string employer, string employerLocation, string positionType, string coreCompetency) : this()
        {
            Name = name;
            EmployerName = new Employer(employer);
            EmployerLocation = new Location(employerLocation);
            JobType = new PositionType(positionType);
            JobCoreCompetency = new CoreCompetency(coreCompetency);
        }

        //Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        //Create ToString() method.
        public override string ToString()
        {
          
            return $"\nId: {Id}\n Name: {CheckEmptyString(Name)}\n Employer: {CheckEmptyString(EmployerName.ToString())}\n Location: {CheckEmptyString(EmployerLocation.ToString())}\n Position Type: {CheckEmptyString(JobType.ToString())}\n Core Competency: {CheckEmptyString(JobCoreCompetency.ToString())}\n";

        }

        private string CheckEmptyString(string actualValue)
        {
            //using ternary operator
            return string.IsNullOrEmpty(actualValue) ? DataNotAvailable : actualValue;
        }
    }
}
