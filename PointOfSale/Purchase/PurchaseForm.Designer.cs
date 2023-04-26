namespace PointOfSale.Purchase
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
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseByTextBox = new System.Windows.Forms.TextBox();
            this.purchaseByLabel = new System.Windows.Forms.Label();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.AllowUserToAddRows = false;
            this.dataGridViewPurchase.AllowUserToDeleteRows = false;
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.quantity});
            this.dataGridViewPurchase.Location = new System.Drawing.Point(1, 130);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.ReadOnly = true;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(953, 400);
            this.dataGridViewPurchase.TabIndex = 6;
            this.dataGridViewPurchase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPurchase_KeyDown);
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
            // purchaseByTextBox
            // 
            this.purchaseByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseByTextBox.Location = new System.Drawing.Point(268, 16);
            this.purchaseByTextBox.Name = "purchaseByTextBox";
            this.purchaseByTextBox.Size = new System.Drawing.Size(366, 38);
            this.purchaseByTextBox.TabIndex = 1;
            // 
            // purchaseByLabel
            // 
            this.purchaseByLabel.AutoSize = true;
            this.purchaseByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseByLabel.Location = new System.Drawing.Point(19, 18);
            this.purchaseByLabel.Name = "purchaseByLabel";
            this.purchaseByLabel.Size = new System.Drawing.Size(168, 31);
            this.purchaseByLabel.TabIndex = 0;
            this.purchaseByLabel.Text = "Purchase By";
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateLabel.Location = new System.Drawing.Point(19, 75);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(194, 31);
            this.purchaseDateLabel.TabIndex = 2;
            this.purchaseDateLabel.Text = "Purchase Date";
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.CustomFormat = "";
            this.purchaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(268, 74);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(366, 31);
            this.purchaseDateTimePicker.TabIndex = 3;
            this.purchaseDateTimePicker.Value = new System.DateTime(2023, 4, 25, 18, 29, 32, 0);
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductsButton.Location = new System.Drawing.Point(686, 12);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(205, 42);
            this.searchProductsButton.TabIndex = 4;
            this.searchProductsButton.Text = "Search Products";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(686, 64);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(205, 42);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 531);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.purchaseDateTimePicker);
            this.Controls.Add(this.purchaseDateLabel);
            this.Controls.Add(this.purchaseByTextBox);
            this.Controls.Add(this.purchaseByLabel);
            this.Controls.Add(this.dataGridViewPurchase);
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox purchaseByTextBox;
        private System.Windows.Forms.Label purchaseByLabel;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
        public System.Windows.Forms.Button searchProductsButton;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}