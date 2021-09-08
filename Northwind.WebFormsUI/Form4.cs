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
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;


        public FormSellingScreen(List<ProductToSell> productToSell)
        {
            InitializeComponent();
            _productToSell = productToSell;
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _orderDetailService = InstanceFactory.GetInstance<IOrderDetailService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
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
            cbxCustomers.ValueMember = "CustomerId";
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

        private void btnApplySale_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                CustomerId = cbxCustomers.SelectedValue.ToString(),
                ShipCity = tbxAddress.Text,
            };
            var tempId = _orderService.Add(order);
            
            foreach (var product in _productToSell)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    ProductId = product.ProductId,
                    Discount = Convert.ToDouble(tbxDiscount.Text),
                    Quantity = Convert.ToInt16(product.Quantity),
                    OrderId = tempId,
                    UnitPrice = product.UnitPrice,
                };
                _orderDetailService.Add(orderDetail);
            }
            this.Close();
        }

        
    }


}

