using System.ServiceModel;

namespace SupplierIntegration.Contracts
{
    [ServiceContract]
    public interface ISmdService
    {
        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        AppointmentResponse RequestAppointment(RequestAppointment request);

        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        object GetAppointmentStatus(object status);

        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        object PlaceAppointmentOnHold(object details);

        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        object WithdrawAppointment(object details);

        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        object ReleaseRequest(object details);

        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        object TowingRequest(object details);

        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        object UpdateAppointmentInformation(object details);

        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        object GetPaymentRecon(object details);

        [OperationContract]
        [FaultContract(typeof(FaultResponse))]
        object GetUnclaimedVehicles(object details);
    }
}
