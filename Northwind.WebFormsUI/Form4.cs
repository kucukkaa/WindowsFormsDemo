using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.DependencyResolvers.Ninject;
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
    public partial class FormSellingScreen : Form
    {
        List<ProductToSell> _productToSell;
        private ICustomerService _customerService;
        

        public FormSellingScreen(List<ProductToSell> productToSell)
        {
            InitializeComponent();
            _productToSell = productToSell;
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            LoadProducts();
            LoadCustomers();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productToSell;
            lblTotal.Text = "Toplam = " + Total().ToString();
        }

        private void LoadCustomers()
        {
            cbxCustomers.DataSource = _customerService.GetAll();
        }

        private decimal Total()
        {
            decimal total = 0;
            foreach (var product in _productToSell)
            {
                total += (product.Quantity * product.UnitPrice);
            }
            return total;
        }

        private void tbxDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblTotal.Text = "Toplam = " + (Total() - (Total() * (Convert.ToDecimal(tbxDiscount.Text)))).ToString();
            }
            catch 
            {

                lblTotal.Text = "Toplam = " + Total().ToString();
            }
            
        }

        
    }
}
