using AirplaneReservationSystem.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public FlightAppUser Owner { get; set; }
        public virtual ICollection<FlightTicketInShoppingCart> FlightTicketInShoppingCarts { get; set; }
    }
}
