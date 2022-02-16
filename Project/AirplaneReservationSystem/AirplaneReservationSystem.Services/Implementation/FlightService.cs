using AirplaneReservationSystem.Domain.DomainModels;
using AirplaneReservationSystem.Domain.DTO;
using AirplaneReservationSystem.Repository.Interface;
using AirplaneReservationSystem.Services.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneReservationSystem.Services.Implementation
{
    public class FlightService : IFlightService
    {
        private readonly IRepository<Flight> _flightRepository;
        private readonly IRepository<FlightTicketInShoppingCart> _flightTicketInShoppingCartRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<FlightService> _logger;
        public FlightService(IRepository<Flight> flightRepository, ILogger<FlightService> logger, IRepository<FlightTicketInShoppingCart> flightTicketInShoppingCartRepository, IUserRepository userRepository)
        {
            _flightRepository = flightRepository;
            _userRepository = userRepository;
            _flightTicketInShoppingCartRepository = flightTicketInShoppingCartRepository;
            _logger = logger;
        }

        public bool AddToShoppingCart(AddToShoppingCartDto item, string userID)
        {
            var user = this._userRepository.Get(userID);

            var userShoppingCart = user.UserShoppingCart;

            if (item.FlightId != null && userShoppingCart != null)
            {
                var flight = this.GetDetailsForFlight(item.FlightId);

                if (flight != null)
                {
                    FlightTicketInShoppingCart itemToAdd = new FlightTicketInShoppingCart
                    {
                        Id = Guid.NewGuid(),
                        SelectedFlight = flight,
                        FlightId = flight.Id,
                        ShoppingCart = userShoppingCart,
                        ShoppingCartId = userShoppingCart.Id,
                        Quantity = item.Quantity
                    };

                    this._flightTicketInShoppingCartRepository.Insert(itemToAdd);
                    _logger.LogInformation("Flight Ticket was successfully added into ShoppingCart");
                    return true;
                }
                return false;
            }
            _logger.LogInformation("Something was wrong. FlightId or UserShoppingCart may be unaveliable!");
            return false;
        }

        public void CreateNewFlight(Flight f)
        {
            this._flightRepository.Insert(f);
        }

        public void DeleteFlight(Guid id)
        {
            var ticket = this.GetDetailsForFlight(id);
            this._flightRepository.Delete(ticket);
        }

        public List<Flight> GetAllFlights()
        {
            _logger.LogInformation("GetAllFlights was called!");
            return this._flightRepository.GetAll().ToList();
        }

        public Flight GetDetailsForFlight(Guid? id)
        {
            return this._flightRepository.Get(id);
        }

        public AddToShoppingCartDto GetShoppingCartInfo(Guid? id)
        {
            var flight = this.GetDetailsForFlight(id);
            AddToShoppingCartDto model = new AddToShoppingCartDto
            {
                SelectedFlight = flight,
                FlightId = flight.Id,
                Quantity = 1
            };

            return model;
        }

        public void UpdateExistingFlight(Flight f)
        {
            this._flightRepository.Update(f);
        }
    }
}
