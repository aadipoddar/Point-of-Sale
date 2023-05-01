namespace PointOfSale.Sale
{
    partial class SaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.transactionNoTextBox = new System.Windows.Forms.TextBox();
            this.transactionNoLabel = new System.Windows.Forms.Label();
            this.saleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.paymentButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPrize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subTotalAfterDiscountTextBox = new System.Windows.Forms.TextBox();
            this.subTotalAfterDiscountLabel = new System.Windows.Forms.Label();
            this.finalDiscountTextBox = new System.Windows.Forms.TextBox();
            this.totalTaxTextBox = new System.Windows.Forms.TextBox();
            this.subTotalBeforeDiscountTextBox = new System.Windows.Forms.TextBox();
            this.totalTaxLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.productName,
            this.quantity,
            this.price,
            this.discountAmount,
            this.discountPercentage,
            this.taxPercent,
            this.taxAmount,
            this.finalPrize,
            this.quantityInStock,
            this.pricePerItem});
            this.dataGridViewCart.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(1310, 463);
            this.dataGridViewCart.TabIndex = 1;
            this.dataGridViewCart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellEndEdit);
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductsButton.Location = new System.Drawing.Point(135, 9);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(250, 42);
            this.searchProductsButton.TabIndex = 0;
            this.searchProductsButton.Text = "Search Products";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // transactionNoTextBox
            // 
            this.transactionNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoTextBox.Location = new System.Drawing.Point(760, 17);
            this.transactionNoTextBox.Name = "transactionNoTextBox";
            this.transactionNoTextBox.ReadOnly = true;
            this.transactionNoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transactionNoTextBox.Size = new System.Drawing.Size(211, 26);
            this.transactionNoTextBox.TabIndex = 14;
            // 
            // transactionNoLabel
            // 
            this.transactionNoLabel.AutoSize = true;
            this.transactionNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoLabel.Location = new System.Drawing.Point(621, 20);
            this.transactionNoLabel.Name = "transactionNoLabel";
            this.transactionNoLabel.Size = new System.Drawing.Size(116, 20);
            this.transactionNoLabel.TabIndex = 13;
            this.transactionNoLabel.Text = "Transaction No";
            // 
            // saleDateTimePicker
            // 
            this.saleDateTimePicker.CustomFormat = "";
            this.saleDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDateTimePicker.Location = new System.Drawing.Point(1111, 15);
            this.saleDateTimePicker.Name = "saleDateTimePicker";
            this.saleDateTimePicker.Size = new System.Drawing.Size(211, 26);
            this.saleDateTimePicker.TabIndex = 16;
            this.saleDateTimePicker.Value = new System.DateTime(2023, 4, 25, 18, 29, 32, 0);
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDateLabel.Location = new System.Drawing.Point(1004, 20);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(80, 20);
            this.saleDateLabel.TabIndex = 15;
            this.saleDateLabel.Text = "Sale Date";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(929, 23);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(75, 31);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(1099, 20);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(203, 38);
            this.totalTextBox.TabIndex = 12;
            this.totalTextBox.Text = "0.00";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.Location = new System.Drawing.Point(1151, 61);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(156, 59);
            this.paymentButton.TabIndex = 18;
            this.paymentButton.Text = "Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 43;
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
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = "1";
            this.quantity.DefaultCellStyle = dataGridViewCellStyle13;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // discountAmount
            // 
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = "0";
            this.discountAmount.DefaultCellStyle = dataGridViewCellStyle14;
            this.discountAmount.HeaderText = "Discount Amount";
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.Width = 104;
            // 
            // discountPercentage
            // 
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0";
            this.discountPercentage.DefaultCellStyle = dataGridViewCellStyle15;
            this.discountPercentage.HeaderText = "Discount %";
            this.discountPercentage.Name = "discountPercentage";
            // 
            // taxPercent
            // 
            this.taxPercent.HeaderText = "Tax %";
            this.taxPercent.Name = "taxPercent";
            this.taxPercent.ReadOnly = true;
            // 
            // taxAmount
            // 
            this.taxAmount.HeaderText = "Tax Amount";
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.ReadOnly = true;
            // 
            // finalPrize
            // 
            this.finalPrize.HeaderText = "Final Prize";
            this.finalPrize.Name = "finalPrize";
            this.finalPrize.ReadOnly = true;
            // 
            // quantityInStock
            // 
            this.quantityInStock.HeaderText = "Quantity In Stock";
            this.quantityInStock.Name = "quantityInStock";
            this.quantityInStock.ReadOnly = true;
            this.quantityInStock.Visible = false;
            // 
            // pricePerItem
            // 
            this.pricePerItem.HeaderText = "Price / Item";
            this.pricePerItem.Name = "pricePerItem";
            this.pricePerItem.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.subTotalAfterDiscountTextBox);
            this.panel1.Controls.Add(this.totalTextBox);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Controls.Add(this.paymentButton);
            this.panel1.Controls.Add(this.subTotalAfterDiscountLabel);
            this.panel1.Controls.Add(this.finalDiscountTextBox);
            this.panel1.Controls.Add(this.totalTaxTextBox);
            this.panel1.Controls.Add(this.subTotalBeforeDiscountTextBox);
            this.panel1.Controls.Add(this.totalTaxLabel);
            this.panel1.Controls.Add(this.discountLabel);
            this.panel1.Controls.Add(this.subTotalLabel);
            this.panel1.Location = new System.Drawing.Point(12, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 123);
            this.panel1.TabIndex = 19;
            // 
            // subTotalAfterDiscountTextBox
            // 
            this.subTotalAfterDiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalAfterDiscountTextBox.Location = new System.Drawing.Point(210, 72);
            this.subTotalAfterDiscountTextBox.Name = "subTotalAfterDiscountTextBox";
            this.subTotalAfterDiscountTextBox.ReadOnly = true;
            this.subTotalAfterDiscountTextBox.Size = new System.Drawing.Size(160, 22);
            this.subTotalAfterDiscountTextBox.TabIndex = 24;
            this.subTotalAfterDiscountTextBox.Text = "0.00";
            this.subTotalAfterDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotalAfterDiscountLabel
            // 
            this.subTotalAfterDiscountLabel.AutoSize = true;
            this.subTotalAfterDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalAfterDiscountLabel.Location = new System.Drawing.Point(37, 75);
            this.subTotalAfterDiscountLabel.Name = "subTotalAfterDiscountLabel";
            this.subTotalAfterDiscountLabel.Size = new System.Drawing.Size(150, 16);
            this.subTotalAfterDiscountLabel.TabIndex = 23;
            this.subTotalAfterDiscountLabel.Text = "Sub Total After Discount";
            // 
            // finalDiscountTextBox
            // 
            this.finalDiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDiscountTextBox.Location = new System.Drawing.Point(486, 33);
            this.finalDiscountTextBox.Name = "finalDiscountTextBox";
            this.finalDiscountTextBox.ReadOnly = true;
            this.finalDiscountTextBox.Size = new System.Drawing.Size(174, 22);
            this.finalDiscountTextBox.TabIndex = 22;
            this.finalDiscountTextBox.Text = "0.00";
            this.finalDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTaxTextBox
            // 
            this.totalTaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTaxTextBox.Location = new System.Drawing.Point(486, 72);
            this.totalTaxTextBox.Name = "totalTaxTextBox";
            this.totalTaxTextBox.ReadOnly = true;
            this.totalTaxTextBox.Size = new System.Drawing.Size(174, 22);
            this.totalTaxTextBox.TabIndex = 26;
            this.totalTaxTextBox.Text = "0.00";
            this.totalTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotalBeforeDiscountTextBox
            // 
            this.subTotalBeforeDiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalBeforeDiscountTextBox.Location = new System.Drawing.Point(210, 29);
            this.subTotalBeforeDiscountTextBox.Name = "subTotalBeforeDiscountTextBox";
            this.subTotalBeforeDiscountTextBox.ReadOnly = true;
            this.subTotalBeforeDiscountTextBox.Size = new System.Drawing.Size(162, 22);
            this.subTotalBeforeDiscountTextBox.TabIndex = 20;
            this.subTotalBeforeDiscountTextBox.Text = "0.00";
            this.subTotalBeforeDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTaxLabel
            // 
            this.totalTaxLabel.AutoSize = true;
            this.totalTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTaxLabel.Location = new System.Drawing.Point(405, 75);
            this.totalTaxLabel.Name = "totalTaxLabel";
            this.totalTaxLabel.Size = new System.Drawing.Size(64, 16);
            this.totalTaxLabel.TabIndex = 25;
            this.totalTaxLabel.Text = "Total Tax";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(405, 33);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(59, 16);
            this.discountLabel.TabIndex = 21;
            this.discountLabel.Text = "Discount";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(37, 33);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(163, 16);
            this.subTotalLabel.TabIndex = 19;
            this.subTotalLabel.Text = "Sub Total Before Discount";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saleDateTimePicker);
            this.Controls.Add(this.saleDateLabel);
            this.Controls.Add(this.transactionNoTextBox);
            this.Controls.Add(this.transactionNoLabel);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.dataGridViewCart);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button searchProductsButton;
        public System.Windows.Forms.TextBox transactionNoTextBox;
        private System.Windows.Forms.Label transactionNoLabel;
        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.Label totalLabel;
        public System.Windows.Forms.TextBox totalTextBox;
        public System.Windows.Forms.DataGridView dataGridViewCart;
        public System.Windows.Forms.Button paymentButton;
        public System.Windows.Forms.DateTimePicker saleDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPrize;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox subTotalAfterDiscountTextBox;
        private System.Windows.Forms.Label subTotalAfterDiscountLabel;
        public System.Windows.Forms.TextBox finalDiscountTextBox;
        public System.Windows.Forms.TextBox totalTaxTextBox;
        public System.Windows.Forms.TextBox subTotalBeforeDiscountTextBox;
        private System.Windows.Forms.Label totalTaxLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label subTotalLabel;
    }
}