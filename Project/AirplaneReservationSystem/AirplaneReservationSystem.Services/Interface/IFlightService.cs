using AirplaneReservationSystem.Domain.DomainModels;
using AirplaneReservationSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Services.Interface
{
    public interface IFlightService
    {
        List<Flight> GetAllFlights();
        Flight GetDetailsForFlight(Guid? id);
        void CreateNewFlight(Flight f);
        void UpdateExistingFlight(Flight f);
        AddToShoppingCartDto GetShoppingCartInfo(Guid? id);
        void DeleteFlight(Guid id);
        bool AddToShoppingCart(AddToShoppingCartDto item, string userID);
    }
}
