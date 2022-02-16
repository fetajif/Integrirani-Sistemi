using AirplaneReservationSystem.Domain.DomainModels;
using AirplaneReservationSystem.Domain.DTO;
using AirplaneReservationSystem.Repository.Interface;
using AirplaneReservationSystem.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneReservationSystem.Services.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<FlightTicketInOrder> _flightTicketInOrderRepository;
        private readonly IUserRepository _userRepository;
        
        public ShoppingCartService(IRepository<ShoppingCart> shoppingCartRepository, IRepository<FlightTicketInOrder> flightTicketInOrderRepository, IRepository<Order> orderRepository, IUserRepository userRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _flightTicketInOrderRepository = flightTicketInOrderRepository;
        }

        public bool deleteFlightFromShoppingCart(string userId, Guid id)
        {
            if (!string.IsNullOrEmpty(userId) && id != null)
            {
                var loggedInUser = this._userRepository.Get(userId);
                var userShoppingCart = loggedInUser.UserShoppingCart;
                var itemToDelete = userShoppingCart.FlightTicketInShoppingCarts.Where(z => z.FlightId.Equals(id)).FirstOrDefault();

                if(itemToDelete.SelectedFlight.Passengers > itemToDelete.Quantity)
                    itemToDelete.SelectedFlight.Passengers -= itemToDelete.Quantity;

                userShoppingCart.FlightTicketInShoppingCarts.Remove(itemToDelete);
                this._shoppingCartRepository.Update(userShoppingCart);

                return true;
            }

            return false;
        }

        public ShoppingCartDto getShoppingCartInfo(string userId)
        {
            var loggedInUser = this._userRepository.Get(userId);
            var userShoppingCart = loggedInUser.UserShoppingCart;
            var AllFlightTickets = userShoppingCart.FlightTicketInShoppingCarts.ToList();

            var allFlightTicketPrice = AllFlightTickets.Select(z => new
            {
                Price = z.SelectedFlight.Price,
                Quanitity = z.Quantity
            }).ToList();

            var totalPrice = 0.0;


            foreach (var item in allFlightTicketPrice)
            {
                totalPrice += item.Quanitity * item.Price;
            }

            ShoppingCartDto scDto = new ShoppingCartDto
            {
                Flights = AllFlightTickets,
                TotalPrice = totalPrice
            };

            return scDto;
        }

        public bool orderNow(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                var loggedInUser = this._userRepository.Get(userId);
                var userShoppingCart = loggedInUser.UserShoppingCart;

                Order order = new Order
                {
                    Id = Guid.NewGuid(),
                    User = loggedInUser,
                    UserId = userId
                };

                this._orderRepository.Insert(order);

                List<FlightTicketInOrder> ticketInOrders = new List<FlightTicketInOrder>();

                var result = userShoppingCart.FlightTicketInShoppingCarts.Select(z => new FlightTicketInOrder
                {
                    Id = Guid.NewGuid(),
                    FlightId = z.SelectedFlight.Id,
                    SelectedFlight = z.SelectedFlight,
                    OrderId = order.Id,
                    UserOrder = order,
                    Quantity = z.Quantity
                }).ToList();

                ticketInOrders.AddRange(result);

                foreach (var item in ticketInOrders)
                {
                    this._flightTicketInOrderRepository.Insert(item);
                }

                loggedInUser.UserShoppingCart.FlightTicketInShoppingCarts.Clear();
                
                this._userRepository.Update(loggedInUser);


                return true;
            }
            return false;
        }
    }
}
