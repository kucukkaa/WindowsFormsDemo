
namespace Northwind.WebFormsUI
{
    partial class FormSellingScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnApplySale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AllowUserToAddRows = false;
            this.dgwProducts.AllowUserToDeleteRows = false;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.Size = new System.Drawing.Size(776, 269);
            this.dgwProducts.TabIndex = 0;
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Location = new System.Drawing.Point(78, 329);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(121, 21);
            this.cbxCustomers.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(559, 290);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Toplam: ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(9, 332);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(59, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Müşteri Adı";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(78, 365);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(121, 20);
            this.tbxAddress.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(9, 368);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "Şehir";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(78, 401);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(121, 20);
            this.tbxDiscount.TabIndex = 6;
            this.tbxDiscount.Text = "0";
            this.tbxDiscount.TextChanged += new System.EventHandler(this.tbxDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(9, 404);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(65, 13);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "İndirim Oranı";
            // 
            // btnApplySale
            // 
            this.btnApplySale.Location = new System.Drawing.Point(484, 327);
            this.btnApplySale.Name = "btnApplySale";
            this.btnApplySale.Size = new System.Drawing.Size(304, 94);
            this.btnApplySale.TabIndex = 8;
            this.btnApplySale.Text = "Satışı Onayla!!";
            this.btnApplySale.UseVisualStyleBackColor = true;
            this.btnApplySale.Click += new System.EventHandler(this.btnApplySale_Click);
            // 
            // FormSellingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApplySale);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbxCustomers);
            this.Controls.Add(this.dgwProducts);
            this.Name = "FormSellingScreen";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.ComboBox cbxCustomers;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnApplySale;
    }
}