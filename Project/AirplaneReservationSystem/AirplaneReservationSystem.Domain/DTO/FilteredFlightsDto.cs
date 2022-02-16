using AirplaneReservationSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DTO
{
    public class FilteredFlightsDto
    {
        public List<Flight> AllFlights { get; set; }
        public DateTime DateDeparture { get; set; }
        public DateTime DateReturn { get; set; }
        public string FlightDeparture { get; set; }
        public string FlightDestination { get; set; }
    }
}
