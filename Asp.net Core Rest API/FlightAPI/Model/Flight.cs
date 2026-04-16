namespace FlightAPI.Model
{
    public class Flight
    {
        public int Id { get; set;  }
        public string? FlighNumber { get; set; }
        public string? AirLines { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; }
        public double Price { get; set; }
        public int AvalableSeat { get; set; }
    }
}
