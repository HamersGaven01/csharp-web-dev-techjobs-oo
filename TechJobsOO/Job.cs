﻿using System;
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
            Id = nextId++;
        }

        public Job(string name,
                    Employer employerName,
                    Location employerLocation,
                    PositionType jobType,
                    CoreCompetency jobCoreCompetency) : this()
        {
            if (name == "")
            {
                Name = "Data not available";
            }
            else { Name = name; }
            //Name = name;
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
            return base.GetHashCode();
        }


        // TODO: Generate Equals() and GetHashCode() methods.


        public override string ToString()
        {
            if (Name is null &&
                EmployerName is null &&
                EmployerLocation is null &&
                JobType is null &&
                JobCoreCompetency is null)
            {
                return "Oops! This job does not seem to exist!";
            }

            return $"\nId: {Id}" +
                $"\nName: {Name}" +
                $"\nEmployer: {EmployerName}" +
                $"\nLocation: {EmployerLocation}" +
                $"\nPosition Type: {JobType}" +
                $"\nCore Competency: {JobCoreCompetency}" +
                $"\n";
        }

    }
}
