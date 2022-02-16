using AirplaneReservationSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Services.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto getShoppingCartInfo(string userId);
        bool deleteFlightFromShoppingCart(string userId, Guid id);
        bool orderNow(string userId);
    }
}
