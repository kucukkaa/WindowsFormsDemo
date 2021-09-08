using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Concrete
{
    public class OrderDetail : IEntity
    {

        public int OrderDetailId { get; set; } //OrderId with key annotation add method cannot action like update method so it doesn't work.
        public int OrderId { get; set; }   // so add OrderDetailId column to db is a must.
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 Quantity { get; set; }
        public double Discount { get; set; }

    }
}
