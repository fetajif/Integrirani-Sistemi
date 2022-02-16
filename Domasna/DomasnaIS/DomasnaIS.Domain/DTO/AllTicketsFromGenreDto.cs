using DomasnaIS.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomasnaIS.Domain.DTO
{
    public class AllTicketsFromGenreDto
    {
        public List<Ticket> Tickets { get; set; }
        public string Genre { get; set; }
    }
}
