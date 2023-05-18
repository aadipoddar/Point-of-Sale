namespace WinForms.PointOfSale.Sale;

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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        dataGridViewCart = new DataGridView();
        Id = new DataGridViewTextBoxColumn();
        productName = new DataGridViewTextBoxColumn();
        quantity = new DataGridViewTextBoxColumn();
        price = new DataGridViewTextBoxColumn();
        discountAmount = new DataGridViewTextBoxColumn();
        discountPercentage = new DataGridViewTextBoxColumn();
        taxPercent = new DataGridViewTextBoxColumn();
        taxAmount = new DataGridViewTextBoxColumn();
        finalPrize = new DataGridViewTextBoxColumn();
        quantityInStock = new DataGridViewTextBoxColumn();
        pricePerItem = new DataGridViewTextBoxColumn();
        searchProductsButton = new Button();
        transactionNoTextBox = new TextBox();
        transactionNoLabel = new Label();
        saleDateTimePicker = new DateTimePicker();
        saleDateLabel = new Label();
        totalLabel = new Label();
        totalTextBox = new TextBox();
        paymentButton = new Button();
        panel1 = new Panel();
        subTotalAfterDiscountTextBox = new TextBox();
        subTotalAfterDiscountLabel = new Label();
        finalDiscountTextBox = new TextBox();
        totalTaxTextBox = new TextBox();
        subTotalBeforeDiscountTextBox = new TextBox();
        totalTaxLabel = new Label();
        discountLabel = new Label();
        subTotalLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridViewCart
        // 
        dataGridViewCart.AllowUserToAddRows = false;
        dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { Id, productName, quantity, price, discountAmount, discountPercentage, taxPercent, taxAmount, finalPrize, quantityInStock, pricePerItem });
        dataGridViewCart.Location = new Point(13, 67);
        dataGridViewCart.Margin = new Padding(4, 3, 4, 3);
        dataGridViewCart.Name = "dataGridViewCart";
        dataGridViewCart.Size = new Size(1344, 534);
        dataGridViewCart.TabIndex = 1;
        dataGridViewCart.CellEndEdit += dataGridViewCart_CellEndEdit;
        // 
        // Id
        // 
        Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Id.HeaderText = "ID";
        Id.Name = "Id";
        Id.ReadOnly = true;
        Id.Width = 43;
        // 
        // productName
        // 
        productName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        productName.HeaderText = "Product Name";
        productName.Name = "productName";
        productName.ReadOnly = true;
        // 
        // quantity
        // 
        dataGridViewCellStyle1.Format = "N0";
        dataGridViewCellStyle1.NullValue = "1";
        quantity.DefaultCellStyle = dataGridViewCellStyle1;
        quantity.HeaderText = "Quantity";
        quantity.Name = "quantity";
        // 
        // price
        // 
        price.HeaderText = "Price";
        price.Name = "price";
        price.ReadOnly = true;
        // 
        // discountAmount
        // 
        dataGridViewCellStyle2.Format = "N0";
        dataGridViewCellStyle2.NullValue = "0";
        discountAmount.DefaultCellStyle = dataGridViewCellStyle2;
        discountAmount.HeaderText = "Discount Amount";
        discountAmount.Name = "discountAmount";
        discountAmount.Width = 104;
        // 
        // discountPercentage
        // 
        dataGridViewCellStyle3.Format = "N2";
        dataGridViewCellStyle3.NullValue = "0";
        discountPercentage.DefaultCellStyle = dataGridViewCellStyle3;
        discountPercentage.HeaderText = "Discount %";
        discountPercentage.Name = "discountPercentage";
        // 
        // taxPercent
        // 
        taxPercent.HeaderText = "Tax %";
        taxPercent.Name = "taxPercent";
        taxPercent.ReadOnly = true;
        // 
        // taxAmount
        // 
        taxAmount.HeaderText = "Tax Amount";
        taxAmount.Name = "taxAmount";
        taxAmount.ReadOnly = true;
        // 
        // finalPrize
        // 
        finalPrize.HeaderText = "Final Prize";
        finalPrize.Name = "finalPrize";
        finalPrize.ReadOnly = true;
        // 
        // quantityInStock
        // 
        quantityInStock.HeaderText = "Quantity In Stock";
        quantityInStock.Name = "quantityInStock";
        quantityInStock.ReadOnly = true;
        quantityInStock.Visible = false;
        // 
        // pricePerItem
        // 
        pricePerItem.HeaderText = "Price / Item";
        pricePerItem.Name = "pricePerItem";
        pricePerItem.ReadOnly = true;
        // 
        // searchProductsButton
        // 
        searchProductsButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        searchProductsButton.Location = new Point(14, 7);
        searchProductsButton.Margin = new Padding(4, 3, 4, 3);
        searchProductsButton.Name = "searchProductsButton";
        searchProductsButton.Size = new Size(292, 48);
        searchProductsButton.TabIndex = 0;
        searchProductsButton.Text = "Search Products";
        searchProductsButton.UseVisualStyleBackColor = true;
        searchProductsButton.Click += searchProductsButton_Click;
        // 
        // transactionNoTextBox
        // 
        transactionNoTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        transactionNoTextBox.Location = new Point(538, 15);
        transactionNoTextBox.Margin = new Padding(4, 3, 4, 3);
        transactionNoTextBox.Name = "transactionNoTextBox";
        transactionNoTextBox.ReadOnly = true;
        transactionNoTextBox.RightToLeft = RightToLeft.Yes;
        transactionNoTextBox.Size = new Size(245, 26);
        transactionNoTextBox.TabIndex = 14;
        // 
        // transactionNoLabel
        // 
        transactionNoLabel.AutoSize = true;
        transactionNoLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        transactionNoLabel.Location = new Point(414, 18);
        transactionNoLabel.Margin = new Padding(4, 0, 4, 0);
        transactionNoLabel.Name = "transactionNoLabel";
        transactionNoLabel.Size = new Size(116, 20);
        transactionNoLabel.TabIndex = 13;
        transactionNoLabel.Text = "Transaction No";
        // 
        // saleDateTimePicker
        // 
        saleDateTimePicker.CustomFormat = "";
        saleDateTimePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        saleDateTimePicker.Location = new Point(1081, 18);
        saleDateTimePicker.Margin = new Padding(4, 3, 4, 3);
        saleDateTimePicker.Name = "saleDateTimePicker";
        saleDateTimePicker.Size = new Size(276, 26);
        saleDateTimePicker.TabIndex = 16;
        saleDateTimePicker.Value = new DateTime(2023, 4, 25, 18, 29, 32, 0);
        saleDateTimePicker.ValueChanged += saleDateTimePicker_ValueChanged;
        // 
        // saleDateLabel
        // 
        saleDateLabel.AutoSize = true;
        saleDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        saleDateLabel.Location = new Point(993, 21);
        saleDateLabel.Margin = new Padding(4, 0, 4, 0);
        saleDateLabel.Name = "saleDateLabel";
        saleDateLabel.Size = new Size(80, 20);
        saleDateLabel.TabIndex = 15;
        saleDateLabel.Text = "Sale Date";
        // 
        // totalLabel
        // 
        totalLabel.AutoSize = true;
        totalLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        totalLabel.Location = new Point(1002, 29);
        totalLabel.Margin = new Padding(4, 0, 4, 0);
        totalLabel.Name = "totalLabel";
        totalLabel.Size = new Size(75, 31);
        totalLabel.TabIndex = 11;
        totalLabel.Text = "Total";
        // 
        // totalTextBox
        // 
        totalTextBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        totalTextBox.Location = new Point(1097, 24);
        totalTextBox.Margin = new Padding(4, 3, 4, 3);
        totalTextBox.Name = "totalTextBox";
        totalTextBox.ReadOnly = true;
        totalTextBox.Size = new Size(236, 38);
        totalTextBox.TabIndex = 12;
        totalTextBox.Text = "0.00";
        totalTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // paymentButton
        // 
        paymentButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        paymentButton.Location = new Point(1158, 71);
        paymentButton.Margin = new Padding(4, 3, 4, 3);
        paymentButton.Name = "paymentButton";
        paymentButton.Size = new Size(182, 68);
        paymentButton.TabIndex = 18;
        paymentButton.Text = "Payment";
        paymentButton.UseVisualStyleBackColor = true;
        paymentButton.Click += paymentButton_Click;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(255, 255, 128);
        panel1.Controls.Add(subTotalAfterDiscountTextBox);
        panel1.Controls.Add(totalTextBox);
        panel1.Controls.Add(totalLabel);
        panel1.Controls.Add(paymentButton);
        panel1.Controls.Add(subTotalAfterDiscountLabel);
        panel1.Controls.Add(finalDiscountTextBox);
        panel1.Controls.Add(totalTaxTextBox);
        panel1.Controls.Add(subTotalBeforeDiscountTextBox);
        panel1.Controls.Add(totalTaxLabel);
        panel1.Controls.Add(discountLabel);
        panel1.Controls.Add(subTotalLabel);
        panel1.Location = new Point(13, 607);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(1344, 142);
        panel1.TabIndex = 19;
        // 
        // subTotalAfterDiscountTextBox
        // 
        subTotalAfterDiscountTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        subTotalAfterDiscountTextBox.Location = new Point(245, 83);
        subTotalAfterDiscountTextBox.Margin = new Padding(4, 3, 4, 3);
        subTotalAfterDiscountTextBox.Name = "subTotalAfterDiscountTextBox";
        subTotalAfterDiscountTextBox.ReadOnly = true;
        subTotalAfterDiscountTextBox.Size = new Size(186, 22);
        subTotalAfterDiscountTextBox.TabIndex = 24;
        subTotalAfterDiscountTextBox.Text = "0.00";
        subTotalAfterDiscountTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // subTotalAfterDiscountLabel
        // 
        subTotalAfterDiscountLabel.AutoSize = true;
        subTotalAfterDiscountLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        subTotalAfterDiscountLabel.Location = new Point(43, 87);
        subTotalAfterDiscountLabel.Margin = new Padding(4, 0, 4, 0);
        subTotalAfterDiscountLabel.Name = "subTotalAfterDiscountLabel";
        subTotalAfterDiscountLabel.Size = new Size(150, 16);
        subTotalAfterDiscountLabel.TabIndex = 23;
        subTotalAfterDiscountLabel.Text = "Sub Total After Discount";
        // 
        // finalDiscountTextBox
        // 
        finalDiscountTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        finalDiscountTextBox.Location = new Point(567, 38);
        finalDiscountTextBox.Margin = new Padding(4, 3, 4, 3);
        finalDiscountTextBox.Name = "finalDiscountTextBox";
        finalDiscountTextBox.ReadOnly = true;
        finalDiscountTextBox.Size = new Size(202, 22);
        finalDiscountTextBox.TabIndex = 22;
        finalDiscountTextBox.Text = "0.00";
        finalDiscountTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // totalTaxTextBox
        // 
        totalTaxTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        totalTaxTextBox.Location = new Point(567, 83);
        totalTaxTextBox.Margin = new Padding(4, 3, 4, 3);
        totalTaxTextBox.Name = "totalTaxTextBox";
        totalTaxTextBox.ReadOnly = true;
        totalTaxTextBox.Size = new Size(202, 22);
        totalTaxTextBox.TabIndex = 26;
        totalTaxTextBox.Text = "0.00";
        totalTaxTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // subTotalBeforeDiscountTextBox
        // 
        subTotalBeforeDiscountTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        subTotalBeforeDiscountTextBox.Location = new Point(245, 33);
        subTotalBeforeDiscountTextBox.Margin = new Padding(4, 3, 4, 3);
        subTotalBeforeDiscountTextBox.Name = "subTotalBeforeDiscountTextBox";
        subTotalBeforeDiscountTextBox.ReadOnly = true;
        subTotalBeforeDiscountTextBox.Size = new Size(188, 22);
        subTotalBeforeDiscountTextBox.TabIndex = 20;
        subTotalBeforeDiscountTextBox.Text = "0.00";
        subTotalBeforeDiscountTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // totalTaxLabel
        // 
        totalTaxLabel.AutoSize = true;
        totalTaxLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        totalTaxLabel.Location = new Point(472, 87);
        totalTaxLabel.Margin = new Padding(4, 0, 4, 0);
        totalTaxLabel.Name = "totalTaxLabel";
        totalTaxLabel.Size = new Size(64, 16);
        totalTaxLabel.TabIndex = 25;
        totalTaxLabel.Text = "Total Tax";
        // 
        // discountLabel
        // 
        discountLabel.AutoSize = true;
        discountLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        discountLabel.Location = new Point(472, 38);
        discountLabel.Margin = new Padding(4, 0, 4, 0);
        discountLabel.Name = "discountLabel";
        discountLabel.Size = new Size(59, 16);
        discountLabel.TabIndex = 21;
        discountLabel.Text = "Discount";
        // 
        // subTotalLabel
        // 
        subTotalLabel.AutoSize = true;
        subTotalLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        subTotalLabel.Location = new Point(43, 38);
        subTotalLabel.Margin = new Padding(4, 0, 4, 0);
        subTotalLabel.Name = "subTotalLabel";
        subTotalLabel.Size = new Size(163, 16);
        subTotalLabel.TabIndex = 19;
        subTotalLabel.Text = "Sub Total Before Discount";
        // 
        // SaleForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1370, 749);
        Controls.Add(panel1);
        Controls.Add(saleDateTimePicker);
        Controls.Add(saleDateLabel);
        Controls.Add(transactionNoTextBox);
        Controls.Add(transactionNoLabel);
        Controls.Add(searchProductsButton);
        Controls.Add(dataGridViewCart);
        Margin = new Padding(4, 3, 4, 3);
        Name = "SaleForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sale";
        ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    public System.Windows.Forms.Button searchProductsButton;
    public System.Windows.Forms.TextBox transactionNoTextBox;
    private System.Windows.Forms.Label transactionNoLabel;
    private System.Windows.Forms.Label saleDateLabel;
    private System.Windows.Forms.Label totalLabel;
    public System.Windows.Forms.TextBox totalTextBox;
    public System.Windows.Forms.DataGridView dataGridViewCart;
    public System.Windows.Forms.Button paymentButton;
    public System.Windows.Forms.DateTimePicker saleDateTimePicker;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn productName;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn price;
    private System.Windows.Forms.DataGridViewTextBoxColumn discountAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentage;
    private System.Windows.Forms.DataGridViewTextBoxColumn taxPercent;
    private System.Windows.Forms.DataGridViewTextBoxColumn taxAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn finalPrize;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStock;
    private System.Windows.Forms.DataGridViewTextBoxColumn pricePerItem;
    private System.Windows.Forms.Panel panel1;
    public System.Windows.Forms.TextBox subTotalAfterDiscountTextBox;
    private System.Windows.Forms.Label subTotalAfterDiscountLabel;
    public System.Windows.Forms.TextBox finalDiscountTextBox;
    public System.Windows.Forms.TextBox totalTaxTextBox;
    public System.Windows.Forms.TextBox subTotalBeforeDiscountTextBox;
    private System.Windows.Forms.Label totalTaxLabel;
    private System.Windows.Forms.Label discountLabel;
    private System.Windows.Forms.Label subTotalLabel;
}