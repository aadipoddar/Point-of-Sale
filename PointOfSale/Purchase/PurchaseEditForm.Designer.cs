namespace PointOfSale.Purchase
{
    partial class PurchaseEditForm
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
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.referenceNoLabel = new System.Windows.Forms.Label();
            this.purchaseByTextBox = new System.Windows.Forms.TextBox();
            this.purchaseByLabel = new System.Windows.Forms.Label();
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.pCodeLabel = new System.Windows.Forms.Label();
            this.pcodeTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNoTextBox.Location = new System.Drawing.Point(282, 132);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.Size = new System.Drawing.Size(366, 38);
            this.referenceNoTextBox.TabIndex = 1;
            // 
            // referenceNoLabel
            // 
            this.referenceNoLabel.AutoSize = true;
            this.referenceNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNoLabel.Location = new System.Drawing.Point(17, 131);
            this.referenceNoLabel.Name = "referenceNoLabel";
            this.referenceNoLabel.Size = new System.Drawing.Size(243, 31);
            this.referenceNoLabel.TabIndex = 0;
            this.referenceNoLabel.Text = "Reference Number";
            // 
            // purchaseByTextBox
            // 
            this.purchaseByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseByTextBox.Location = new System.Drawing.Point(282, 192);
            this.purchaseByTextBox.Name = "purchaseByTextBox";
            this.purchaseByTextBox.Size = new System.Drawing.Size(366, 38);
            this.purchaseByTextBox.TabIndex = 3;
            // 
            // purchaseByLabel
            // 
            this.purchaseByLabel.AutoSize = true;
            this.purchaseByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseByLabel.Location = new System.Drawing.Point(17, 189);
            this.purchaseByLabel.Name = "purchaseByLabel";
            this.purchaseByLabel.Size = new System.Drawing.Size(168, 31);
            this.purchaseByLabel.TabIndex = 2;
            this.purchaseByLabel.Text = "Purchase By";
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.CustomFormat = "";
            this.purchaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(282, 252);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(366, 31);
            this.purchaseDateTimePicker.TabIndex = 5;
            this.purchaseDateTimePicker.Value = new System.DateTime(2023, 4, 25, 18, 29, 32, 0);
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateLabel.Location = new System.Drawing.Point(17, 247);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(194, 31);
            this.purchaseDateLabel.TabIndex = 4;
            this.purchaseDateLabel.Text = "Purchase Date";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(282, 366);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(366, 38);
            this.quantityNumericUpDown.TabIndex = 9;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(17, 363);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(116, 31);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(282, 72);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(366, 38);
            this.productNameTextBox.TabIndex = 15;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(17, 73);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(187, 31);
            this.productNameLabel.TabIndex = 14;
            this.productNameLabel.Text = "Product Name";
            // 
            // pCodeLabel
            // 
            this.pCodeLabel.AutoSize = true;
            this.pCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCodeLabel.Location = new System.Drawing.Point(17, 15);
            this.pCodeLabel.Name = "pCodeLabel";
            this.pCodeLabel.Size = new System.Drawing.Size(97, 31);
            this.pCodeLabel.TabIndex = 12;
            this.pCodeLabel.Text = "PCode";
            // 
            // pcodeTextBox
            // 
            this.pcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcodeTextBox.Location = new System.Drawing.Point(282, 12);
            this.pcodeTextBox.Name = "pcodeTextBox";
            this.pcodeTextBox.ReadOnly = true;
            this.pcodeTextBox.Size = new System.Drawing.Size(366, 38);
            this.pcodeTextBox.TabIndex = 13;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(17, 305);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(92, 31);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Done"});
            this.statusComboBox.Location = new System.Drawing.Point(282, 305);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(366, 39);
            this.statusComboBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(350, 446);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(165, 50);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(153, 446);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(165, 50);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // PurchaseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pcodeTextBox);
            this.Controls.Add(this.pCodeLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.purchaseDateTimePicker);
            this.Controls.Add(this.purchaseDateLabel);
            this.Controls.Add(this.purchaseByTextBox);
            this.Controls.Add(this.purchaseByLabel);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(this.referenceNoLabel);
            this.Name = "PurchaseEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Edit";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox referenceNoTextBox;
        private System.Windows.Forms.Label referenceNoLabel;
        public System.Windows.Forms.TextBox purchaseByTextBox;
        private System.Windows.Forms.Label purchaseByLabel;
        private System.Windows.Forms.Label purchaseDateLabel;
        public System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        public System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label pCodeLabel;
        public System.Windows.Forms.TextBox pcodeTextBox;
        private System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
    }
}