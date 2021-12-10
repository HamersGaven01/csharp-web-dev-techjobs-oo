using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class UnitTest1
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

            Assert.IsTrue(job2.Id - job1.Id == 1);
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


    }
}
