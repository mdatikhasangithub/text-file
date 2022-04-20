using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace voteservice.Model
{
    public class Voter
    {
      [Key]
        public int VoterId { get; set; }
        public string VoterName { get; set; }
        public string VoterAddress { get; set; }

    }
}