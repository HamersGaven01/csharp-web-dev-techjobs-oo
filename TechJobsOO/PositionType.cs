using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    { // PositionType Class created, extending JobField class

        // Class identifies a job with Position and has access to nextId
        // JobField is extract so this class cannot instantiate JobField
        // this class identifies position of a job and has access to Id, but can only get it

        public PositionType() : base()
        {
            // constructor extends base class parameterless constructor from "JobField"
            // base class contains Id = nextId , nextId++ (aka: Id = nextId++)
            // -was copy pasted from 'Location.cs', since all child classes are the same
            // (aside form the name of the class, but funcitonally similar)
        }

        public PositionType(string value) : base(value)
        {
            //constructor extends base class with 'value' as parameter from "JobField"
            //base class contains : Value = value
            // - copy pasted from Location class, see above
        }
    }
}
