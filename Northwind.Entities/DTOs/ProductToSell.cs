using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.DTOs
{
    public class ProductToSell : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public int Quantity { get; set; }
    }
}
