using Moq;
using System;
using Xunit;
using Shouldly;
using JobBulletinBoard.BO;
using JobBulletinBoard.Model;
using System.Collections.Generic;

namespace JobBulletinBoardTest
{
    public class JobTest
    {
        private readonly Mock<ICandidateBO> _mockJobBO;

        public JobTest()
        {
            _mockJobBO = new Mock<ICandidateBO>();
            _mockJobBO.Setup(c => c.GetAllCandidates())
                .Returns(() => new List<Candidate>()
                {
                    new Candidate() { Id = 1, Name = "John", Surname = "Smith", Title = "FE SoftWare Developer", Skills = new List<string>() { "C#", "SQL", "Java" } },
                    new Candidate() { Id = 2, Name = "Carl", Surname = "Green", Title = "BE SoftWare Developer", Skills = new List<string>() { "Java", "mySQL", "CSS" } },
                    new Candidate() { Id = 3, Name = "Mike", Surname = "King", Title = "Business Analyst", Skills = new List<string>() { "C++", "Oracle", "Cassandra" } },
                });
        }

        private JobBO Initiate()
        {
            return new JobBO(_mockJobBO.Object);
        }

        [Fact]
        public void TestBestCandidateShouldBeNull()
        {
            var bo = Initiate();
            var candidate = bo.FindBestCandidate(new List<string>() { "DB Admin", "NOSQL" });
            candidate.ShouldBeNull();
        }

        [Fact]
        public void TestBestCandidateShouldBeCandidate1OnlyOneMatch()
        {
            var bo = Initiate();
            var candidate = bo.FindBestCandidate(new List<string>() { "C#" });
            candidate.Id.ShouldBe(1);
        }

        [Fact]
        public void TestBestCandidateShouldBeCandidate2MultipleMatches()
        {
            var bo = Initiate();
            var candidate = bo.FindBestCandidate(new List<string>() { "Java", "mySQL" });
            candidate.Id.ShouldBe(2);
        }
    }
}
