using AirplaneReservationSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Domain.DTO
{
    public class AllOrdersDto
    {
        public List<Order> Orders { get; set; }
        public string userId { get; set; }
    }
}
