using HealthcareManagementRESTAPI.Models;

namespace HealthcareManagementRESTAPI.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAll();
        Task Add(Patient p);
    }
}
