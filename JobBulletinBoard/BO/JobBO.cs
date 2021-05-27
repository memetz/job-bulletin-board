using JobBulletinBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBulletinBoard.BO
{
    public class JobBO : IJobBO
    {
        private readonly ICandidateBO _candidateBO;
        public JobBO(ICandidateBO candidateBO)
        {
            _candidateBO = candidateBO;
        }

        static List<Job> _jobs = new List<Job>()
        {
            new Job(){ Id = 1, Name = "FE SoftWare Developer", Company = "Canva", Skills = new List<string>() { "C#", "SQL", "HTML" } },
            new Job(){ Id = 2, Name = "BE SoftWare Developer", Company = "Google", Skills = new List<string>() { "Java", "mySQL", "CSS" } },
            new Job(){ Id = 3, Name = "Business Analyst", Company = "Microsoft", Skills = new List<string>() { "C++", "Oracle", "Cassandra" } },
        };

        public List<Job> GetAllJobs()
        {
            foreach (var job in _jobs)
            {
                job.BestCandidate = FindBestCandidate(job.Skills);
            }
            return _jobs;
        }

        public void PostJob(Job job)
        {
            _jobs.Add(job);
        }

        private Candidate FindBestCandidate(List<string> reqSkills)
        {
            Candidate match = null;

            var candidates = _candidateBO.GetAllCandidates();
            int highestMatch = 0;

            foreach (var cand in candidates)
            {
                var matchedSkills = cand.Skills.Intersect(reqSkills).ToList();
                if (matchedSkills.Count > highestMatch)
                {
                    match = cand;
                    highestMatch = matchedSkills.Count;
                }
            }

            return match;
        }
    }
}
