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
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxableTextBox = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
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
            this.price});
            this.dataGridViewCart.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.Size = new System.Drawing.Size(609, 492);
            this.dataGridViewCart.TabIndex = 16;
            this.dataGridViewCart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCart_KeyDown);
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductsButton.Location = new System.Drawing.Point(135, 9);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(250, 42);
            this.searchProductsButton.TabIndex = 17;
            this.searchProductsButton.Text = "Search Products";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // transactionNoTextBox
            // 
            this.transactionNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoTextBox.Location = new System.Drawing.Point(856, 9);
            this.transactionNoTextBox.Name = "transactionNoTextBox";
            this.transactionNoTextBox.ReadOnly = true;
            this.transactionNoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transactionNoTextBox.Size = new System.Drawing.Size(366, 31);
            this.transactionNoTextBox.TabIndex = 19;
            // 
            // transactionNoLabel
            // 
            this.transactionNoLabel.AutoSize = true;
            this.transactionNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoLabel.Location = new System.Drawing.Point(647, 12);
            this.transactionNoLabel.Name = "transactionNoLabel";
            this.transactionNoLabel.Size = new System.Drawing.Size(158, 25);
            this.transactionNoLabel.TabIndex = 18;
            this.transactionNoLabel.Text = "Transaction No";
            // 
            // saleDateTimePicker
            // 
            this.saleDateTimePicker.CustomFormat = "";
            this.saleDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDateTimePicker.Location = new System.Drawing.Point(856, 57);
            this.saleDateTimePicker.Name = "saleDateTimePicker";
            this.saleDateTimePicker.Size = new System.Drawing.Size(366, 31);
            this.saleDateTimePicker.TabIndex = 21;
            this.saleDateTimePicker.Value = new System.DateTime(2023, 4, 25, 18, 29, 32, 0);
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDateLabel.Location = new System.Drawing.Point(647, 63);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(106, 25);
            this.saleDateLabel.TabIndex = 20;
            this.saleDateLabel.Text = "Sale Date";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(647, 226);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(96, 25);
            this.discountLabel.TabIndex = 23;
            this.discountLabel.Text = "Discount";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(647, 178);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(104, 25);
            this.subTotalLabel.TabIndex = 22;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(647, 322);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 25);
            this.totalLabel.TabIndex = 25;
            this.totalLabel.Text = "Total";
            // 
            // taxableLabel
            // 
            this.taxableLabel.AutoSize = true;
            this.taxableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxableLabel.Location = new System.Drawing.Point(647, 274);
            this.taxableLabel.Name = "taxableLabel";
            this.taxableLabel.Size = new System.Drawing.Size(89, 25);
            this.taxableLabel.TabIndex = 24;
            this.taxableLabel.Text = "Taxable";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTextBox.Location = new System.Drawing.Point(856, 175);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subTotalTextBox.Size = new System.Drawing.Size(366, 31);
            this.subTotalTextBox.TabIndex = 26;
            this.subTotalTextBox.Text = "0.00";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(856, 223);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.ReadOnly = true;
            this.discountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discountTextBox.Size = new System.Drawing.Size(366, 31);
            this.discountTextBox.TabIndex = 27;
            this.discountTextBox.Text = "0.00";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(856, 319);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalTextBox.Size = new System.Drawing.Size(366, 31);
            this.totalTextBox.TabIndex = 29;
            this.totalTextBox.Text = "0.00";
            // 
            // taxableTextBox
            // 
            this.taxableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxableTextBox.Location = new System.Drawing.Point(856, 271);
            this.taxableTextBox.Name = "taxableTextBox";
            this.taxableTextBox.ReadOnly = true;
            this.taxableTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taxableTextBox.Size = new System.Drawing.Size(366, 31);
            this.taxableTextBox.TabIndex = 28;
            this.taxableTextBox.Text = "0.00";
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
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.taxableTextBox);
            this.Controls.Add(this.discountTextBox);
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
            this.Text = "0.00";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
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
        public System.Windows.Forms.TextBox discountTextBox;
        public System.Windows.Forms.TextBox totalTextBox;
        public System.Windows.Forms.TextBox taxableTextBox;
        public System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}