using HealthcareManagementRESTAPI.Data;
using HealthcareManagementRESTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthcareManagementRESTAPI.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _context;

        public PatientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task Add(Patient p)
        {
            await _context.Patients.AddAsync(p);
            await _context.SaveChangesAsync();
        }
    }
}
