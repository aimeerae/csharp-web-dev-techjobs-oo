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
        public void TestToStringBlankLines()
        {
            Job stringtest1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(stringtest1.ToString().StartsWith("\n") && stringtest1.ToString().EndsWith("\n"));
            
        }

        [TestMethod]
        public void TestToStringFormatting()
        {
            Job stringtest2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(stringtest2.ToString() == "\n ID: " + stringtest2.Id + "\n Name: " + stringtest2.Name + "\n Employer: " + stringtest2.EmployerName.Value + "\n Location: " + stringtest2.EmployerLocation.Value + "\n Position Type: " + stringtest2.JobType.Value + "\n Core Competency: " + stringtest2.JobCoreCompetency.Value + "\n");
        }

        [TestMethod]
        public void TestToStringEmptyFields()
        {
            Job stringtest3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency(""));

            Assert.IsTrue(stringtest3.ToString() == "\n ID: " + stringtest3.Id + "\n Name: " + stringtest3.Name + "\n Employer: " + stringtest3.EmployerName.Value + "\n Location: " + stringtest3.EmployerLocation.Value + "\n Position Type: " + stringtest3.JobType.Value + "\n Core Competency: " + "Data not available" + "\n");
        }

        [TestMethod]
        public void TestToStringIdOnly()
        {
            Job stringtest4 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            Assert.IsTrue(stringtest4.ToString() == "OOPS! This job does not seem to exist.");
        }
    }
}
