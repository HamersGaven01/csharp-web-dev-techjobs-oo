using System;
namespace TechJobsOO
{
    public class Location : JobField
    { // Location Class created, extending JobField class
        // this class identifies location of a job and has access to Id, but can only get it

        public Location() : base()
        {
            // constructor extends base class parameterless constructor from "JobField"
            // base class contains Id = nextId , nextId++ (aka: Id = nextId++)
            // -was copy pasted from 'CoreCompetency', since all child classes are the same
            // (aside form the name of the class, but funcitonally similar)
        }

        public Location(string value) : base(value)
        {
            //constructor extends base class with 'value' as parameter from "JobField"
            //base class contains : Value = value
            // - copy pasted from Corecompetency class, see above
        }
    }
}
