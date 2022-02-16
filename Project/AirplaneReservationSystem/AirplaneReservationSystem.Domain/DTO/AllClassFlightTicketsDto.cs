using AirplaneReservationSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DTO
{
    public class AllClassFlightTicketsDto
    {
        public List<Flight> Flights { get; set; }
        public FlightClass Class { get; set; }
    }
}
