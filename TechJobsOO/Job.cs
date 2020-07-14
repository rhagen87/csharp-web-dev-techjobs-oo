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

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string newString = "\n" + "ID: " + Id + "\n";

            if (Name != null) { newString += $"Name: {Name}\n"; }         
            else { newString += "Name: Data not available\n"; }
            
            if (EmployerName != null) { newString += $"Employer: {EmployerName.Value}\n"; }
            else { newString += "Employer: Data not available\n"; }

            if (EmployerLocation != null) { newString += $"Location: {EmployerLocation.Value}\n"; }
            else { newString += "Location: Data not available\n"; }

            if (JobType != null) { newString += $"Position Type: {JobType.Value}\n"; }
            else { newString += "Position Type: Data not available\n"; }

            if (JobCoreCompetency != null) { newString += $"Core Competency: {JobCoreCompetency.Value}\n"; }
            else { newString += "Core Competency: Data not available\n"; }

            return newString;
        }
    }
}
