using System.Data.Entity;
using SupplierIntegration.Contracts;
using System.Linq;

namespace SupplierIntegration.Data
{
    public class SupplierIntegrationDbContext : DbContext
    {
        public SupplierIntegrationDbContext(): base("smd")
        {
            
        }

        public DbSet<RequestAppointment> RequestAppointments { get; set; }

        public AppointmentResponse CreateAppointment(RequestAppointment requestAppointment)
        {
            // persist to SMDCore? SMDSQL? SMDWhatever?
            RequestAppointments.Add(requestAppointment);
            this.SaveChanges();

            // get the location
            // get stock reference
            // Appointment reference

            var response = new AppointmentResponse()
                {
                     AppointmentReference = "",
                     AssetLocation = AssestLocation.Boksburg,
                     StockReference = ""
                };

            return response;
        }

        public RequestAppointment GetAppointment(string supplier)
        {  
            return RequestAppointments.First(s => s.SupplierKey == supplier);
        }
    }
}