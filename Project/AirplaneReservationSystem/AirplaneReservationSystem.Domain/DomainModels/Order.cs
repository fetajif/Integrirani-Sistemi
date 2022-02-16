using AirplaneReservationSystem.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public FlightAppUser User { get; set; }
        public IEnumerable<FlightTicketInOrder> FlightTicketInOrders { get; set; }

    }
}
