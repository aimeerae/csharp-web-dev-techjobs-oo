using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test1 = new Job();
            Job test2 = new Job();
            Assert.IsTrue(test1.Id != test2.Id && test1.Id + 1 == test2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
   
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testjob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testjob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(testjob1.Equals(testjob2));
            Assert.IsFalse(testjob1.Id.Equals(testjob2.Id));
        }



        [TestMethod]
        public void TestForBlankLines()
        {
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St.Louis"), new PositionType("Front-end Developer"), new CoreCompetency("JavaScript"));
            Assert.IsTrue(job2.ToString().StartsWith("\n") && job2.ToString().EndsWith("\n"));

        }
    }
}
