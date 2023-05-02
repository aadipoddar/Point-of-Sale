namespace WinForms.PointOfSale.Purchase
{
    partial class PurchaseForm
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
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateProductPanel = new System.Windows.Forms.Panel();
            this.totalPriceProductNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalPriceProductLabel = new System.Windows.Forms.Label();
            this.pricePerQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pricePerQuanityLabel = new System.Windows.Forms.Label();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalTaxTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.transactionNoTextBox = new System.Windows.Forms.TextBox();
            this.transactionNoLabel = new System.Windows.Forms.Label();
            this.purchaseByTextBox = new System.Windows.Forms.TextBox();
            this.purchaseByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.updateProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceProductNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.quantity,
            this.PricePerQuantity,
            this.TaxPercentage,
            this.SubTotal,
            this.TaxAmount,
            this.Total});
            this.dataGridViewCart.Location = new System.Drawing.Point(1, 60);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.Size = new System.Drawing.Size(868, 589);
            this.dataGridViewCart.TabIndex = 7;
            this.dataGridViewCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellClick);
            this.dataGridViewCart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPurchase_KeyDown);
            // 
            // productId
            // 
            this.productId.HeaderText = "Product ID";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Visible = false;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // PricePerQuantity
            // 
            this.PricePerQuantity.HeaderText = "Price/Quantity";
            this.PricePerQuantity.Name = "PricePerQuantity";
            this.PricePerQuantity.ReadOnly = true;
            // 
            // TaxPercentage
            // 
            this.TaxPercentage.HeaderText = "Tax %";
            this.TaxPercentage.Name = "TaxPercentage";
            this.TaxPercentage.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // TaxAmount
            // 
            this.TaxAmount.HeaderText = "Tax";
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductsButton.Location = new System.Drawing.Point(12, 12);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(205, 42);
            this.searchProductsButton.TabIndex = 6;
            this.searchProductsButton.Text = "Search Products";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(1115, 607);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(205, 42);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateProductPanel
            // 
            this.updateProductPanel.BackColor = System.Drawing.Color.Silver;
            this.updateProductPanel.Controls.Add(this.totalPriceProductNumericUpDown);
            this.updateProductPanel.Controls.Add(this.totalPriceProductLabel);
            this.updateProductPanel.Controls.Add(this.pricePerQuantityNumericUpDown);
            this.updateProductPanel.Controls.Add(this.pricePerQuanityLabel);
            this.updateProductPanel.Controls.Add(this.deleteProduct);
            this.updateProductPanel.Controls.Add(this.quantityNumericUpDown);
            this.updateProductPanel.Controls.Add(this.quantityLabel);
            this.updateProductPanel.Location = new System.Drawing.Point(882, 165);
            this.updateProductPanel.Name = "updateProductPanel";
            this.updateProductPanel.Size = new System.Drawing.Size(440, 199);
            this.updateProductPanel.TabIndex = 17;
            this.updateProductPanel.Visible = false;
            // 
            // totalPriceProductNumericUpDown
            // 
            this.totalPriceProductNumericUpDown.DecimalPlaces = 2;
            this.totalPriceProductNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceProductNumericUpDown.Location = new System.Drawing.Point(184, 105);
            this.totalPriceProductNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.totalPriceProductNumericUpDown.Name = "totalPriceProductNumericUpDown";
            this.totalPriceProductNumericUpDown.Size = new System.Drawing.Size(254, 31);
            this.totalPriceProductNumericUpDown.TabIndex = 21;
            this.totalPriceProductNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalPriceProductNumericUpDown.ValueChanged += new System.EventHandler(this.totalPriceProductNumericUpDown_ValueChanged);
            // 
            // totalPriceProductLabel
            // 
            this.totalPriceProductLabel.AutoSize = true;
            this.totalPriceProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceProductLabel.Location = new System.Drawing.Point(2, 105);
            this.totalPriceProductLabel.Name = "totalPriceProductLabel";
            this.totalPriceProductLabel.Size = new System.Drawing.Size(115, 25);
            this.totalPriceProductLabel.TabIndex = 20;
            this.totalPriceProductLabel.Text = "Total Price";
            // 
            // pricePerQuantityNumericUpDown
            // 
            this.pricePerQuantityNumericUpDown.DecimalPlaces = 2;
            this.pricePerQuantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerQuantityNumericUpDown.Location = new System.Drawing.Point(184, 58);
            this.pricePerQuantityNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pricePerQuantityNumericUpDown.Name = "pricePerQuantityNumericUpDown";
            this.pricePerQuantityNumericUpDown.Size = new System.Drawing.Size(254, 31);
            this.pricePerQuantityNumericUpDown.TabIndex = 19;
            this.pricePerQuantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pricePerQuantityNumericUpDown.ValueChanged += new System.EventHandler(this.pricePerQuantityNumericUpDown_ValueChanged);
            // 
            // pricePerQuanityLabel
            // 
            this.pricePerQuanityLabel.AutoSize = true;
            this.pricePerQuanityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerQuanityLabel.Location = new System.Drawing.Point(2, 58);
            this.pricePerQuanityLabel.Name = "pricePerQuanityLabel";
            this.pricePerQuanityLabel.Size = new System.Drawing.Size(159, 25);
            this.pricePerQuanityLabel.TabIndex = 18;
            this.pricePerQuanityLabel.Text = "Price / Quantity";
            // 
            // deleteProduct
            // 
            this.deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.Location = new System.Drawing.Point(89, 154);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(250, 42);
            this.deleteProduct.TabIndex = 17;
            this.deleteProduct.Text = "Delete Product";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(184, 8);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(254, 31);
            this.quantityNumericUpDown.TabIndex = 1;
            this.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.quantityNumericUpDown_ValueChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(2, 8);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(92, 25);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(1068, 484);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(254, 38);
            this.totalTextBox.TabIndex = 27;
            this.totalTextBox.Text = "0.00";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTaxTextBox
            // 
            this.totalTaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTaxTextBox.Location = new System.Drawing.Point(1068, 437);
            this.totalTaxTextBox.Name = "totalTaxTextBox";
            this.totalTaxTextBox.ReadOnly = true;
            this.totalTaxTextBox.Size = new System.Drawing.Size(254, 31);
            this.totalTaxTextBox.TabIndex = 25;
            this.totalTaxTextBox.Text = "0.00";
            this.totalTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTextBox.Location = new System.Drawing.Point(1120, 390);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(202, 31);
            this.subTotalTextBox.TabIndex = 19;
            this.subTotalTextBox.Text = "0.00";
            this.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(877, 486);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(75, 31);
            this.totalLabel.TabIndex = 26;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(877, 439);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(48, 25);
            this.taxLabel.TabIndex = 24;
            this.taxLabel.Text = "Tax";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(877, 394);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(90, 24);
            this.subTotalLabel.TabIndex = 18;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.CustomFormat = "";
            this.purchaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(1068, 60);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(254, 31);
            this.purchaseDateTimePicker.TabIndex = 31;
            this.purchaseDateTimePicker.Value = new System.DateTime(2023, 4, 25, 18, 29, 32, 0);
            this.purchaseDateTimePicker.ValueChanged += new System.EventHandler(this.purchaseDateTimePicker_ValueChanged);
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateLabel.Location = new System.Drawing.Point(877, 66);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(154, 25);
            this.purchaseDateLabel.TabIndex = 30;
            this.purchaseDateLabel.Text = "Purchase Date";
            // 
            // transactionNoTextBox
            // 
            this.transactionNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoTextBox.Location = new System.Drawing.Point(1068, 12);
            this.transactionNoTextBox.Name = "transactionNoTextBox";
            this.transactionNoTextBox.ReadOnly = true;
            this.transactionNoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transactionNoTextBox.Size = new System.Drawing.Size(254, 31);
            this.transactionNoTextBox.TabIndex = 29;
            // 
            // transactionNoLabel
            // 
            this.transactionNoLabel.AutoSize = true;
            this.transactionNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoLabel.Location = new System.Drawing.Point(877, 15);
            this.transactionNoLabel.Name = "transactionNoLabel";
            this.transactionNoLabel.Size = new System.Drawing.Size(158, 25);
            this.transactionNoLabel.TabIndex = 28;
            this.transactionNoLabel.Text = "Transaction No";
            // 
            // purchaseByTextBox
            // 
            this.purchaseByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseByTextBox.Location = new System.Drawing.Point(1068, 108);
            this.purchaseByTextBox.Name = "purchaseByTextBox";
            this.purchaseByTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.purchaseByTextBox.Size = new System.Drawing.Size(254, 31);
            this.purchaseByTextBox.TabIndex = 33;
            // 
            // purchaseByLabel
            // 
            this.purchaseByLabel.AutoSize = true;
            this.purchaseByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseByLabel.Location = new System.Drawing.Point(877, 111);
            this.purchaseByLabel.Name = "purchaseByLabel";
            this.purchaseByLabel.Size = new System.Drawing.Size(134, 25);
            this.purchaseByLabel.TabIndex = 32;
            this.purchaseByLabel.Text = "Purchase By";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 661);
            this.Controls.Add(this.purchaseByTextBox);
            this.Controls.Add(this.purchaseByLabel);
            this.Controls.Add(this.updateProductPanel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalTaxTextBox);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.purchaseDateTimePicker);
            this.Controls.Add(this.purchaseDateLabel);
            this.Controls.Add(this.transactionNoTextBox);
            this.Controls.Add(this.transactionNoLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.dataGridViewCart);
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.updateProductPanel.ResumeLayout(false);
            this.updateProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceProductNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button searchProductsButton;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Panel updateProductPanel;
        public System.Windows.Forms.Button deleteProduct;
        public System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        public System.Windows.Forms.TextBox totalTextBox;
        public System.Windows.Forms.TextBox totalTaxTextBox;
        public System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subTotalLabel;
        public System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
        private System.Windows.Forms.Label purchaseDateLabel;
        public System.Windows.Forms.TextBox transactionNoTextBox;
        private System.Windows.Forms.Label transactionNoLabel;
        public System.Windows.Forms.TextBox purchaseByTextBox;
        private System.Windows.Forms.Label purchaseByLabel;
        public System.Windows.Forms.NumericUpDown totalPriceProductNumericUpDown;
        private System.Windows.Forms.Label totalPriceProductLabel;
        public System.Windows.Forms.NumericUpDown pricePerQuantityNumericUpDown;
        private System.Windows.Forms.Label pricePerQuanityLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}