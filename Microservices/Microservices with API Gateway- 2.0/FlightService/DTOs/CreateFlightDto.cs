namespace FlightService.DTOs
{
    public class CreateFlightDto
    {
        public string FlightNumber { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
    }
}
