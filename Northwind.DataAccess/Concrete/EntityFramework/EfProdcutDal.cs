using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProdcutDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductsWithCategoryName(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var data = from p in filter == null ? context.Products : context.Products.Where(filter)
                           join c in context.Categories on p.CategoryId equals c.CategoryId
                           select new ProductDetailDto
                           {
                               ProductId = p.ProductId,
                               ProductName = p.ProductName,
                               CategoryName = c.CategoryName,
                               QuantityPerUnit = p.QuantityPerUnit,
                               UnitsInStock = p.UnitsInStock,
                               UnitPrice = p.UnitPrice,
                               CategoryId = p.CategoryId
                           };
                return data.ToList();
            }
        }


    }
}
