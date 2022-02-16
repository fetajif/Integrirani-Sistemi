using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DomainModels
{
    public class FlightTicketInOrder : BaseEntity
    {
        public Guid FlightId { get; set; }
        public Flight SelectedFlight { get; set; }
        public Guid OrderId { get; set; }
        public Order UserOrder { get; set; }
        public int Quantity { get; set; }
    }
}
