using System;
namespace TechJobsOO
{
    public class Employer : JobField
    { // Employer Class created, extending JobField class
        // this class identifies the employer of a job and has access to Id, but can only get it
        public Employer() : base()
        {
            // constructor extends base class parameterless constructor from "JobField"
            // base class contains Id = nextId , nextId++ (aka: Id = nextId++)
            
        }

        public Employer(string value) : base(value)
        {
            //constructor extends base class with 'value' as parameter from "JobField"
            //base class contains : Value = value
        }

    }
}

