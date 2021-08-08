using System;
namespace TechJobsOO
{
    public class Location

    //For a Location object, useful information includes a list of zip codes associated with that location,
    //in order to determine the city and state for an employer or job.
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Location()
        {
            Id = nextId;
            nextId++;
        }

        // DONE: Add a second constructor to this class that uses the Location() constructor
        // and sets the value of the value field.
        public Location(string value) : this()
        {
            Value = value;
        }


        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
