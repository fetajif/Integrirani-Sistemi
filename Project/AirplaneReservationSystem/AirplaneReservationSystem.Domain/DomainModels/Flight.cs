using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirplaneReservationSystem.Domain.DomainModels
{
    public enum FlightClass
    {
        Economic,
        Business
    }

    public class Flight : BaseEntity
    {
        [Required]
        public string AirlineName { get; set; }
        [Required]
        public string FlightDeparture { get; set; }
        [Required]
        public string FlightDestination { get; set; }
        [Required]
        public DateTime DateDeparture { get; set; }
        [Required]
        public DateTime DateReturn { get; set; }
        [Required]
        public int Passengers { get; set; }
        [Required]
        public int MaxSeats { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public FlightClass Class { get; set; }
        public virtual ICollection<FlightTicketInShoppingCart> FlightTicketInShoppingCarts { get; set; }
        public IEnumerable<FlightTicketInOrder> FlightTicketInOrders { get; set; }

    }
}
