using System;
namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        //description similar to Job.cs

        public JobField()
        {
            Id = nextId++;
        }
        //same as above

        public JobField(string value) : this()
        {
            Value = value;
        }
        //same as above

        public override bool Equals(object obj)
        {
            return obj is JobField jobfield &&
                   Id == jobfield.Id;
        }
        //same as above

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        //same as above
        public override string ToString()
        {// logic that states that when this abstract class is referenced to with
            //null or empty values, it will return a string "Data not avaiable"
            //as per one of the tests in JobTests.cs
            if (Value == null)
            {
                return "Data not available";
            }
            else if (Value == "")
            {
                return "Data not available";
            }
            else {
                return Value;
            }
        }
    }
}