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
    public class JobController : ControllerBase
    {
        private readonly IJobBO _jobBO;

        public JobController(IJobBO jobBO)
        {
            _jobBO = jobBO;
        }

        [HttpGet]
        public IEnumerable<Job> GetCandidates()
        {
            return _jobBO.GetAllJobs();
        }

        [HttpPost]
        public void Post(Job job)
        {
            _jobBO.PostJob(job);
        }
    }
}