namespace PointOfSale;

partial class BrandsListForm
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
        searchTextBox = new TextBox();
        addBrandButton = new Button();
        dataGridViewBrands = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        idColumn = new DataGridViewTextBoxColumn();
        brandColumn = new DataGridViewTextBoxColumn();
        editColumn = new DataGridViewButtonColumn();
        deleteColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridViewBrands).BeginInit();
        SuspendLayout();
        // 
        // searchTextBox
        // 
        searchTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        searchTextBox.Location = new Point(12, 12);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.PlaceholderText = "Search (S)";
        searchTextBox.Size = new Size(332, 33);
        searchTextBox.TabIndex = 1;
        searchTextBox.TextChanged += searchTextBox_TextChanged;
        // 
        // addBrandButton
        // 
        addBrandButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        addBrandButton.BackColor = Color.White;
        addBrandButton.Location = new Point(563, 10);
        addBrandButton.Name = "addBrandButton";
        addBrandButton.Size = new Size(226, 35);
        addBrandButton.TabIndex = 0;
        addBrandButton.Text = "Add Brand (A)";
        addBrandButton.UseVisualStyleBackColor = false;
        addBrandButton.Click += addBrandButton_Click;
        addBrandButton.KeyDown += addBrandButton_KeyDown;
        // 
        // dataGridViewBrands
        // 
        dataGridViewBrands.AllowUserToAddRows = false;
        dataGridViewBrands.AllowUserToDeleteRows = false;
        dataGridViewBrands.AllowUserToOrderColumns = true;
        dataGridViewBrands.BackgroundColor = Color.White;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.Black;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = Color.White;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewBrands.Columns.AddRange(new DataGridViewColumn[] { Column1, idColumn, brandColumn, editColumn, deleteColumn });
        dataGridViewBrands.EnableHeadersVisualStyles = false;
        dataGridViewBrands.GridColor = Color.Black;
        dataGridViewBrands.Location = new Point(2, 51);
        dataGridViewBrands.Name = "dataGridViewBrands";
        dataGridViewBrands.ReadOnly = true;
        dataGridViewBrands.RowHeadersVisible = false;
        dataGridViewBrands.RowTemplate.Height = 25;
        dataGridViewBrands.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewBrands.Size = new Size(798, 401);
        dataGridViewBrands.TabIndex = 0;
        dataGridViewBrands.CellContentClick += dataGridViewbrands_CellContentClick;
        dataGridViewBrands.KeyDown += dataGridViewbrands_KeyDown;
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
        idColumn.HeaderText = "ID";
        idColumn.Name = "idColumn";
        idColumn.ReadOnly = true;
        idColumn.Visible = false;
        // 
        // brandColumn
        // 
        brandColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.ForeColor = Color.Black;
        brandColumn.DefaultCellStyle = dataGridViewCellStyle3;
        brandColumn.HeaderText = "BRAND";
        brandColumn.Name = "brandColumn";
        brandColumn.ReadOnly = true;
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
        editColumn.ToolTipText = "Edit Brand Details";
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
        deleteColumn.ToolTipText = "Del";
        deleteColumn.UseColumnTextForButtonValue = true;
        deleteColumn.Width = 65;
        // 
        // BrandsListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(801, 450);
        Controls.Add(searchTextBox);
        Controls.Add(dataGridViewBrands);
        Controls.Add(addBrandButton);
        Name = "BrandsListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Brands";
        KeyDown += BrandsListForm_KeyDown;
        ((System.ComponentModel.ISupportInitialize)dataGridViewBrands).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button addBrandButton;
    private TextBox searchTextBox;
    private DataGridView dataGridViewBrands;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn idColumn;
    private DataGridViewTextBoxColumn brandColumn;
    private DataGridViewButtonColumn editColumn;
    private DataGridViewButtonColumn deleteColumn;
}