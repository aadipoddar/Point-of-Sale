namespace PointOfSale.StockIn;

partial class SearchProductsStockInForm
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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        dataGridViewProducts = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        pCodeColumn = new DataGridViewTextBoxColumn();
        descriptionColumn = new DataGridViewTextBoxColumn();
        qtyOnHandColumn = new DataGridViewTextBoxColumn();
        selectColumn = new DataGridViewButtonColumn();
        searchTextBox = new TextBox();
        quantityLabel = new Label();
        quantityNumericUpDown = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewProducts
        // 
        dataGridViewProducts.AllowUserToAddRows = false;
        dataGridViewProducts.AllowUserToDeleteRows = false;
        dataGridViewProducts.AllowUserToOrderColumns = true;
        dataGridViewProducts.BackgroundColor = Color.White;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.Black;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle4.ForeColor = Color.White;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, pCodeColumn, descriptionColumn, qtyOnHandColumn, selectColumn });
        dataGridViewProducts.EnableHeadersVisualStyles = false;
        dataGridViewProducts.GridColor = Color.Black;
        dataGridViewProducts.Location = new Point(0, 64);
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.ReadOnly = true;
        dataGridViewProducts.RowHeadersVisible = false;
        dataGridViewProducts.RowTemplate.Height = 25;
        dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewProducts.Size = new Size(685, 386);
        dataGridViewProducts.TabIndex = 9;
        dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
        dataGridViewProducts.KeyDown += dataGridViewProducts_KeyDown;
        // 
        // Column1
        // 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle5.BackColor = Color.Black;
        dataGridViewCellStyle5.ForeColor = Color.White;
        Column1.DefaultCellStyle = dataGridViewCellStyle5;
        Column1.HeaderText = "#";
        Column1.Name = "Column1";
        Column1.ReadOnly = true;
        Column1.Width = 39;
        // 
        // pCodeColumn
        // 
        pCodeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        pCodeColumn.HeaderText = "PCODE";
        pCodeColumn.Name = "pCodeColumn";
        pCodeColumn.ReadOnly = true;
        pCodeColumn.Visible = false;
        // 
        // descriptionColumn
        // 
        descriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        descriptionColumn.HeaderText = "DESCRIPTION";
        descriptionColumn.Name = "descriptionColumn";
        descriptionColumn.ReadOnly = true;
        // 
        // qtyOnHandColumn
        // 
        qtyOnHandColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        qtyOnHandColumn.HeaderText = "QTY";
        qtyOnHandColumn.Name = "qtyOnHandColumn";
        qtyOnHandColumn.ReadOnly = true;
        qtyOnHandColumn.Width = 53;
        // 
        // selectColumn
        // 
        selectColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle6.BackColor = Color.FromArgb(128, 128, 255);
        selectColumn.DefaultCellStyle = dataGridViewCellStyle6;
        selectColumn.FlatStyle = FlatStyle.Popup;
        selectColumn.HeaderText = "SELECT";
        selectColumn.Name = "selectColumn";
        selectColumn.ReadOnly = true;
        selectColumn.Resizable = DataGridViewTriState.True;
        selectColumn.SortMode = DataGridViewColumnSortMode.Automatic;
        selectColumn.Text = "SEL (S)";
        selectColumn.ToolTipText = "Select Product";
        selectColumn.UseColumnTextForButtonValue = true;
        selectColumn.Width = 70;
        // 
        // searchTextBox
        // 
        searchTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        searchTextBox.Location = new Point(9, 12);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.PlaceholderText = "Search (S)";
        searchTextBox.Size = new Size(277, 33);
        searchTextBox.TabIndex = 10;
        searchTextBox.TextChanged += searchTextBox_TextChanged;
        // 
        // quantityLabel
        // 
        quantityLabel.AutoSize = true;
        quantityLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        quantityLabel.Location = new Point(331, 15);
        quantityLabel.Name = "quantityLabel";
        quantityLabel.Size = new Size(84, 25);
        quantityLabel.TabIndex = 11;
        quantityLabel.Text = "Quantity";
        // 
        // quantityNumericUpDown
        // 
        quantityNumericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        quantityNumericUpDown.Location = new Point(421, 15);
        quantityNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        quantityNumericUpDown.Name = "quantityNumericUpDown";
        quantityNumericUpDown.Size = new Size(78, 29);
        quantityNumericUpDown.TabIndex = 12;
        quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // SearchProductsStockInForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(690, 450);
        Controls.Add(quantityNumericUpDown);
        Controls.Add(quantityLabel);
        Controls.Add(searchTextBox);
        Controls.Add(dataGridViewProducts);
        Name = "SearchProductsStockInForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Search Products";
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewProducts;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn pCodeColumn;
    private DataGridViewTextBoxColumn descriptionColumn;
    private DataGridViewTextBoxColumn qtyOnHandColumn;
    private DataGridViewButtonColumn selectColumn;
    public TextBox searchTextBox;
    private Label quantityLabel;
    private NumericUpDown quantityNumericUpDown;
}