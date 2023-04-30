namespace PointOfSale.Products
{
    partial class ProductsListForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.vwShowProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointOfSaleDataSet = new PointOfSale.PointOfSaleDataSet();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.vwShowProductsTableAdapter = new PointOfSale.PointOfSaleDataSetTableAdapters.vwShowProductsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwShowProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSaleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalquantityDataGridViewTextBoxColumn,
            this.tax});
            this.dataGridViewProducts.DataSource = this.vwShowProductsBindingSource;
            this.dataGridViewProducts.Location = new System.Drawing.Point(-1, 55);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.Size = new System.Drawing.Size(904, 423);
            this.dataGridViewProducts.TabIndex = 2;
            this.dataGridViewProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProducts_KeyDown);
            // 
            // vwShowProductsBindingSource
            // 
            this.vwShowProductsBindingSource.DataMember = "vwShowProducts";
            this.vwShowProductsBindingSource.DataSource = this.pointOfSaleDataSet;
            // 
            // pointOfSaleDataSet
            // 
            this.pointOfSaleDataSet.DataSetName = "PointOfSaleDataSet";
            this.pointOfSaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addProductsButton
            // 
            this.addProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsButton.Location = new System.Drawing.Point(680, 9);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(185, 40);
            this.addProductsButton.TabIndex = 1;
            this.addProductsButton.Text = "Add Products";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.addProductsButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(573, 31);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // vwShowProductsTableAdapter
            // 
            this.vwShowProductsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Product Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand Name";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalquantityDataGridViewTextBoxColumn
            // 
            this.totalquantityDataGridViewTextBoxColumn.DataPropertyName = "total_quantity";
            this.totalquantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.totalquantityDataGridViewTextBoxColumn.Name = "totalquantityDataGridViewTextBoxColumn";
            this.totalquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tax
            // 
            this.tax.DataPropertyName = "tax";
            this.tax.HeaderText = "Tax %";
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            // 
            // ProductsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 480);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "ProductsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwShowProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSaleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.TextBox searchTextBox;
        public System.Windows.Forms.DataGridView dataGridViewProducts;
        private PointOfSaleDataSet pointOfSaleDataSet;
        private System.Windows.Forms.BindingSource vwShowProductsBindingSource;
        private PointOfSaleDataSetTableAdapters.vwShowProductsTableAdapter vwShowProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
    }
}