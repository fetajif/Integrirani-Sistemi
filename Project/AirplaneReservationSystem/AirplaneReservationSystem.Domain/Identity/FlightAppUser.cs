using AirplaneReservationSystem.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.Identity
{
    public enum Role
    {
        Admin,
        Standard
    }

    public class FlightAppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public virtual ShoppingCart UserShoppingCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Role SelectedRole { get; set; }
    }
}
