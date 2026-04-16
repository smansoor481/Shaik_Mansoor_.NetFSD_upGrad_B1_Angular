using HealthcareManagementRESTAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace HealthcareManagementRESTAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        [Required] public string? Name { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<Appointment>? Appointments { get; set; }
    }
}