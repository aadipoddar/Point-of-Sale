namespace WinForms.PointOfSale.Products;

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
        dataGridViewProducts = new DataGridView();
        addProductsButton = new Button();
        searchTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewProducts
        // 
        dataGridViewProducts.AllowUserToAddRows = false;
        dataGridViewProducts.AllowUserToDeleteRows = false;
        dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewProducts.Location = new Point(-1, 63);
        dataGridViewProducts.Margin = new Padding(4, 3, 4, 3);
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.ReadOnly = true;
        dataGridViewProducts.Size = new Size(1055, 488);
        dataGridViewProducts.TabIndex = 2;
        dataGridViewProducts.KeyDown += dataGridViewProducts_KeyDown;
        // 
        // addProductsButton
        // 
        addProductsButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        addProductsButton.Location = new Point(793, 10);
        addProductsButton.Margin = new Padding(4, 3, 4, 3);
        addProductsButton.Name = "addProductsButton";
        addProductsButton.Size = new Size(216, 46);
        addProductsButton.TabIndex = 1;
        addProductsButton.Text = "Add Products";
        addProductsButton.UseVisualStyleBackColor = true;
        addProductsButton.Click += addProductsButton_Click;
        // 
        // searchTextBox
        // 
        searchTextBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        searchTextBox.Location = new Point(14, 14);
        searchTextBox.Margin = new Padding(4, 3, 4, 3);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.Size = new Size(668, 31);
        searchTextBox.TabIndex = 0;
        searchTextBox.TextChanged += searchTextBox_TextChanged;
        // 
        // ProductsListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1055, 554);
        Controls.Add(searchTextBox);
        Controls.Add(addProductsButton);
        Controls.Add(dataGridViewProducts);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ProductsListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Products";
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.Button addProductsButton;
    private System.Windows.Forms.TextBox searchTextBox;
    public System.Windows.Forms.DataGridView dataGridViewProducts;
}