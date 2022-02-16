using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomasnaIS.Domain.DomainModels
{
    public class Ticket : BaseEntity
    {
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public DateTime DateAvailableFrom { get; set; }
        [Required]
        public DateTime DateAvailableTo { get; set; }
        [Required]
        public double TicketPrice { get; set; }
        public int MovieRating { get; set; }
        public string MoviePosterURL { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }
    }
}
