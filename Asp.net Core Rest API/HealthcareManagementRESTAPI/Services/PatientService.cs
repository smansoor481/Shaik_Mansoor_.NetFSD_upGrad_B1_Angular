using HealthcareManagementRESTAPI.Models;
using HealthcareManagementRESTAPI.Repository;

namespace HealthcareManagementRESTAPI.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repo;

        public PatientService(IPatientRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Patient>> GetAll() => await _repo.GetAll();

        public async Task Add(Patient p) => await _repo.Add(p);
    }
}
