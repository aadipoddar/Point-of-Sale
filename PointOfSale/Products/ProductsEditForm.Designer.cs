namespace PointOfSale.Products
{
    partial class ProductsEditForm
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
            this.pcodeLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.decriptionLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointOfSaleDataSet = new PointOfSale.PointOfSaleDataSet();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.brandTableAdapter = new PointOfSale.PointOfSaleDataSetTableAdapters.BrandTableAdapter();
            this.categoryTableAdapter = new PointOfSale.PointOfSaleDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pcodeLabel
            // 
            this.pcodeLabel.AutoSize = true;
            this.pcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcodeLabel.Location = new System.Drawing.Point(12, 18);
            this.pcodeLabel.Name = "pcodeLabel";
            this.pcodeLabel.Size = new System.Drawing.Size(97, 31);
            this.pcodeLabel.TabIndex = 0;
            this.pcodeLabel.Text = "PCode";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(243, 78);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(366, 38);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // decriptionLabel
            // 
            this.decriptionLabel.AutoSize = true;
            this.decriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decriptionLabel.Location = new System.Drawing.Point(12, 83);
            this.decriptionLabel.Name = "decriptionLabel";
            this.decriptionLabel.Size = new System.Drawing.Size(151, 31);
            this.decriptionLabel.TabIndex = 2;
            this.decriptionLabel.Text = "Description";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(12, 148);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(86, 31);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.Text = "Brand";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(12, 213);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(125, 31);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(12, 278);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(76, 31);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // brandComboBox
            // 
            this.brandComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandComboBox.DataSource = this.brandBindingSource;
            this.brandComboBox.DisplayMember = "brand";
            this.brandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(243, 144);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(366, 39);
            this.brandComboBox.TabIndex = 5;
            this.brandComboBox.ValueMember = "id";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.pointOfSaleDataSet;
            // 
            // pointOfSaleDataSet
            // 
            this.pointOfSaleDataSet.DataSetName = "PointOfSaleDataSet";
            this.pointOfSaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "category";
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(243, 211);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(366, 39);
            this.categoryComboBox.TabIndex = 7;
            this.categoryComboBox.ValueMember = "id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.pointOfSaleDataSet;
            // 
            // pcodeNumericUpDown
            // 
            this.pcodeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcodeNumericUpDown.Location = new System.Drawing.Point(243, 12);
            this.pcodeNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.pcodeNumericUpDown.Name = "pcodeNumericUpDown";
            this.pcodeNumericUpDown.ReadOnly = true;
            this.pcodeNumericUpDown.Size = new System.Drawing.Size(366, 38);
            this.pcodeNumericUpDown.TabIndex = 20;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(243, 278);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(366, 38);
            this.priceNumericUpDown.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(39, 367);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(165, 50);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(232, 367);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(165, 50);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(429, 367);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(165, 50);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.pcodeNumericUpDown);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.decriptionLabel);
            this.Controls.Add(this.pcodeLabel);
            this.Name = "ProductsEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Edit";
            this.Load += new System.EventHandler(this.ProductsEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pcodeLabel;
        private System.Windows.Forms.Label decriptionLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.NumericUpDown pcodeNumericUpDown;
        public System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Button cancelButton;
        private PointOfSaleDataSet pointOfSaleDataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private PointOfSaleDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private PointOfSaleDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.TextBox descriptionTextBox;
        public System.Windows.Forms.ComboBox brandComboBox;
        public System.Windows.Forms.ComboBox categoryComboBox;
    }
}