using System.Collections.Generic;
using System.ServiceModel;
using SupplierIntegration.Contracts;
using SupplierIntegration.Data;
using System.ComponentModel.DataAnnotations;

namespace SupplierIntegration.Service
{
    public class SmdService : ISmdService
    {
        public AppointmentResponse RequestAppointment(RequestAppointment request)
        {
            // validations
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(request, new ValidationContext(request, null, null), results, true))
            {
                var faultResponse = new FaultResponse {Message = "Not processed due to validation failure"};
                foreach (var validationResult in results)
                {
                    faultResponse.ValidationErrors.Add(string.Format(validationResult.ErrorMessage));
                }

                throw new FaultException<FaultResponse>(faultResponse, "Validation Errors");
            }

            // custom validation

            // data access
            var data = new SupplierIntegrationDbContext();
            var response = data.CreateAppointment(request);

            return response;

        }

        public object GetAppointmentStatus(object status)
        {
            return null;
        }

        public object PlaceAppointmentOnHold(object details)
        {
            return null;
        }

        public object WithdrawAppointment(object details)
        {
            return null;
        }

        public object ReleaseRequest(object details)
        {
            return null;
        }

        public object TowingRequest(object details)
        {
            return null;
        }

        public object UpdateAppointmentInformation(object details)
        {
            return null;
        }

        public object GetPaymentRecon(object details)
        {
            return null;
        }

        public object GetUnclaimedVehicles(object details)
        {
            return null;
        }
    }
}
