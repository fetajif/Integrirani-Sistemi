using AirplaneReservationSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<FlightTicketInShoppingCart> Flights { get; set; }
        public double TotalPrice { get; set; }
    }
}
