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
            Job testjob1 = new Job("Waiter", new Employer("Shenaniganz"), new Location("Hollywood"), new PositionType("Food Service"), new CoreCompetency("Humor"));
            Job testjob2 = new Job("Waiter", new Employer("Shenaniganz"), new Location("Hollywood"), new PositionType("Food Service"), new CoreCompetency("Humor"));
            Assert.IsFalse(Equals(testjob1, testjob2));
        }
    }
}
