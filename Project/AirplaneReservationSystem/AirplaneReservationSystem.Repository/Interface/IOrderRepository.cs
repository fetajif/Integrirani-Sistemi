using AirplaneReservationSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        Order getOrderDetails(BaseEntity model);
    }
}
