namespace PointOfSale.Purchase
{
    partial class PurchaseHistoryForm
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
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.filterByDateLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loadRecordsButton = new System.Windows.Forms.Button();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.vwPurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointOfSaleDataSet = new PointOfSale.PointOfSaleDataSet();
            this.vwPurchaseTableAdapter = new PointOfSale.PointOfSaleDataSetTableAdapters.vwPurchaseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSaleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(192, 10);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(155, 31);
            this.startDateTimePicker.TabIndex = 10;
            // 
            // filterByDateLabel
            // 
            this.filterByDateLabel.AutoSize = true;
            this.filterByDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByDateLabel.Location = new System.Drawing.Point(6, 9);
            this.filterByDateLabel.Name = "filterByDateLabel";
            this.filterByDateLabel.Size = new System.Drawing.Size(179, 31);
            this.filterByDateLabel.TabIndex = 11;
            this.filterByDateLabel.Text = "Filter By Date";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(354, 10);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(52, 31);
            this.toLabel.TabIndex = 12;
            this.toLabel.Text = "TO";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(413, 9);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(155, 31);
            this.endDateTimePicker.TabIndex = 13;
            // 
            // loadRecordsButton
            // 
            this.loadRecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadRecordsButton.Location = new System.Drawing.Point(590, 4);
            this.loadRecordsButton.Name = "loadRecordsButton";
            this.loadRecordsButton.Size = new System.Drawing.Size(205, 40);
            this.loadRecordsButton.TabIndex = 14;
            this.loadRecordsButton.Text = "Load Records";
            this.loadRecordsButton.UseVisualStyleBackColor = true;
            this.loadRecordsButton.Click += new System.EventHandler(this.loadRecordsButton_Click);
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.AllowUserToAddRows = false;
            this.dataGridViewPurchase.AllowUserToDeleteRows = false;
            this.dataGridViewPurchase.AutoGenerateColumns = false;
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.purchaseByDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridViewPurchase.DataSource = this.vwPurchaseBindingSource;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(1, 50);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.ReadOnly = true;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(972, 502);
            this.dataGridViewPurchase.TabIndex = 15;
            this.dataGridViewPurchase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPurchase_KeyDown);
            // 
            // vwPurchaseBindingSource
            // 
            this.vwPurchaseBindingSource.DataMember = "vwPurchase";
            this.vwPurchaseBindingSource.DataSource = this.pointOfSaleDataSet;
            // 
            // pointOfSaleDataSet
            // 
            this.pointOfSaleDataSet.DataSetName = "PointOfSaleDataSet";
            this.pointOfSaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwPurchaseTableAdapter
            // 
            this.vwPurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "purchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "Purchase Date";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseByDataGridViewTextBoxColumn
            // 
            this.purchaseByDataGridViewTextBoxColumn.DataPropertyName = "purchaseBy";
            this.purchaseByDataGridViewTextBoxColumn.HeaderText = "Purchase By";
            this.purchaseByDataGridViewTextBoxColumn.Name = "purchaseByDataGridViewTextBoxColumn";
            this.purchaseByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PurchaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 552);
            this.Controls.Add(this.dataGridViewPurchase);
            this.Controls.Add(this.loadRecordsButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.filterByDateLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Name = "PurchaseHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase History";
            this.Load += new System.EventHandler(this.PurchaseHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSaleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label filterByDateLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        public System.Windows.Forms.Button loadRecordsButton;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private PointOfSaleDataSet pointOfSaleDataSet;
        private System.Windows.Forms.BindingSource vwPurchaseBindingSource;
        private PointOfSaleDataSetTableAdapters.vwPurchaseTableAdapter vwPurchaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}