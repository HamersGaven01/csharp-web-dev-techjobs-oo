using System;
namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField jobfield &&
                   Id == jobfield.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
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
            //return Value != null? Value : "Data not available";
        }
    }
}