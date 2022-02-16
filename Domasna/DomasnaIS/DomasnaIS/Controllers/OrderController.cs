using DomasnaIS.Domain.DomainModels;
using DomasnaIS.Domain.DTO;
using DomasnaIS.Service.Interface;
using GemBox.Document;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DomasnaIS.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }
        public IActionResult Index()
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Order> allOrders = GetAllActiveOrders();
            List<Order> userOrders = allOrders.Where(z => z.UserId == userID).ToList();
            AllOrdersDto model = new AllOrdersDto
            {
                userId = userID,
                Orders = userOrders
            };
            return View(model);
        }
        public List<Order> GetAllActiveOrders()
        {
            return this._orderService.getAllOrders();
        }

        public FileContentResult CreateInvoice(Guid id)
        {
            /*HttpClient client = new HttpClient();


            string URI = "https://localhost:44309/api/Admin/GetDetailsForProduct";

            var model = new
            {
                Id = id
            };

            HttpContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = client.PostAsync(URI, content).Result;


            var result = responseMessage.Content.ReadAsAsync<Order>().Result;*/
            var model = new BaseEntity
            {
                Id = id
            };
            var result = this._orderService.getOrderDetails(model);

            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Invoice.docx");
            var document = DocumentModel.Load(templatePath);


            document.Content.Replace("{{OrderNumber}}", result.Id.ToString());
            document.Content.Replace("{{UserName}}", result.User.UserName);

            StringBuilder sb = new StringBuilder();

            var totalPrice = 0.0;

            foreach (var item in result.TicketInOrders)
            {
                totalPrice += item.Quantity * item.OrderedTicket.TicketPrice;
                sb.AppendLine(item.OrderedTicket.MovieTitle + " with quantity of: " + item.Quantity + " and price of: " + item.OrderedTicket.TicketPrice + "$");
            }


            document.Content.Replace("{{TicketList}}", sb.ToString());
            document.Content.Replace("{{TotalPrice}}", totalPrice.ToString() + "$");


            var stream = new MemoryStream();

            document.Save(stream, new PdfSaveOptions());

            return File(stream.ToArray(), new PdfSaveOptions().ContentType, "ExportInvoice.pdf");
        }
    }
}
