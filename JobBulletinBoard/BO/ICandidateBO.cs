using JobBulletinBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBulletinBoard.BO
{
    public interface ICandidateBO
    {
        List<Candidate> GetAllCandidates();
        void PostCandidate(Candidate candidate);
    }
}
