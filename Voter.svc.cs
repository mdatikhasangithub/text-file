using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using voteservice.Model;

namespace voteservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Voter : IVoter
    {
        DataContext db = new DataContext();


        public void DeleteVoter(string VoterId)
        {
            voteservice.Model.Voter voter
                = db.Voters.Find(Convert.ToInt32(VoterId));

            db.Voters.Remove(voter);
            db.SaveChanges();


        }

        public string GetVoter(string VoterId)
        {
            voteservice.Model.Voter voter
                = db.Voters.Find(Convert.ToInt32(VoterId));

            return "VoterId : " + voter.VoterId + " >>>  VoterName :  "
                + voter.VoterName + " >>> VoterAddress : " + voter.VoterAddress;
        }

        public void PostVoter(string VoterId, string VoterName, string VoterAddress)
        {

            voteservice.Model.Voter voter = new Model.Voter();
            voter.VoterAddress = VoterAddress;
            voter.VoterName = VoterName;
            db.Voters.Add(voter);
            db.SaveChanges();
        }

        public void PutVoter(string VoterId, string VoterName, string VoterAddress)
        {
            voteservice.Model.Voter Voter = db.Voters.Find(Convert.ToInt32(VoterId));
            Voter.VoterAddress = VoterAddress;
            Voter.VoterName = VoterName;
            // db.Entry(voter).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
