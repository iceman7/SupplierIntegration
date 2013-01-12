using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SupplierIntegration.Contracts
{
    [DataContract(Namespace = "http://schemas.smd.co.za/contracts/2013/01")]
    public class FaultResponse
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public List<string> ValidationErrors { get; set; }

        public FaultResponse()
        {
            ValidationErrors = new List<string>();
        }
    }
}
