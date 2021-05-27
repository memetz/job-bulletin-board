using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBulletinBoard.BO;
using JobBulletinBoard.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobBulletinBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateBO _candidateBO;

        public CandidateController(ICandidateBO candidateBO)
        {
            _candidateBO = candidateBO;
        }

        //static List<Candidate> _candidates = new List<Candidate>()
        //{
        //    new Candidate(){ Id = 1, Name = "John", Surname = "Smith", Title = "FE SoftWare Developer", Skills = new List<string>() { "C#", "SQL", "HTML" } },
        //    new Candidate(){ Id = 2, Name = "Carl", Surname = "Green", Title = "BE SoftWare Developer", Skills = new List<string>() { "Java", "mySQL", "CSS" } },
        //    new Candidate(){ Id = 3, Name = "Mike", Surname = "King", Title = "Business Analyst", Skills = new List<string>() { "C++", "Oracle", "Cassandra" } },
        //};

        [HttpGet]
        public IEnumerable<Candidate> GetCandidates()
        {
            return _candidateBO.GetAllCandidates();
        }

        [HttpPost]
        public void Post(Candidate candidate)
        {
            _candidateBO.PostCandidate(candidate);
        }
    }
}