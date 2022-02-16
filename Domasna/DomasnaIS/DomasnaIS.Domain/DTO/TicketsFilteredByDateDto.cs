using DomasnaIS.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomasnaIS.Domain.DTO
{
    public class TicketsFilteredByDateDto
    {
        public List<Ticket> AllTickets { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}
