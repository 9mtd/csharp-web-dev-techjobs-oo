using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        private string Id = "1";
        private string JobName = "Product tester";
        private Employer EmployerName = new Employer("ACME");
        private Location JobLocation = new Location ("Dessert");
        private PositionType JobType = new PositionType ("Quality control");
        private CoreCompetency JobCoreCompetency = new CoreCompetency ("persistence");


        Job test_job;

        [TestInitialize]
        public void CreateJobObject()
        {
            var jobName = JobName;
            var employerName = EmployerName;
            var jobLocation = JobLocation;
            var jobType = JobType;
            var jobCoreCompetency = JobCoreCompetency;

            test_job = new Job(jobName, employerName, jobLocation, jobType, jobCoreCompetency);
            
        }

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
            Assert.AreEqual(JobName, test_job.Name);
            Assert.AreEqual(EmployerName, test_job.EmployerName);
            Assert.AreEqual(JobLocation, test_job.EmployerLocation);
            Assert.AreEqual(JobType, test_job.JobType);
            Assert.AreEqual(JobCoreCompetency, test_job.JobCoreCompetency);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            var job1 = new Job(JobName, EmployerName, JobLocation, JobType, JobCoreCompetency);
            var job2 = new Job(JobName, EmployerName, JobLocation, JobType, JobCoreCompetency);

            var isEqual = job1.Equals(job2);

            Assert.IsFalse(isEqual);
        }


        [TestMethod]
        public void TestToString_StartsWith_EndsWith_BlankLine()
        {
            var jobStr = test_job.ToString();

            Assert.IsTrue(jobStr.StartsWith('\n'));
            Assert.IsTrue(jobStr.EndsWith('\n'));
        }

        [TestMethod]
        public void TestContainLabelForEachField()
        {
            var jobStr = test_job.ToString();

            Assert.IsTrue(jobStr.Contains($"Id: {Id}\n"));
            Assert.IsTrue(jobStr.Contains($"Name: {JobName}\n"));
            Assert.IsTrue(jobStr.Contains($"Employer: {EmployerName}\n"));
            Assert.IsTrue(jobStr.Contains($"Location: {JobLocation}\n"));
            Assert.IsTrue(jobStr.Contains($"Position Type: {JobType}\n"));
            Assert.IsTrue(jobStr.Contains($"Core Competency: {JobCoreCompetency}\n"));

        }


        [TestMethod]
        public void TestIfAFieldIsEmpty()
        {
            var job = new Job(null, null, null, null, null);
            var jobStr = job.ToString();

            Assert.IsTrue(jobStr.Contains($"Name: {Job.DataNotAvailable}\n"));
            Assert.IsTrue(jobStr.Contains($"Employer: {Job.DataNotAvailable}\n"));
            Assert.IsTrue(jobStr.Contains($"Location: {Job.DataNotAvailable}\n"));
            Assert.IsTrue(jobStr.Contains($"Position Type: {Job.DataNotAvailable}\n"));
            Assert.IsTrue(jobStr.Contains($"Core Competency: {Job.DataNotAvailable}\n"));
        }






    }
}



//var id = "1";
//var jobName = "Product tester";
//var employerName = "ACME";
//var jobLocation = "Dessert";
//var jobType = "Quality control";
//var jobCoreCompetency = "Persistence";

//var job = new Job(jobName, employerName, jobLocation, jobType, jobCoreCompetency);
//var jobStr = job.ToString();