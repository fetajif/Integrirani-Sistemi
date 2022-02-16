using DomasnaIS.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomasnaIS.Domain.DTO
{
    public class AllOrdersDto
    {
        public List<Order> Orders { get; set; }
        public string userId { get; set; }
    }
}
