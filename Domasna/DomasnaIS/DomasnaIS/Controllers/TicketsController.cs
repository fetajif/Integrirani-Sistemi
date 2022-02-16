using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DomasnaIS.Domain.DomainModels;
using DomasnaIS.Repository;
using DomasnaIS.Service.Interface;
using DomasnaIS.Domain.DTO;
using System.Security.Claims;
using ClosedXML.Excel;
using System.Net.Http;
using System.IO;

namespace DomasnaIS.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: Tickets
        public IActionResult Index()
        {
            var allTickets = new TicketsFilteredByDateDto
            {
                AllTickets = this._ticketService.GetAllTickets(),
                CurrentDate = DateTime.Now
            };
            return View(allTickets);
        }

        //POST: Tickets Filtered By Date
        [HttpPost]
        public IActionResult Index(TicketsFilteredByDateDto model)
        {
            var AvailableTickets = new TicketsFilteredByDateDto
            {
                AllTickets = this._ticketService.GetAllTickets().Where(z => z.DateAvailableFrom <= model.CurrentDate && z.DateAvailableTo >= model.CurrentDate).ToList(),
                CurrentDate = model.CurrentDate
            };
            return View(AvailableTickets);
        }

        public IActionResult GetAllTicketsFromGenre()
        {
            var model = new AllTicketsFromGenreDto
            {
                Tickets = this._ticketService.GetAllTickets(),
                Genre = ""
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult GetAllTicketsFromGenre(AllTicketsFromGenreDto model)
        {
            var TicketsFromGenre = new AllTicketsFromGenreDto
            {
                Tickets = this._ticketService.GetAllTickets().Where(z => z.Genre == model.Genre).ToList(),
                Genre = model.Genre
            };
            return ExportTicketsFromGenre(TicketsFromGenre);
        }

        public FileContentResult ExportTicketsFromGenre(AllTicketsFromGenreDto model)
        {
            string fileName = "AllTickets.xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("All Tickets from Genre");

                worksheet.Cell(1, 1).Value = "Genre";
                worksheet.Cell(1, 2).Value = "Ticket for Movie";
                worksheet.Cell(1, 3).Value = "Ticket Price";

                var result = model.Tickets;

                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];

                    worksheet.Cell(i + 1, 1).Value = item.Genre;
                    worksheet.Cell(i + 1, 2).Value = item.MovieTitle;
                    worksheet.Cell(i + 1, 3).Value = item.TicketPrice;

                    /*for (int p = 0; p < item.TicketInOrders.Count(); p++)
                    {
                        worksheet.Cell(1, p + 3).Value = "Ticket-" + (p + 1);
                        worksheet.Cell(i + 1, p + 3).Value = item.TicketInOrders.ElementAt(p).OrderedTicket.MovieTitle;
                    }*/
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, contentType, fileName);
                }

            }
        }

        // GET: Tickets/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = this._ticketService.GetDetailsForTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MovieTitle,Genre,DateAvailableFrom,DateAvailableTo,TicketPrice,MovieRating,MoviePosterURL,Id")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                this._ticketService.CreateNewTicket(ticket);
                return RedirectToAction(nameof(Index));
            }
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = this._ticketService.GetDetailsForTicket(id);

            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("MovieTitle,Genre,DateAvailableFrom,DateAvailableTo,TicketPrice,MovieRating,MoviePosterURL,Id")] Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._ticketService.UpdateExistingTicket(ticket);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = this._ticketService.GetDetailsForTicket(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            this._ticketService.DeleteTicket(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(Guid id)
        {
            return this._ticketService.GetDetailsForTicket(id) != null;
        }

        public IActionResult AddTicketToCart(Guid? id)
        {
            var model = this._ticketService.GetShoppingCartInfo(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTicketToCart([Bind("TicketId", "Quantity")] AddToShoppingCartDto item)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = this._ticketService.AddToShoppingCart(item, userId);
            if (result)
            {
                return RedirectToAction("Index", "Tickets");
            }
            return View(item);
        }
    }
}
