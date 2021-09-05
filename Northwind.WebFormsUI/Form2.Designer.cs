
namespace Northwind.WebFormsUI
{
    partial class FormUpdateProduct
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
            this.gbxProductDetail = new System.Windows.Forms.GroupBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.cbxUpdateAllow = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxProductDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProductDetail
            // 
            this.gbxProductDetail.Controls.Add(this.lblUnitPrice);
            this.gbxProductDetail.Controls.Add(this.lblUnitsInStock);
            this.gbxProductDetail.Controls.Add(this.tbxUnitPrice);
            this.gbxProductDetail.Controls.Add(this.tbxUnitsInStock);
            this.gbxProductDetail.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductDetail.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductDetail.Controls.Add(this.lblCategory);
            this.gbxProductDetail.Controls.Add(this.cbxCategory);
            this.gbxProductDetail.Controls.Add(this.lblProductName);
            this.gbxProductDetail.Controls.Add(this.tbxProductName);
            this.gbxProductDetail.Location = new System.Drawing.Point(12, 12);
            this.gbxProductDetail.Name = "gbxProductDetail";
            this.gbxProductDetail.Size = new System.Drawing.Size(776, 177);
            this.gbxProductDetail.TabIndex = 0;
            this.gbxProductDetail.TabStop = false;
            this.gbxProductDetail.Text = "Ürün Bilgileri";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(19, 149);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 10;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(19, 123);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(59, 13);
            this.lblUnitsInStock.TabIndex = 9;
            this.lblUnitsInStock.Text = "Stok Adedi";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(87, 146);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxUnitPrice.TabIndex = 8;
            // 
            // tbxUnitsInStock
            // 
            this.tbxUnitsInStock.Location = new System.Drawing.Point(87, 120);
            this.tbxUnitsInStock.Name = "tbxUnitsInStock";
            this.tbxUnitsInStock.Size = new System.Drawing.Size(100, 20);
            this.tbxUnitsInStock.TabIndex = 7;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(87, 94);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(672, 20);
            this.tbxQuantityPerUnit.TabIndex = 6;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(19, 97);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnit.TabIndex = 5;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategori";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(87, 67);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(200, 21);
            this.cbxCategory.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(19, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(87, 41);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(672, 20);
            this.tbxProductName.TabIndex = 1;
            // 
            // cbxUpdateAllow
            // 
            this.cbxUpdateAllow.AutoSize = true;
            this.cbxUpdateAllow.Location = new System.Drawing.Point(153, 204);
            this.cbxUpdateAllow.Name = "cbxUpdateAllow";
            this.cbxUpdateAllow.Size = new System.Drawing.Size(161, 17);
            this.cbxUpdateAllow.TabIndex = 0;
            this.cbxUpdateAllow.Text = "Ürünü güncellemek istiyorum";
            this.cbxUpdateAllow.UseVisualStyleBackColor = true;
            this.cbxUpdateAllow.CheckedChanged += new System.EventHandler(this.cbxUpdateAllow_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(627, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 24);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(702, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 24);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxProductDetail);
            this.Controls.Add(this.cbxUpdateAllow);
            this.Name = "FormUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Update";
            this.gbxProductDetail.ResumeLayout(false);
            this.gbxProductDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProductDetail;
        private System.Windows.Forms.CheckBox cbxUpdateAllow;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUnitsInStock;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
    }
}