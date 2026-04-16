namespace HealthcareManagementRESTAPI.DTOs
{
    public class PrescriptionCreateDto
    {
        public int AppointmentId { get; set; }
        public string? Diagnosis { get; set; }
    }
}
