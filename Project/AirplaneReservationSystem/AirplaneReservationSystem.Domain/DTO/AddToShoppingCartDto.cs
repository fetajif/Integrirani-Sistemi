using AirplaneReservationSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DTO
{
    public class AddToShoppingCartDto
    {
        public Flight SelectedFlight { get; set; }
        public Guid FlightId { get; set; }
        public int Quantity { get; set; }
    }
}
