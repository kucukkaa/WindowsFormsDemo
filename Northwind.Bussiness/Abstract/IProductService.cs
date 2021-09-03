using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProdcutsByCategory(int categoryId);
        List<Product> GetProdcutsByProductName(string productName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<ProductDetailDto> GetProductsWithCategoryName();
        List<ProductDetailDto> GetProductsWithCategoryNameByCategoryId(int categoryId);
        List<ProductDetailDto> GetProductsWithCategoryNameByProductName(string productName);
    }
}
