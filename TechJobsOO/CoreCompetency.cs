using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    { // CoreCompetency Class created, extending JobField class

        //class identifies values for Id but cannot set them,
        //and value that identifies a Core competency of an applicant

        public CoreCompetency() : base()
        {
            // constructor extends base class parameterless constructor from "JobField"
            // base class contains Id = nextId , nextId++ (aka: Id = nextId++)
            // -was copy pasted from 'Employer.cs', since all child classes are the same
            // (aside form the name of the class, but funcitonally similar)
        }

        public CoreCompetency(string value) : base(value)
        {
            //constructor extends base class with 'value' as parameter from "JobField"
            //base class contains : Value = value
            // - copy pasted from Employer class, see above
        }
    }

}
