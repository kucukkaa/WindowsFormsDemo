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
        
        public FormSellingScreen(List<ProductToSell> productToSell)
        {
            InitializeComponent();
            _productToSell = productToSell;
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productToSell;
        }
    }
}
