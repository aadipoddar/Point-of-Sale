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
            components = new System.ComponentModel.Container();
            dataGridViewProducts = new DataGridView();
            pcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vwShowProductsBindingSource = new BindingSource(components);
            pointOfSaleDataSet = new PointOfSaleDataSet();
            vwShowProductsTableAdapter = new PointOfSaleDataSetTableAdapters.vwShowProductsTableAdapter();
            searchTextBox = new TextBox();
            addProductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vwShowProductsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pointOfSaleDataSet).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { pcodeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = vwShowProductsBindingSource;
            dataGridViewProducts.Location = new Point(1, 81);
            dataGridViewProducts.Margin = new Padding(4, 3, 4, 3);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.Size = new Size(917, 510);
            dataGridViewProducts.TabIndex = 3;
            dataGridViewProducts.KeyDown += dataGridViewProducts_KeyDown;
            // 
            // pcodeDataGridViewTextBoxColumn
            // 
            pcodeDataGridViewTextBoxColumn.DataPropertyName = "pcode";
            pcodeDataGridViewTextBoxColumn.HeaderText = "pcode";
            pcodeDataGridViewTextBoxColumn.Name = "pcodeDataGridViewTextBoxColumn";
            pcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            brandDataGridViewTextBoxColumn.HeaderText = "brand";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            categoryDataGridViewTextBoxColumn.HeaderText = "category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwShowProductsBindingSource
            // 
            vwShowProductsBindingSource.DataMember = "vwShowProducts";
            vwShowProductsBindingSource.DataSource = pointOfSaleDataSet;
            // 
            // pointOfSaleDataSet
            // 
            pointOfSaleDataSet.DataSetName = "PointOfSaleDataSet";
            pointOfSaleDataSet.Namespace = "http://tempuri.org/PointOfSaleDataSet.xsd";
            pointOfSaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwShowProductsTableAdapter
            // 
            vwShowProductsTableAdapter.ClearBeforeFill = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(14, 14);
            searchTextBox.Margin = new Padding(4, 3, 4, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search (S)";
            searchTextBox.Size = new Size(480, 35);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // addProductButton
            // 
            addProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addProductButton.Location = new Point(572, 12);
            addProductButton.Margin = new Padding(4, 3, 4, 3);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(317, 43);
            addProductButton.TabIndex = 2;
            addProductButton.Text = "Add Product (A)";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // ProductsListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 590);
            Controls.Add(addProductButton);
            Controls.Add(searchTextBox);
            Controls.Add(dataGridViewProducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductsListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += ProductsListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)vwShowProductsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pointOfSaleDataSet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private PointOfSaleDataSet pointOfSaleDataSet;
        private System.Windows.Forms.BindingSource vwShowProductsBindingSource;
        private PointOfSaleDataSetTableAdapters.vwShowProductsTableAdapter vwShowProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addProductButton;
    }
}