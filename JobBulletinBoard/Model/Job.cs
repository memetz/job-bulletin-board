using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBulletinBoard.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public List<string> Skills { get; set; }
        public Candidate BestCandidate { get; set; }
    }
}
