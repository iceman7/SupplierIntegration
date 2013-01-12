using System.Runtime.Serialization;

namespace SupplierIntegration.Contracts
{
    [DataContract(Namespace = "http://schemas.smd.co.za/contracts/2013/01")]
    public class AppointmentResponse
    {
        [DataMember]
        public string AppointmentReference { get; set; }
        [DataMember]
        public string StockReference { get; set; }
        [DataMember]
        public AssestLocation AssetLocation { get; set; }
    }
}
