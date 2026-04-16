using FlightAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightAPI.Repository
{
    public class FlighRepository : IFlighRepository
    {
        private List<Flight> flights = new List<Flight>()
        {
            new Flight{Id=101,FlighNumber="AT101",AirLines="Air India",Source="Delhi",Destination="Mumbai",Price=5000, AvalableSeat=50},
            new Flight{Id=102,FlighNumber="6E202",AirLines="IndiGo",Source="Hyderabad",Destination="Bangalore",Price=3500, AvalableSeat=40}
        };

        
        public void AddFlight(Flight flight)
        {
            try
            { 

                flights.Add(flight);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteFlight(int flightId)
        {
            try
            {

                var flight = flights.FirstOrDefault(p => p.Id == flightId);

                if (flight == null)
                    throw new Exception("Flight not found");

                flights.Remove(flight);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EditFlight(Flight flight)
        {
            try
            {
                if (flight == null)
                    throw new Exception("Flight cannot be null");

                var existingFlight = flights.FirstOrDefault(f => f.Id == flight.Id);

                if (existingFlight == null)
                    throw new Exception("Flight not found");

                existingFlight.FlighNumber = flight.FlighNumber;
                existingFlight.AirLines = flight.AirLines;
                existingFlight.Source = flight.Source;
                existingFlight.Destination = flight.Destination;
                existingFlight.Price = flight.Price;
                existingFlight.AvalableSeat = flight.AvalableSeat;
            }
            catch (Exception)
            {
                throw;
            }
        }

     
        public List<Flight> GetAllFlights()
        {
            return flights;
        }

      
        public Flight GetFlightId(int flightId)
        {
            try
            {
      

                var flight = flights.FirstOrDefault(f => f.Id == flightId);

                if (flight == null)
                {

                    throw new Exception("Flight not found");
                }

                return flight;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}