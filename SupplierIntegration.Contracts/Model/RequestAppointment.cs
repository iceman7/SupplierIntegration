using System.ComponentModel.DataAnnotations;

using System.Runtime.Serialization;

namespace SupplierIntegration.Contracts
{
    [DataContract(Namespace = "http://schemas.smd.co.za/contracts/2013/01")]
    public class RequestAppointment
    {
        [DataMember]
        [Required]
        public string SupplierKey { get; set; }

        [DataMember]
        [Required]
        public string SupplierName { get; set; }

        [DataMember]
        [Required]
        public Client Client { get; set; }
    }
}