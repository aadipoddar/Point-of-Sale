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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockInByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwStockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointOfSaleDataSet = new PointOfSale.PointOfSaleDataSet();
            this.referenceNoLabel = new System.Windows.Forms.Label();
            this.purchaseByTextBox = new System.Windows.Forms.TextBox();
            this.purchaseByLabel = new System.Windows.Forms.Label();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.vwStockInTableAdapter = new PointOfSale.PointOfSaleDataSetTableAdapters.vwStockInTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSaleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.AllowUserToAddRows = false;
            this.dataGridViewPurchase.AllowUserToDeleteRows = false;
            this.dataGridViewPurchase.AutoGenerateColumns = false;
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.referenceNoDataGridViewTextBoxColumn,
            this.pcodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.stockInDateDataGridViewTextBoxColumn,
            this.stockInByDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridViewPurchase.DataSource = this.vwStockInBindingSource;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(1, 178);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.ReadOnly = true;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(953, 352);
            this.dataGridViewPurchase.TabIndex = 8;
            this.dataGridViewPurchase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPurchase_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceNoDataGridViewTextBoxColumn
            // 
            this.referenceNoDataGridViewTextBoxColumn.DataPropertyName = "referenceNo";
            this.referenceNoDataGridViewTextBoxColumn.HeaderText = "Reference No.";
            this.referenceNoDataGridViewTextBoxColumn.Name = "referenceNoDataGridViewTextBoxColumn";
            this.referenceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pcodeDataGridViewTextBoxColumn
            // 
            this.pcodeDataGridViewTextBoxColumn.DataPropertyName = "pcode";
            this.pcodeDataGridViewTextBoxColumn.HeaderText = "PCode";
            this.pcodeDataGridViewTextBoxColumn.Name = "pcodeDataGridViewTextBoxColumn";
            this.pcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockInDateDataGridViewTextBoxColumn
            // 
            this.stockInDateDataGridViewTextBoxColumn.DataPropertyName = "stockInDate";
            this.stockInDateDataGridViewTextBoxColumn.HeaderText = "Purchase Date";
            this.stockInDateDataGridViewTextBoxColumn.Name = "stockInDateDataGridViewTextBoxColumn";
            this.stockInDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockInByDataGridViewTextBoxColumn
            // 
            this.stockInByDataGridViewTextBoxColumn.DataPropertyName = "stockInBy";
            this.stockInByDataGridViewTextBoxColumn.HeaderText = "Purchase By";
            this.stockInByDataGridViewTextBoxColumn.Name = "stockInByDataGridViewTextBoxColumn";
            this.stockInByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwStockInBindingSource
            // 
            this.vwStockInBindingSource.DataMember = "vwStockIn";
            this.vwStockInBindingSource.DataSource = this.pointOfSaleDataSet;
            // 
            // pointOfSaleDataSet
            // 
            this.pointOfSaleDataSet.DataSetName = "PointOfSaleDataSet";
            this.pointOfSaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // referenceNoLabel
            // 
            this.referenceNoLabel.AutoSize = true;
            this.referenceNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNoLabel.Location = new System.Drawing.Point(12, 15);
            this.referenceNoLabel.Name = "referenceNoLabel";
            this.referenceNoLabel.Size = new System.Drawing.Size(243, 31);
            this.referenceNoLabel.TabIndex = 0;
            this.referenceNoLabel.Text = "Reference Number";
            // 
            // purchaseByTextBox
            // 
            this.purchaseByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseByTextBox.Location = new System.Drawing.Point(261, 64);
            this.purchaseByTextBox.Name = "purchaseByTextBox";
            this.purchaseByTextBox.Size = new System.Drawing.Size(366, 38);
            this.purchaseByTextBox.TabIndex = 3;
            // 
            // purchaseByLabel
            // 
            this.purchaseByLabel.AutoSize = true;
            this.purchaseByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseByLabel.Location = new System.Drawing.Point(12, 66);
            this.purchaseByLabel.Name = "purchaseByLabel";
            this.purchaseByLabel.Size = new System.Drawing.Size(168, 31);
            this.purchaseByLabel.TabIndex = 2;
            this.purchaseByLabel.Text = "Purchase By";
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateLabel.Location = new System.Drawing.Point(12, 123);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(194, 31);
            this.purchaseDateLabel.TabIndex = 4;
            this.purchaseDateLabel.Text = "Purchase Date";
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.CustomFormat = "";
            this.purchaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(261, 122);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(366, 31);
            this.purchaseDateTimePicker.TabIndex = 5;
            this.purchaseDateTimePicker.Value = new System.DateTime(2023, 4, 25, 18, 29, 32, 0);
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductsButton.Location = new System.Drawing.Point(686, 12);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(205, 50);
            this.searchProductsButton.TabIndex = 6;
            this.searchProductsButton.Text = "Search Products";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(686, 88);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(205, 50);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNoTextBox.Location = new System.Drawing.Point(261, 12);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.Size = new System.Drawing.Size(366, 38);
            this.referenceNoTextBox.TabIndex = 1;
            this.referenceNoTextBox.TextChanged += new System.EventHandler(this.referenceNoTextBox_TextChanged);
            // 
            // vwStockInTableAdapter
            // 
            this.vwStockInTableAdapter.ClearBeforeFill = true;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 531);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.purchaseDateTimePicker);
            this.Controls.Add(this.purchaseDateLabel);
            this.Controls.Add(this.purchaseByTextBox);
            this.Controls.Add(this.purchaseByLabel);
            this.Controls.Add(this.referenceNoLabel);
            this.Controls.Add(this.dataGridViewPurchase);
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSaleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private PointOfSaleDataSet pointOfSaleDataSet;
        private System.Windows.Forms.BindingSource vwStockInBindingSource;
        private PointOfSaleDataSetTableAdapters.vwStockInTableAdapter vwStockInTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockInByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label referenceNoLabel;
        public System.Windows.Forms.TextBox purchaseByTextBox;
        private System.Windows.Forms.Label purchaseByLabel;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
        public System.Windows.Forms.Button searchProductsButton;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox referenceNoTextBox;
    }
}