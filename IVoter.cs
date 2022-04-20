using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace voteservice
{
    [ServiceContract]
    public interface IVoter
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "PostVoter", Method = "POST",
           BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json)]
        void PostVoter(string VoterId, string VoterName, string VoterAddress);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteVoter", Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json)]
        void DeleteVoter(string VoterId);

        [OperationContract]
        [WebInvoke(UriTemplate = "PutVoter", Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
           RequestFormat = WebMessageFormat.Json)]
        void PutVoter(string VoterId, string VoterName, string VoterAddress);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetVoter/{VoterId}", Method = "GET",
          RequestFormat = WebMessageFormat.Json)]
        string GetVoter(string VoterId);

    }

}


    

