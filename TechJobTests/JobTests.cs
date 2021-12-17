using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass] 
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //default empty method provided when creating test
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsTrue(job2.Id - job1.Id == 1);
            // tests if job 1 and job 2 are separated by one integer,
            // and are unique to one another.
            Assert.IsTrue(job1.Id == 1);
            Assert.IsTrue(job2.Id == 2);
            //two lines above test the same as line 21 in lengthier format
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            //instantiating Employer class with name employer with value "ACME"
            Location location = new Location("Desert");
            //instantiating Location class with name location with value "Desert"
            PositionType jobType = new PositionType("Quality Control");
            //instantiating PostionType class with jobType and value "Quality Control"
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");
            //instantiating CoreCompetency class named "jobCoreCompetency" assigned "Persistence"
            Job job = new Job("Product Tester", employer, location, jobType, jobCoreCompetency);
            //creating a new instantiation of Job class passing in a string as a name and
            // classes created above as parameters (defined in Job.cs)

            // tests assert whether the expected (hard typed) value is equal to
            // the value passed above:
            Assert.AreEqual("Product Tester" , job.Name);
            Assert.AreEqual("ACME" , job.EmployerName.ToString());
            Assert.AreEqual("Desert" , job.EmployerLocation.ToString());
            Assert.AreEqual("Quality Control" , job.JobType.ToString());
            Assert.AreEqual("Persistence" , job.JobCoreCompetency.ToString());
            //if you don't include .ToString(), it can't read the value as a string because it is a class
            //this is why we had to create overridden class types
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("LC101");
            Location location = new Location("STL");
            PositionType jobType = new PositionType("There");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Everything");
            //same as previous test
            Job job1 = new Job("Samson Wilson", employer, location, jobType, jobCoreCompetency);
            //job created with same specifications as previous test
            Job job2 = new Job("Samson Wilson", employer, location, jobType, jobCoreCompetency);
            //additional job created with same specifications to check if two jobs are the same
            //test "isTrue" expected to fail if set to "Equals" because they have unique Id's

            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestLinesAndStrings()
        {
            Employer employer = new Employer("Banana");
            Location location = new Location("Banana Republic");
            PositionType jobType = new PositionType("Banana Culler");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Bananaing");
            Job job = new Job("Cat Nanington", employer, location, jobType, jobCoreCompetency);
            //creating test that asserts that the ToString method is formatted as intended,
            //including new lines between each description and a new line
            //preceding each job as well as after.
            Assert.IsTrue(job.ToString().Contains($"\n" +
                $"Id: {job.Id}\n" +
                $"Name: {job.Name}\n" +
                $"Employer: {job.EmployerName}\n" +
                $"Location: {job.EmployerLocation}\n" +
                $"Position Type: {job.JobType}\n" +
                $"Core Competency: {job.JobCoreCompetency}\n"));

            
        }

        [TestMethod]
        public void TestBlank()
        {
            Employer employer = new Employer();
            Location location = new Location();
            PositionType jobType = new PositionType();
            CoreCompetency jobCoreCompetency = new CoreCompetency();
            Job job = new Job("Data not available", employer, location, jobType, jobCoreCompetency);

            Assert.AreEqual("Data not available", job.Name);
            Assert.AreEqual("Data not available", job.EmployerName.ToString());
            Assert.AreEqual("Data not available", job.EmployerLocation.ToString());
            Assert.AreEqual("Data not available", job.JobCoreCompetency.ToString());
            Assert.AreEqual("Data not available", job.JobType.ToString());

            //string[] toStringArray = job.ToString().Split('\n');

            //Assert.IsTrue(toStringArray[1] == $"Id: {job.Id}");
            //Assert.IsTrue(toStringArray[2] == "Name: Data not available");
            //Assert.AreEqual(toStringArray[3], "Employer: Data not available");
            //Assert.IsTrue(toStringArray[4] == "Location: Data not available");
            //Assert.IsTrue(toStringArray[5] == "Position Type: Data not available");
            //Assert.IsTrue(toStringArray[6] == "Core Competency: Data not available");

        }

        [TestMethod]
        public void TestEmptyJob()
        {
            Job job = new Job();

            Assert.IsTrue(job.ToString() == "Oops! This job does not seem to exist!");

        }
    }
}
