using FlightAPI.Model;

namespace FlightAPI.Repository
{
    public interface IFlighRepository
    {
        void AddFlight(Flight flight);
        Flight GetFlightId(int flightId);
        List<Flight> GetAllFlights();
        void EditFlight(Flight flight);
        void DeleteFlight(int flightId);
    }
}
