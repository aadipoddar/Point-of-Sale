namespace WinForms.PointOfSale.Purchase;

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
        dataGridViewCart = new DataGridView();
        productId = new DataGridViewTextBoxColumn();
        productName = new DataGridViewTextBoxColumn();
        quantity = new DataGridViewTextBoxColumn();
        PricePerQuantity = new DataGridViewTextBoxColumn();
        TaxPercentage = new DataGridViewTextBoxColumn();
        SubTotal = new DataGridViewTextBoxColumn();
        TaxAmount = new DataGridViewTextBoxColumn();
        Total = new DataGridViewTextBoxColumn();
        searchProductsButton = new Button();
        saveButton = new Button();
        totalTextBox = new TextBox();
        totalTaxTextBox = new TextBox();
        subTotalTextBox = new TextBox();
        totalLabel = new Label();
        taxLabel = new Label();
        subTotalLabel = new Label();
        purchaseDateTimePicker = new DateTimePicker();
        purchaseDateLabel = new Label();
        transactionNoTextBox = new TextBox();
        transactionNoLabel = new Label();
        purchaseByTextBox = new TextBox();
        purchaseByLabel = new Label();
        panel1 = new Panel();
        ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridViewCart
        // 
        dataGridViewCart.AllowUserToAddRows = false;
        dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { productId, productName, quantity, PricePerQuantity, TaxPercentage, SubTotal, TaxAmount, Total });
        dataGridViewCart.Location = new Point(13, 100);
        dataGridViewCart.Margin = new Padding(4, 3, 4, 3);
        dataGridViewCart.Name = "dataGridViewCart";
        dataGridViewCart.Size = new Size(1344, 489);
        dataGridViewCart.TabIndex = 7;
        dataGridViewCart.CellClick += dataGridViewCart_CellClick;
        dataGridViewCart.KeyDown += dataGridViewPurchase_KeyDown;
        // 
        // productId
        // 
        productId.HeaderText = "Product ID";
        productId.Name = "productId";
        productId.Visible = false;
        // 
        // productName
        // 
        productName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        productName.HeaderText = "Product Name";
        productName.Name = "productName";
        // 
        // quantity
        // 
        quantity.HeaderText = "Quantity";
        quantity.Name = "quantity";
        // 
        // PricePerQuantity
        // 
        PricePerQuantity.HeaderText = "Price/Quantity";
        PricePerQuantity.Name = "PricePerQuantity";
        // 
        // TaxPercentage
        // 
        TaxPercentage.HeaderText = "Tax %";
        TaxPercentage.Name = "TaxPercentage";
        // 
        // SubTotal
        // 
        SubTotal.HeaderText = "Sub Total";
        SubTotal.Name = "SubTotal";
        // 
        // TaxAmount
        // 
        TaxAmount.HeaderText = "Tax";
        TaxAmount.Name = "TaxAmount";
        // 
        // Total
        // 
        Total.HeaderText = "Total";
        Total.Name = "Total";
        // 
        // searchProductsButton
        // 
        searchProductsButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        searchProductsButton.Location = new Point(13, 12);
        searchProductsButton.Margin = new Padding(4, 3, 4, 3);
        searchProductsButton.Name = "searchProductsButton";
        searchProductsButton.Size = new Size(239, 48);
        searchProductsButton.TabIndex = 6;
        searchProductsButton.Text = "Search Products";
        searchProductsButton.UseVisualStyleBackColor = true;
        searchProductsButton.Click += searchProductsButton_Click;
        // 
        // saveButton
        // 
        saveButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        saveButton.Location = new Point(1090, 80);
        saveButton.Margin = new Padding(4, 3, 4, 3);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(239, 48);
        saveButton.TabIndex = 8;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // totalTextBox
        // 
        totalTextBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        totalTextBox.Location = new Point(565, 17);
        totalTextBox.Margin = new Padding(4, 3, 4, 3);
        totalTextBox.Name = "totalTextBox";
        totalTextBox.ReadOnly = true;
        totalTextBox.Size = new Size(296, 38);
        totalTextBox.TabIndex = 27;
        totalTextBox.Text = "0.00";
        totalTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // totalTaxTextBox
        // 
        totalTaxTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        totalTaxTextBox.Location = new Point(136, 80);
        totalTaxTextBox.Margin = new Padding(4, 3, 4, 3);
        totalTaxTextBox.Name = "totalTaxTextBox";
        totalTaxTextBox.ReadOnly = true;
        totalTaxTextBox.Size = new Size(235, 33);
        totalTaxTextBox.TabIndex = 25;
        totalTaxTextBox.Text = "0.00";
        totalTaxTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // subTotalTextBox
        // 
        subTotalTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        subTotalTextBox.Location = new Point(136, 20);
        subTotalTextBox.Margin = new Padding(4, 3, 4, 3);
        subTotalTextBox.Name = "subTotalTextBox";
        subTotalTextBox.ReadOnly = true;
        subTotalTextBox.Size = new Size(235, 33);
        subTotalTextBox.TabIndex = 19;
        subTotalTextBox.Text = "0.00";
        subTotalTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // totalLabel
        // 
        totalLabel.AutoSize = true;
        totalLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        totalLabel.Location = new Point(482, 20);
        totalLabel.Margin = new Padding(4, 0, 4, 0);
        totalLabel.Name = "totalLabel";
        totalLabel.Size = new Size(75, 31);
        totalLabel.TabIndex = 26;
        totalLabel.Text = "Total";
        // 
        // taxLabel
        // 
        taxLabel.AutoSize = true;
        taxLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        taxLabel.Location = new Point(18, 88);
        taxLabel.Margin = new Padding(4, 0, 4, 0);
        taxLabel.Name = "taxLabel";
        taxLabel.Size = new Size(39, 25);
        taxLabel.TabIndex = 24;
        taxLabel.Text = "Tax";
        // 
        // subTotalLabel
        // 
        subTotalLabel.AutoSize = true;
        subTotalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        subTotalLabel.Location = new Point(18, 23);
        subTotalLabel.Margin = new Padding(4, 0, 4, 0);
        subTotalLabel.Name = "subTotalLabel";
        subTotalLabel.Size = new Size(89, 25);
        subTotalLabel.TabIndex = 18;
        subTotalLabel.Text = "Sub Total";
        // 
        // purchaseDateTimePicker
        // 
        purchaseDateTimePicker.CustomFormat = "";
        purchaseDateTimePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        purchaseDateTimePicker.Location = new Point(741, 53);
        purchaseDateTimePicker.Margin = new Padding(4, 3, 4, 3);
        purchaseDateTimePicker.Name = "purchaseDateTimePicker";
        purchaseDateTimePicker.Size = new Size(298, 33);
        purchaseDateTimePicker.TabIndex = 31;
        purchaseDateTimePicker.Value = new DateTime(2023, 4, 25, 18, 29, 32, 0);
        purchaseDateTimePicker.ValueChanged += purchaseDateTimePicker_ValueChanged;
        // 
        // purchaseDateLabel
        // 
        purchaseDateLabel.AutoSize = true;
        purchaseDateLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        purchaseDateLabel.Location = new Point(742, 20);
        purchaseDateLabel.Margin = new Padding(4, 0, 4, 0);
        purchaseDateLabel.Name = "purchaseDateLabel";
        purchaseDateLabel.Size = new Size(133, 25);
        purchaseDateLabel.TabIndex = 30;
        purchaseDateLabel.Text = "Purchase Date";
        // 
        // transactionNoTextBox
        // 
        transactionNoTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        transactionNoTextBox.Location = new Point(385, 51);
        transactionNoTextBox.Margin = new Padding(4, 3, 4, 3);
        transactionNoTextBox.Name = "transactionNoTextBox";
        transactionNoTextBox.ReadOnly = true;
        transactionNoTextBox.RightToLeft = RightToLeft.Yes;
        transactionNoTextBox.Size = new Size(236, 33);
        transactionNoTextBox.TabIndex = 29;
        // 
        // transactionNoLabel
        // 
        transactionNoLabel.AutoSize = true;
        transactionNoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        transactionNoLabel.Location = new Point(385, 20);
        transactionNoLabel.Margin = new Padding(4, 0, 4, 0);
        transactionNoLabel.Name = "transactionNoLabel";
        transactionNoLabel.Size = new Size(138, 25);
        transactionNoLabel.TabIndex = 28;
        transactionNoLabel.Text = "Transaction No";
        // 
        // purchaseByTextBox
        // 
        purchaseByTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        purchaseByTextBox.Location = new Point(1159, 53);
        purchaseByTextBox.Margin = new Padding(4, 3, 4, 3);
        purchaseByTextBox.Name = "purchaseByTextBox";
        purchaseByTextBox.RightToLeft = RightToLeft.Yes;
        purchaseByTextBox.Size = new Size(197, 33);
        purchaseByTextBox.TabIndex = 33;
        // 
        // purchaseByLabel
        // 
        purchaseByLabel.AutoSize = true;
        purchaseByLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        purchaseByLabel.Location = new Point(1160, 20);
        purchaseByLabel.Margin = new Padding(4, 0, 4, 0);
        purchaseByLabel.Name = "purchaseByLabel";
        purchaseByLabel.Size = new Size(114, 25);
        purchaseByLabel.TabIndex = 32;
        purchaseByLabel.Text = "Purchase By";
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(255, 255, 128);
        panel1.Controls.Add(subTotalTextBox);
        panel1.Controls.Add(subTotalLabel);
        panel1.Controls.Add(taxLabel);
        panel1.Controls.Add(totalTextBox);
        panel1.Controls.Add(totalLabel);
        panel1.Controls.Add(totalTaxTextBox);
        panel1.Controls.Add(saveButton);
        panel1.Location = new Point(13, 595);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(1344, 142);
        panel1.TabIndex = 34;
        // 
        // PurchaseForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1370, 749);
        Controls.Add(panel1);
        Controls.Add(purchaseByTextBox);
        Controls.Add(purchaseByLabel);
        Controls.Add(purchaseDateTimePicker);
        Controls.Add(purchaseDateLabel);
        Controls.Add(transactionNoTextBox);
        Controls.Add(transactionNoLabel);
        Controls.Add(searchProductsButton);
        Controls.Add(dataGridViewCart);
        Margin = new Padding(4, 3, 4, 3);
        Name = "PurchaseForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Purchase";
        ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    public System.Windows.Forms.Button searchProductsButton;
    public System.Windows.Forms.Button saveButton;
    public System.Windows.Forms.DataGridView dataGridViewCart;
    public System.Windows.Forms.TextBox totalTextBox;
    public System.Windows.Forms.TextBox totalTaxTextBox;
    public System.Windows.Forms.TextBox subTotalTextBox;
    private System.Windows.Forms.Label totalLabel;
    private System.Windows.Forms.Label taxLabel;
    private System.Windows.Forms.Label subTotalLabel;
    public System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
    private System.Windows.Forms.Label purchaseDateLabel;
    public System.Windows.Forms.TextBox transactionNoTextBox;
    private System.Windows.Forms.Label transactionNoLabel;
    public System.Windows.Forms.TextBox purchaseByTextBox;
    private System.Windows.Forms.Label purchaseByLabel;
    private System.Windows.Forms.DataGridViewTextBoxColumn productId;
    private System.Windows.Forms.DataGridViewTextBoxColumn productName;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn PricePerQuantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn TaxPercentage;
    private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    private Panel panel1;
}