using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirplaneReservationSystem.Domain.DomainModels;
using AirplaneReservationSystem.Repository;
using AirplaneReservationSystem.Services.Interface;
using AirplaneReservationSystem.Domain.DTO;
using System.Security.Claims;
using ClosedXML.Excel;
using System.IO;

namespace AirplaneReservationSystem.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IFlightService _flightService;

        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        // GET: Flights
        public IActionResult Index()
        {
            var allFlights = new FilteredFlightsDto
            {
                AllFlights = this._flightService.GetAllFlights(),
                DateDeparture = DateTime.Now,
                DateReturn = DateTime.Now,
                FlightDeparture = "Skopje, Macedonia",
                FlightDestination = ""
            };

            return View(allFlights);
        }

        //POST: Flights filtered by departure, destination, date of departure, date of destination
        [HttpPost]
        public IActionResult Index(FilteredFlightsDto model)
        {
            var AvailableFlights = new FilteredFlightsDto
            {
                AllFlights = this._flightService.GetAllFlights().Where(z =>  z.FlightDestination == model.FlightDestination && z.FlightDeparture == model.FlightDeparture && z.DateDeparture.Date == model.DateDeparture.Date && z.DateReturn.Date == model.DateReturn.Date).ToList(),
                DateDeparture = model.DateDeparture,
                DateReturn = model.DateReturn,
                FlightDeparture = model.FlightDeparture,
                FlightDestination = model.FlightDestination
            };
            return View(AvailableFlights);
        }

        public IActionResult GetAllClassFlightTickets()
        {
            var model = new AllClassFlightTicketsDto
            {
                Flights = this._flightService.GetAllFlights(),
                Class = FlightClass.Economic
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult GetAllClassFlightTickets(AllClassFlightTicketsDto model)
        {
            var ClassFlightTickets = new AllClassFlightTicketsDto
            {
                Flights = this._flightService.GetAllFlights().Where(z => z.Class == model.Class).ToList(),
                Class = model.Class
            };
            return ExportTicketsFromClass(ClassFlightTickets);
        }

        public FileContentResult ExportTicketsFromClass(AllClassFlightTicketsDto model)
        {
            string fileName = "AllTickets.xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("All Tickets from Genre");

                worksheet.Cell(1, 1).Value = "Airline";
                worksheet.Cell(1, 2).Value = "Flight Ticket for Route";
                worksheet.Cell(1, 3).Value = "Price";

                var result = model.Flights;

                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];

                    worksheet.Cell(i + 1, 1).Value = item.AirlineName;
                    worksheet.Cell(i + 1, 2).Value = item.FlightDeparture + " - " + item.FlightDestination;
                    worksheet.Cell(i + 1, 3).Value = item.Price;
                }

                worksheet.Cell(result.Count() + 2, 1).Value = result[0].Class + " Class";

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, contentType, fileName);
                }

            }
        }

        // GET: Flights/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = this._flightService.GetDetailsForFlight(id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // GET: Flights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("AirlineName,FlightDeparture,FlightDestination,DateDeparture,DateReturn,Passengers,MaxSeats,Price,Class,Id")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                this._flightService.CreateNewFlight(flight);
                return RedirectToAction(nameof(Index));
            }
            return View(flight);
        }

        // GET: Flights/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = this._flightService.GetDetailsForFlight(id);
            if (flight == null)
            {
                return NotFound();
            }
            return View(flight);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("AirlineName,FlightDeparture,FlightDestination,DateDeparture,DateReturn,Passengers,MaxSeats,Price,Class,Id")] Flight flight)
        {
            if (id != flight.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._flightService.UpdateExistingFlight(flight);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightExists(flight.Id))
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
            return View(flight);
        }

        // GET: Flights/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = this._flightService.GetDetailsForFlight(id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            this._flightService.DeleteFlight(id);
            return RedirectToAction(nameof(Index));
        }

        private bool FlightExists(Guid id)
        {
            return this._flightService.GetDetailsForFlight(id) != null;
        }

        public IActionResult NoMoreSeatsAvailable(Flight flight)
        {
            return View(flight);
        }

        public IActionResult AddFlightTicketToCart(Guid? id)
        {
            var model = this._flightService.GetShoppingCartInfo(id);
            if (model.SelectedFlight.Passengers == model.SelectedFlight.MaxSeats)
                return View("NoMoreSeatsAvailable", model);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddFlightTicketToCart([Bind("FlightId", "Quantity")] AddToShoppingCartDto item)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var flight = this._flightService.GetDetailsForFlight(item.FlightId);
            if (flight.Passengers + item.Quantity > flight.MaxSeats)
                return View("NoMoreSeatsAvailable", flight);
            var result = this._flightService.AddToShoppingCart(item, userId);
            if (result)
            {
                flight.Passengers += item.Quantity;
                this._flightService.UpdateExistingFlight(flight);
                return RedirectToAction("Index", "Flights");
            }
            return View(item);
        }
    }
}
