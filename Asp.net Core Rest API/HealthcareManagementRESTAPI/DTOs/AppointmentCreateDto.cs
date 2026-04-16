namespace HealthcareManagementRESTAPI.DTOs
{
    public class AppointmentCreateDto
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
