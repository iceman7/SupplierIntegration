using System.Runtime.Serialization;

namespace SupplierIntegration.Contracts
{
    [DataContract(Namespace = "http://schemas.smd.co.za/contracts/2013/01")]
    public enum AssestLocation
    {
        [EnumMember]
        Boksburg = 0,
        [EnumMember]
        Pretoria = 1
    }
}