namespace PointOfSale.Cashier
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
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.transactionNoTextBox = new System.Windows.Forms.TextBox();
            this.transactionNoLabel = new System.Windows.Forms.Label();
            this.saleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxableLabel = new System.Windows.Forms.Label();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxableTextBox = new System.Windows.Forms.TextBox();
            this.updateProductPanel = new System.Windows.Forms.Panel();
            this.discountPercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.discountAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.finalDiscountTextBox = new System.Windows.Forms.TextBox();
            this.subTotalAfterDiscountTextBox = new System.Windows.Forms.TextBox();
            this.subTotalAfterDiscountLabel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPrize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.updateProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountPercentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.productName,
            this.quantity,
            this.price,
            this.discount,
            this.discountAmount,
            this.discountPercentage,
            this.finalPrize,
            this.quantityInStock,
            this.pricePerItem});
            this.dataGridViewCart.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.Size = new System.Drawing.Size(860, 592);
            this.dataGridViewCart.TabIndex = 1;
            this.dataGridViewCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellClick);
            this.dataGridViewCart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCart_KeyDown);
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
            this.transactionNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoTextBox.Location = new System.Drawing.Point(1071, 9);
            this.transactionNoTextBox.Name = "transactionNoTextBox";
            this.transactionNoTextBox.ReadOnly = true;
            this.transactionNoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transactionNoTextBox.Size = new System.Drawing.Size(254, 31);
            this.transactionNoTextBox.TabIndex = 14;
            // 
            // transactionNoLabel
            // 
            this.transactionNoLabel.AutoSize = true;
            this.transactionNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoLabel.Location = new System.Drawing.Point(880, 12);
            this.transactionNoLabel.Name = "transactionNoLabel";
            this.transactionNoLabel.Size = new System.Drawing.Size(158, 25);
            this.transactionNoLabel.TabIndex = 13;
            this.transactionNoLabel.Text = "Transaction No";
            // 
            // saleDateTimePicker
            // 
            this.saleDateTimePicker.CustomFormat = "";
            this.saleDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDateTimePicker.Location = new System.Drawing.Point(1071, 57);
            this.saleDateTimePicker.Name = "saleDateTimePicker";
            this.saleDateTimePicker.Size = new System.Drawing.Size(254, 31);
            this.saleDateTimePicker.TabIndex = 16;
            this.saleDateTimePicker.Value = new System.DateTime(2023, 4, 25, 18, 29, 32, 0);
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDateLabel.Location = new System.Drawing.Point(880, 63);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(106, 25);
            this.saleDateLabel.TabIndex = 15;
            this.saleDateLabel.Text = "Sale Date";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(880, 362);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(96, 25);
            this.discountLabel.TabIndex = 5;
            this.discountLabel.Text = "Discount";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(880, 316);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(228, 24);
            this.subTotalLabel.TabIndex = 3;
            this.subTotalLabel.Text = "Sub Total Before Discount";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(880, 502);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(75, 31);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // taxableLabel
            // 
            this.taxableLabel.AutoSize = true;
            this.taxableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxableLabel.Location = new System.Drawing.Point(880, 455);
            this.taxableLabel.Name = "taxableLabel";
            this.taxableLabel.Size = new System.Drawing.Size(89, 25);
            this.taxableLabel.TabIndex = 9;
            this.taxableLabel.Text = "Taxable";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTextBox.Location = new System.Drawing.Point(1123, 312);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(202, 31);
            this.subTotalTextBox.TabIndex = 4;
            this.subTotalTextBox.Text = "0.00";
            this.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(1071, 500);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(254, 38);
            this.totalTextBox.TabIndex = 12;
            this.totalTextBox.Text = "0.00";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // taxableTextBox
            // 
            this.taxableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxableTextBox.Location = new System.Drawing.Point(1071, 453);
            this.taxableTextBox.Name = "taxableTextBox";
            this.taxableTextBox.ReadOnly = true;
            this.taxableTextBox.Size = new System.Drawing.Size(254, 31);
            this.taxableTextBox.TabIndex = 10;
            this.taxableTextBox.Text = "0.00";
            this.taxableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // updateProductPanel
            // 
            this.updateProductPanel.BackColor = System.Drawing.Color.Silver;
            this.updateProductPanel.Controls.Add(this.deleteProduct);
            this.updateProductPanel.Controls.Add(this.discountPercentNumericUpDown);
            this.updateProductPanel.Controls.Add(this.discountPercentLabel);
            this.updateProductPanel.Controls.Add(this.orLabel);
            this.updateProductPanel.Controls.Add(this.discountAmountNumericUpDown);
            this.updateProductPanel.Controls.Add(this.discountAmountLabel);
            this.updateProductPanel.Controls.Add(this.quantityNumericUpDown);
            this.updateProductPanel.Controls.Add(this.quantityLabel);
            this.updateProductPanel.Location = new System.Drawing.Point(885, 100);
            this.updateProductPanel.Name = "updateProductPanel";
            this.updateProductPanel.Size = new System.Drawing.Size(440, 199);
            this.updateProductPanel.TabIndex = 2;
            this.updateProductPanel.Visible = false;
            // 
            // discountPercentNumericUpDown
            // 
            this.discountPercentNumericUpDown.DecimalPlaces = 2;
            this.discountPercentNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPercentNumericUpDown.Location = new System.Drawing.Point(186, 113);
            this.discountPercentNumericUpDown.Name = "discountPercentNumericUpDown";
            this.discountPercentNumericUpDown.Size = new System.Drawing.Size(254, 26);
            this.discountPercentNumericUpDown.TabIndex = 6;
            this.discountPercentNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountPercentNumericUpDown.ValueChanged += new System.EventHandler(this.discountPercentNumericUpDown_ValueChanged);
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.AutoSize = true;
            this.discountPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPercentLabel.Location = new System.Drawing.Point(3, 119);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(90, 20);
            this.discountPercentLabel.TabIndex = 5;
            this.discountPercentLabel.Text = "Discount %";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.Location = new System.Drawing.Point(160, 82);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(51, 20);
            this.orLabel.TabIndex = 4;
            this.orLabel.Text = "- OR -";
            // 
            // discountAmountNumericUpDown
            // 
            this.discountAmountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountAmountNumericUpDown.Location = new System.Drawing.Point(184, 45);
            this.discountAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.discountAmountNumericUpDown.Name = "discountAmountNumericUpDown";
            this.discountAmountNumericUpDown.Size = new System.Drawing.Size(254, 26);
            this.discountAmountNumericUpDown.TabIndex = 3;
            this.discountAmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountAmountNumericUpDown.ValueChanged += new System.EventHandler(this.discountAmountNumericUpDown_ValueChanged);
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountAmountLabel.Location = new System.Drawing.Point(2, 45);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(132, 20);
            this.discountAmountLabel.TabIndex = 2;
            this.discountAmountLabel.Text = "Discount Amount";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.quantityNumericUpDown.Size = new System.Drawing.Size(254, 26);
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
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(2, 8);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(68, 20);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity";
            // 
            // finalDiscountTextBox
            // 
            this.finalDiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDiscountTextBox.Location = new System.Drawing.Point(1123, 359);
            this.finalDiscountTextBox.Name = "finalDiscountTextBox";
            this.finalDiscountTextBox.ReadOnly = true;
            this.finalDiscountTextBox.Size = new System.Drawing.Size(202, 31);
            this.finalDiscountTextBox.TabIndex = 6;
            this.finalDiscountTextBox.Text = "0.00";
            this.finalDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotalAfterDiscountTextBox
            // 
            this.subTotalAfterDiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalAfterDiscountTextBox.Location = new System.Drawing.Point(1123, 406);
            this.subTotalAfterDiscountTextBox.Name = "subTotalAfterDiscountTextBox";
            this.subTotalAfterDiscountTextBox.ReadOnly = true;
            this.subTotalAfterDiscountTextBox.Size = new System.Drawing.Size(200, 31);
            this.subTotalAfterDiscountTextBox.TabIndex = 8;
            this.subTotalAfterDiscountTextBox.Text = "0.00";
            this.subTotalAfterDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotalAfterDiscountLabel
            // 
            this.subTotalAfterDiscountLabel.AutoSize = true;
            this.subTotalAfterDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalAfterDiscountLabel.Location = new System.Drawing.Point(878, 409);
            this.subTotalAfterDiscountLabel.Name = "subTotalAfterDiscountLabel";
            this.subTotalAfterDiscountLabel.Size = new System.Drawing.Size(211, 24);
            this.subTotalAfterDiscountLabel.TabIndex = 7;
            this.subTotalAfterDiscountLabel.Text = "Sub Total After Discount";
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // discountAmount
            // 
            this.discountAmount.HeaderText = "Discount Amount";
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.ReadOnly = true;
            this.discountAmount.Visible = false;
            // 
            // discountPercentage
            // 
            this.discountPercentage.HeaderText = "Discount %";
            this.discountPercentage.Name = "discountPercentage";
            this.discountPercentage.ReadOnly = true;
            this.discountPercentage.Visible = false;
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
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.Location = new System.Drawing.Point(882, 563);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(156, 59);
            this.paymentButton.TabIndex = 18;
            this.paymentButton.Text = "Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 661);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.subTotalAfterDiscountTextBox);
            this.Controls.Add(this.subTotalAfterDiscountLabel);
            this.Controls.Add(this.finalDiscountTextBox);
            this.Controls.Add(this.updateProductPanel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.taxableTextBox);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxableLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.subTotalLabel);
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
            this.updateProductPanel.ResumeLayout(false);
            this.updateProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountPercentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button searchProductsButton;
        public System.Windows.Forms.TextBox transactionNoTextBox;
        private System.Windows.Forms.Label transactionNoLabel;
        private System.Windows.Forms.DateTimePicker saleDateTimePicker;
        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxableLabel;
        public System.Windows.Forms.TextBox subTotalTextBox;
        public System.Windows.Forms.TextBox totalTextBox;
        public System.Windows.Forms.TextBox taxableTextBox;
        public System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Panel updateProductPanel;
        public System.Windows.Forms.TextBox finalDiscountTextBox;
        public System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label orLabel;
        public System.Windows.Forms.NumericUpDown discountAmountNumericUpDown;
        private System.Windows.Forms.Label discountAmountLabel;
        public System.Windows.Forms.NumericUpDown discountPercentNumericUpDown;
        private System.Windows.Forms.Label discountPercentLabel;
        public System.Windows.Forms.TextBox subTotalAfterDiscountTextBox;
        private System.Windows.Forms.Label subTotalAfterDiscountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPrize;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerItem;
        public System.Windows.Forms.Button deleteProduct;
        public System.Windows.Forms.Button paymentButton;
    }
}