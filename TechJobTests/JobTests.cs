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
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Job job3 = new Job();

            Assert.IsTrue(job2.Id - job1.Id == 1);
            Assert.IsTrue(job1.Id == 1);
            Assert.IsTrue(job2.Id == 2);
            Assert.IsTrue(job3.Id == 3);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");
            Job job = new Job("Product Tester", employer, location, jobType, jobCoreCompetency);

            Assert.IsTrue(job.Name == "Product Tester");
            Assert.IsTrue(job.EmployerName.ToString() == "ACME");
            Assert.IsTrue(job.EmployerLocation.ToString() == "Desert");
            Assert.IsTrue(job.JobType.ToString() == "Quality control");
            Assert.IsTrue(job.JobCoreCompetency.ToString() == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");
            Job job1 = new Job("Product Tester", employer, location, jobType, jobCoreCompetency);
            Job job2 = new Job("Product Tester", employer, location, jobType, jobCoreCompetency);

            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestNewLines()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");
            Job job = new Job("Product Tester", employer, location, jobType, jobCoreCompetency);

            char[] toStringArray = job.ToString().ToCharArray();
            Assert.IsTrue(toStringArray[0] == '\n');
            Assert.IsTrue(toStringArray[toStringArray.Length - 1] == '\n');
        }

        [TestMethod]
        public void TestStringMethods()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");
            Job job = new Job("Product Tester", employer, location, jobType, jobCoreCompetency);

            string[] toStringArray = job.ToString().Split('\n');

            Assert.IsTrue(toStringArray[1] == $"Id: {job.Id}");
            Assert.IsTrue(toStringArray[2] == "Name: Product Tester");
            Assert.IsTrue(toStringArray[3] == "Employer: ACME");
            Assert.IsTrue(toStringArray[4] == "Location: Desert");
            Assert.IsTrue(toStringArray[5] == "Position Type: Quality control");
            Assert.IsTrue(toStringArray[6] == "Core Competency: Persistence");

        }

        [TestMethod]
        public void TestBlank()
        {
            Employer employer = new Employer();
            Location location = new Location();
            PositionType jobType = new PositionType();
            CoreCompetency jobCoreCompetency = new CoreCompetency();
            Job job = new Job("Data not available", employer, location, jobType, jobCoreCompetency);

            string[] toStringArray = job.ToString().Split('\n');

            Assert.IsTrue(toStringArray[1] == $"Id: {job.Id}");
            Assert.IsTrue(toStringArray[2] == "Name: Data not available");
            Assert.AreEqual(toStringArray[3], "Employer: Data not available");
            Assert.IsTrue(toStringArray[4] == "Location: Data not available");
            Assert.IsTrue(toStringArray[5] == "Position Type: Data not available");
            Assert.IsTrue(toStringArray[6] == "Core Competency: Data not available");

        }

        [TestMethod]
        public void TestIfMissing()
        {
            Job job = new Job();

            Assert.IsTrue(job.ToString() == "Oops! This job does not seem to exist!");

        }
    }
}
