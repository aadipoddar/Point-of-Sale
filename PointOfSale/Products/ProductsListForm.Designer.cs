namespace PointOfSale.Products;

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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        dataGridViewProducts = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        idColumn = new DataGridViewTextBoxColumn();
        descriptionColumn = new DataGridViewTextBoxColumn();
        brandColumn = new DataGridViewTextBoxColumn();
        categoryColumn = new DataGridViewTextBoxColumn();
        priceColumn = new DataGridViewTextBoxColumn();
        quantityColumn = new DataGridViewTextBoxColumn();
        editColumn = new DataGridViewButtonColumn();
        deleteColumn = new DataGridViewButtonColumn();
        searchTextBox = new TextBox();
        addProductButton = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewProducts
        // 
        dataGridViewProducts.AllowUserToAddRows = false;
        dataGridViewProducts.AllowUserToDeleteRows = false;
        dataGridViewProducts.AllowUserToOrderColumns = true;
        dataGridViewProducts.BackgroundColor = Color.White;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.Black;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = Color.White;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, idColumn, descriptionColumn, brandColumn, categoryColumn, priceColumn, quantityColumn, editColumn, deleteColumn });
        dataGridViewProducts.EnableHeadersVisualStyles = false;
        dataGridViewProducts.GridColor = Color.Black;
        dataGridViewProducts.Location = new Point(1, 61);
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.ReadOnly = true;
        dataGridViewProducts.RowHeadersVisible = false;
        dataGridViewProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        dataGridViewProducts.RowTemplate.Height = 25;
        dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewProducts.Size = new Size(946, 478);
        dataGridViewProducts.TabIndex = 7;
        dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
        dataGridViewProducts.KeyDown += dataGridViewProducts_KeyDown;
        // 
        // Column1
        // 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle2.BackColor = Color.Black;
        dataGridViewCellStyle2.ForeColor = Color.White;
        Column1.DefaultCellStyle = dataGridViewCellStyle2;
        Column1.HeaderText = "#";
        Column1.Name = "Column1";
        Column1.ReadOnly = true;
        Column1.Width = 39;
        // 
        // idColumn
        // 
        idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        idColumn.HeaderText = "PCODE";
        idColumn.Name = "idColumn";
        idColumn.ReadOnly = true;
        idColumn.Width = 70;
        // 
        // descriptionColumn
        // 
        descriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        descriptionColumn.HeaderText = "DESCRIPTION";
        descriptionColumn.Name = "descriptionColumn";
        descriptionColumn.ReadOnly = true;
        // 
        // brandColumn
        // 
        brandColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.ForeColor = Color.Black;
        brandColumn.DefaultCellStyle = dataGridViewCellStyle3;
        brandColumn.HeaderText = "BRAND";
        brandColumn.Name = "brandColumn";
        brandColumn.ReadOnly = true;
        brandColumn.Width = 71;
        // 
        // categoryColumn
        // 
        categoryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        categoryColumn.HeaderText = "CATEGORY";
        categoryColumn.Name = "categoryColumn";
        categoryColumn.ReadOnly = true;
        categoryColumn.Width = 90;
        // 
        // priceColumn
        // 
        priceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        priceColumn.HeaderText = "PRICE";
        priceColumn.Name = "priceColumn";
        priceColumn.ReadOnly = true;
        priceColumn.Width = 63;
        // 
        // quantityColumn
        // 
        quantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        quantityColumn.HeaderText = "QTY";
        quantityColumn.Name = "quantityColumn";
        quantityColumn.ReadOnly = true;
        quantityColumn.Width = 53;
        // 
        // editColumn
        // 
        editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 128, 255);
        editColumn.DefaultCellStyle = dataGridViewCellStyle4;
        editColumn.FlatStyle = FlatStyle.Popup;
        editColumn.HeaderText = "Edit";
        editColumn.Name = "editColumn";
        editColumn.ReadOnly = true;
        editColumn.Resizable = DataGridViewTriState.True;
        editColumn.SortMode = DataGridViewColumnSortMode.Automatic;
        editColumn.Text = "EDIT (E)";
        editColumn.ToolTipText = "Edit Product Details";
        editColumn.UseColumnTextForButtonValue = true;
        editColumn.Width = 52;
        // 
        // deleteColumn
        // 
        deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 128);
        dataGridViewCellStyle5.ForeColor = Color.White;
        deleteColumn.DefaultCellStyle = dataGridViewCellStyle5;
        deleteColumn.FlatStyle = FlatStyle.Popup;
        deleteColumn.HeaderText = "Delete";
        deleteColumn.Name = "deleteColumn";
        deleteColumn.ReadOnly = true;
        deleteColumn.Resizable = DataGridViewTriState.True;
        deleteColumn.SortMode = DataGridViewColumnSortMode.Automatic;
        deleteColumn.Text = "DEL (D)";
        deleteColumn.ToolTipText = "Delete Product";
        deleteColumn.UseColumnTextForButtonValue = true;
        deleteColumn.Width = 65;
        // 
        // searchTextBox
        // 
        searchTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        searchTextBox.Location = new Point(12, 12);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.PlaceholderText = "Search (S)";
        searchTextBox.Size = new Size(552, 33);
        searchTextBox.TabIndex = 0;
        searchTextBox.TextChanged += searchTextBox_TextChanged;
        // 
        // addProductButton
        // 
        addProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        addProductButton.BackColor = Color.White;
        addProductButton.Location = new Point(709, 12);
        addProductButton.Name = "addProductButton";
        addProductButton.Size = new Size(226, 35);
        addProductButton.TabIndex = 1;
        addProductButton.Text = "Add Product (A)";
        addProductButton.UseVisualStyleBackColor = false;
        addProductButton.Click += addProductButton_Click;
        addProductButton.KeyDown += addProductButton_KeyDown;
        // 
        // ProductsListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(947, 535);
        Controls.Add(addProductButton);
        Controls.Add(dataGridViewProducts);
        Controls.Add(searchTextBox);
        Name = "ProductsListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Products";
        KeyDown += ProductsListForm_KeyDown;
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private DataGridView dataGridViewProducts;
    private TextBox searchTextBox;
    private Button addProductButton;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn idColumn;
    private DataGridViewTextBoxColumn descriptionColumn;
    private DataGridViewTextBoxColumn brandColumn;
    private DataGridViewTextBoxColumn categoryColumn;
    private DataGridViewTextBoxColumn priceColumn;
    private DataGridViewTextBoxColumn quantityColumn;
    private DataGridViewButtonColumn editColumn;
    private DataGridViewButtonColumn deleteColumn;
}