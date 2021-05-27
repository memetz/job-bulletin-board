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