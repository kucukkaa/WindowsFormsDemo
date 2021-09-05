using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.Concrete;
using Northwind.Bussiness.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private List<ProductToSell> productsToSell = new List<ProductToSell>();
        private List<Product> productsToSellTemp; //to change the referance??


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            Category emptyCategory = new Category()
            {
                CategoryId = 0,
                CategoryName = ""
            };

            List<Category> categories = _categoryService.GetAll();
            categories.Insert(0, emptyCategory);


            cbxCategory.DataSource = categories;
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        public void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetProductsWithCategoryName();
            dgwProduct.Columns["CategoryId"].Visible = false;

        }

        public void LoadProductsToSell()
        {
            dgwProductToSell.DataSource = productsToSellTemp;
            dgwProductToSell.DataSource = productsToSell;
        }



        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbxCategory.SelectedValue) == 0)
                {
                    LoadProducts();
                }
                else
                {
                    dgwProduct.DataSource = _productService.GetProductsWithCategoryNameByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue));
                }

            }
            catch
            {

            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsWithCategoryNameByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Ürün silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dgwProduct.CurrentRow != null && answer == DialogResult.Yes)
            {
                try
                {
                    Product tempProduct = new Product()
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                        ProductName = dgwProduct.CurrentRow.Cells[2].Value.ToString()
                    };

                    _productService.Delete(tempProduct);
                    MessageBox.Show(tempProduct.ProductName + " Silindi!");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var productId = (int)(dgwProduct.CurrentRow.Cells["ProductId"].Value);

            FormUpdateProduct formUpdate = new FormUpdateProduct(productId);
            formUpdate.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct formAdd = new FormAddProduct();
            formAdd.ShowDialog();
        }

        private void btnAddToSell_Click(object sender, EventArgs e)
        {
            ProductToSell productToSell = new ProductToSell()
            {
                ProductId = (int)(dgwProduct.CurrentRow.Cells["ProductId"].Value),
                ProductName = dgwProduct.CurrentRow.Cells["ProductName"].Value.ToString(),
                UnitPrice = Convert.ToDecimal(dgwProduct.CurrentRow.Cells["UnitPrice"].Value),
                UnitsInStock = Convert.ToInt16(dgwProduct.CurrentRow.Cells["UnitsInStock"].Value),
                Quantity = 1
            };

            if (productsToSell.Find(p=>p.ProductId == productToSell.ProductId) == null)
            {
                productsToSell.Add(productToSell);
            }
            else
            {
                productsToSell[productsToSell.FindIndex(p=>p.ProductId==productToSell.ProductId)].Quantity +=1;
            }

            LoadProductsToSell();
        }

    }
}
