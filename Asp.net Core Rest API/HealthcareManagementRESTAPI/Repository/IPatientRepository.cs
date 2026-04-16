using HealthcareManagementRESTAPI.Models;

namespace HealthcareManagementRESTAPI.Repository
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAll();
        Task Add(Patient p);
    }
}
