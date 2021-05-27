using JobBulletinBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBulletinBoard.BO
{
    public class CandidateBO : ICandidateBO
    {
        static List<Candidate> _candidates = new List<Candidate>()
        {
            new Candidate(){ Id = 1, Name = "John", Surname = "Smith", Title = "FE SoftWare Developer", Skills = new List<string>() { "C#", "SQL", "HTML" } },
            new Candidate(){ Id = 2, Name = "Carl", Surname = "Green", Title = "BE SoftWare Developer", Skills = new List<string>() { "Java", "mySQL", "CSS" } },
            new Candidate(){ Id = 3, Name = "Mike", Surname = "King", Title = "Business Analyst", Skills = new List<string>() { "C++", "Oracle", "Cassandra" } },
        };

        public List<Candidate> GetAllCandidates()
        {
            return _candidates;
        }

        public void PostCandidate(Candidate candidate)
        {
            _candidates.Add(candidate);
        }
    }
}
