using Northwind.Bussiness.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public int Add(Order order)
        {
            _orderDal.Add(order);
            var orderId = _orderDal.Get(p => p.CustomerId == order.CustomerId && p.ShipCity == order.ShipCity ).OrderId;//for take orderId for orderDetail table.
            return orderId;
        }
    }
}
