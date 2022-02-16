using DomasnaIS.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomasnaIS.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }
    }
}
