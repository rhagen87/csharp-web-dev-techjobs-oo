using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job emptyJob1; Job emptyJob2; Job job1; Job job2;

        [TestInitialize]
        public void CreateJobObjects()
        {
            emptyJob1 = new Job();
            emptyJob2 = new Job();
            job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(emptyJob1.Equals(emptyJob2));
            Assert.IsTrue(emptyJob2.Id.Equals(emptyJob1.Id + 1));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestToStringMethodBlankLine()
        {
            Assert.IsTrue(job1.ToString().StartsWith("\n"));
            Assert.IsTrue(job1.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringMethodLabels()
        {
            Assert.AreEqual(
                "\n" +
                "ID: " + job1.Id + "\n" +
                "Name: Product tester\n" +
                "Employer: ACME\n" +
                "Location: Desert\n" +
                "Position Type: Quality control\n" +
                "Core Competency: Persistence\n", 
                job1.ToString());
        }

        [TestMethod]
        public void TestToStringMethodEmptyField()
        {
            Assert.AreEqual(
                "\n" +
                "ID: " + emptyJob1.Id + "\n" +
                "Name: Data not available\n" +
                "Employer: Data not available\n" +
                "Location: Data not available\n" +
                "Position Type: Data not available\n" +
                "Core Competency: Data not available\n",
                emptyJob1.ToString());
        }


    }
}
