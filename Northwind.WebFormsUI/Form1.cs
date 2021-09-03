using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.Concrete;
using Northwind.Bussiness.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
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


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProdcutsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProdcutsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Ürün eklemek istediğinizden emin misiniz?", "Ürün ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    _productService.Add(new Product
                    {
                        CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                        ProductName = tbxProductName2.Text,
                        UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                        UnitsInStock = Convert.ToInt16(tbxStock.Text),
                        QuantityPerUnit = tbxQuantityPerUnit.Text,
                    });
                    MessageBox.Show("Ürün eklendi!");
                }
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Ürünü güncellemek istediğinizden emin misiniz?", "Ürün güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    _productService.Update(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                        ProductName = tbxProductNameUpdate.Text,
                        CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                        UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                        UnitsInStock = Convert.ToInt16(tbxStockUpdate.Text),
                        QuantityPerUnit = tbxQuantityPerUnitUpdate.Text
                    });
                    MessageBox.Show("Ürün Güncellendi!");
                }
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpdate.Text = row.Cells[2].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[1].Value;
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxStockUpdate.Text = row.Cells[5].Value.ToString();
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
                    MessageBox.Show(exception.InnerException.InnerException.Message);
                }
            }


        }
    }
}
