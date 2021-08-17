using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            var job = new Job();
            var job2 = new Job();

            Assert.IsTrue(job.Id != job2.Id);
            Assert.IsTrue((job2.Id - job.Id) == 1);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            var jobName = "Product tester";
            var employerName = "ACME";
            var jobLocation = "Dessert";
            var jobType = "Quality control";
            var jobCoreCompetency = "Persistence";

            var job = new Job(jobName, employerName, jobLocation, jobType, jobCoreCompetency);

            Assert.AreEqual(jobName, job.Name);
            Assert.AreEqual(employerName, job.EmployerName.Value);
            Assert.AreEqual(jobLocation, job.EmployerLocation.Value);
            Assert.AreEqual(jobType, job.JobType.Value);
            Assert.AreEqual(jobCoreCompetency, job.JobCoreCompetency.value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            var jobName = "Product tester";
            var employerName = "ACME";
            var jobLocation = "Dessert";
            var jobType = "Quality control";
            var jobCoreCompetency = "Persistence";

            var job1 = new Job(jobName, employerName, jobLocation, jobType, jobCoreCompetency);
            var job2 = new Job(jobName, employerName, jobLocation, jobType, jobCoreCompetency);

            var isEqual = job1.Equals(job2);

            Assert.IsFalse(isEqual);
        }

    }
}
