using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DomainModels
{
    public class FlightTicketInShoppingCart : BaseEntity
    {
        public Guid FlightId { get; set; }
        public Flight SelectedFlight { get; set; }

        public Guid ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int Quantity { get; set; }
    }
}
