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
    public partial class FormAddProduct : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public FormAddProduct()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategory.SelectedValue),
                ProductName = tbxProductName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStock.Text),
                QuantityPerUnit = tbxQuantityPerUnit.Text,
            });
            MessageBox.Show("Ürün eklendi!");
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.LoadProducts();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
