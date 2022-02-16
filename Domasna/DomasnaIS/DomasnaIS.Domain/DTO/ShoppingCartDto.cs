﻿using DomasnaIS.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomasnaIS.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketInShoppingCart> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}
