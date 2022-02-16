using DomasnaIS.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomasnaIS.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public AppUser Owner { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
    }
}
