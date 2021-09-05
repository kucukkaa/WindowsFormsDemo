using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.DependencyResolvers.Ninject;
using Northwind.Entities.Concrete;
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
    public partial class FormUpdateProduct : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private Product tempProduct;


        public FormUpdateProduct(int productId)
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            LoadCategories();
            tempProduct = _productService.GetProductById(productId);
            LoadProductToTextBoxes(productId);
            DisableProductDetails();
            
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadProductToTextBoxes(int productId)
        {
            
            tbxProductName.Text = tempProduct.ProductName;
            tbxQuantityPerUnit.Text = tempProduct.QuantityPerUnit;
            tbxUnitsInStock.Text = tempProduct.UnitsInStock.ToString();
            tbxUnitPrice.Text = tempProduct.UnitPrice.ToString();
            cbxCategory.SelectedValue = tempProduct.CategoryId;
        }

        private void DisableProductDetails()
        {
            if (!cbxUpdateAllow.Checked)
            {
                gbxProductDetail.Enabled = false;
                btnUpdate.Enabled = false;

            }
            else
            {
                gbxProductDetail.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxUpdateAllow_CheckedChanged(object sender, EventArgs e)
        {
            DisableProductDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = tempProduct.ProductId,
                ProductName = tbxProductName.Text,
                CategoryId = Convert.ToInt32(cbxCategory.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStock.Text),
                QuantityPerUnit = tbxQuantityPerUnit.Text
            });
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.LoadProducts();
            MessageBox.Show("Ürün Güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
