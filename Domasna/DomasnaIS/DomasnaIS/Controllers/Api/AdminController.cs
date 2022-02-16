using DomasnaIS.Domain.DomainModels;
using DomasnaIS.Domain.DTO;
using DomasnaIS.Domain.Identity;
using DomasnaIS.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DomasnaIS.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ITicketService _ticketService;

        private readonly UserManager<AppUser> userManager;
        public AdminController (IOrderService orderService, UserManager<AppUser> userManager, ITicketService ticketService)
        {
            _orderService = orderService;
            _ticketService = ticketService;
            this.userManager = userManager;
        }

        [HttpGet("[action]")]
        public List<Order> GetAllActiveOrders()
        {
            return this._orderService.getAllOrders();
        }

        [HttpGet("[action]")]
        public List<Ticket> GetTickets()
        {
            return this._ticketService.GetAllTickets();
        }

        [HttpPost("[action]")]
        public List<Ticket> GetTicketsFromGenre(string Genre)
        {
            return this._ticketService.GetAllTickets().Where(z => z.Genre == Genre).ToList();
        }
        [HttpGet("[action]")]
        public AllOrdersDto GetAllOrdersFromUser()
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Order> allOrders = GetAllActiveOrders();
            List<Order> userOrders = allOrders.Where(z => z.UserId == userID).ToList();
            AllOrdersDto model = new AllOrdersDto
            {
                userId = userID,
                Orders = userOrders
            };
            return model;
        }

        [HttpPost("[action]")]
        public Order GetDetailsForTicket(BaseEntity model)
        {
            return this._orderService.getOrderDetails(model);
        }

        [HttpPost("[action]")]
        public bool ImportAllUsers(List<ImportUserDto> model)
        {
            bool status = true;

            foreach (var item in model)
            {
                var userCheck = userManager.FindByEmailAsync(item.Email).Result;

                if (userCheck == null)
                {
                    var user = new AppUser
                    {
                        UserName = item.Email,
                        NormalizedUserName = item.Email,
                        Email = item.Email,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        UserShoppingCart = new ShoppingCart(),
                        SelectedRole = item.SelectedRole
                    };
                    var result = userManager.CreateAsync(user, item.Password).Result;

                    status = status && result.Succeeded;
                }
                else
                {
                    continue;
                }
            }

            return status;
        }
    }
}
