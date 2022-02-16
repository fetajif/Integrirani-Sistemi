using DomasnaIS.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomasnaIS.Service.Interface
{
    public interface IOrderService
    {
        List<Order> getAllOrders();
        Order getOrderDetails(BaseEntity model);
    }
}
