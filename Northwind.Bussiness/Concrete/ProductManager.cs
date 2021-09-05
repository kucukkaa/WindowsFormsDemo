using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.Utilities;
using Northwind.Bussiness.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProdcutsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProdcutsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public Product GetProductById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<ProductDetailDto> GetProductsWithCategoryName()
        {
            return _productDal.GetProductsWithCategoryName();
        }

        public List<ProductDetailDto> GetProductsWithCategoryNameByCategoryId(int categoryId)
        {
            return _productDal.GetProductsWithCategoryName(p => p.CategoryId == categoryId);
        }

        public List<ProductDetailDto> GetProductsWithCategoryNameByProductName(string productName)
        {
            return _productDal.GetProductsWithCategoryName(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }


    }
}
