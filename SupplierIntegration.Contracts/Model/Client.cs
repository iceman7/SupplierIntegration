using System.Runtime.Serialization;

namespace SupplierIntegration.Contracts
{
    [DataContract(Namespace = "http://schemas.smd.co.za/contracts/2013/01")]
    public class Client
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string IdentificationNumber { get; set; }
    }
}