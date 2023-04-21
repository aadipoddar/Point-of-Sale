namespace PointOfSale.Categories;

partial class CategoriesListForm
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
        dataGridViewCategories = new DataGridView();
        addCategoryButton = new Button();
        searchTextBox = new TextBox();
        Column1 = new DataGridViewTextBoxColumn();
        idColumn = new DataGridViewTextBoxColumn();
        categoryColumn = new DataGridViewTextBoxColumn();
        editColumn = new DataGridViewButtonColumn();
        deleteColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewCategories
        // 
        dataGridViewCategories.AllowUserToAddRows = false;
        dataGridViewCategories.AllowUserToDeleteRows = false;
        dataGridViewCategories.AllowUserToOrderColumns = true;
        dataGridViewCategories.BackgroundColor = Color.White;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.Black;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = Color.White;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { Column1, idColumn, categoryColumn, editColumn, deleteColumn });
        dataGridViewCategories.EnableHeadersVisualStyles = false;
        dataGridViewCategories.GridColor = Color.Black;
        dataGridViewCategories.Location = new Point(0, 58);
        dataGridViewCategories.Name = "dataGridViewCategories";
        dataGridViewCategories.ReadOnly = true;
        dataGridViewCategories.RowHeadersVisible = false;
        dataGridViewCategories.RowTemplate.Height = 25;
        dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewCategories.Size = new Size(798, 401);
        dataGridViewCategories.TabIndex = 4;
        dataGridViewCategories.CellContentClick += dataGridViewCategories_CellContentClick;
        dataGridViewCategories.KeyDown += dataGridViewCategories_KeyDown;
        // 
        // addCategoryButton
        // 
        addCategoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        addCategoryButton.BackColor = Color.White;
        addCategoryButton.Location = new Point(564, 12);
        addCategoryButton.Name = "addCategoryButton";
        addCategoryButton.Size = new Size(226, 35);
        addCategoryButton.TabIndex = 2;
        addCategoryButton.Text = "Add Category (A)";
        addCategoryButton.UseVisualStyleBackColor = false;
        addCategoryButton.Click += addCategoryButton_Click;
        addCategoryButton.KeyDown += addCategoryButton_KeyDown;
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
        // categoryColumn
        // 
        categoryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.ForeColor = Color.Black;
        categoryColumn.DefaultCellStyle = dataGridViewCellStyle3;
        categoryColumn.HeaderText = "CATEGORY";
        categoryColumn.Name = "categoryColumn";
        categoryColumn.ReadOnly = true;
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
        // CategoriesListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(802, 450);
        Controls.Add(searchTextBox);
        Controls.Add(addCategoryButton);
        Controls.Add(dataGridViewCategories);
        Name = "CategoriesListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Categories";
        KeyDown += CategoriesListForm_KeyDown;
        ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private DataGridView dataGridViewCategories;
    private TextBox searchTextBox;
    private Button addCategoryButton;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn idColumn;
    private DataGridViewTextBoxColumn categoryColumn;
    private DataGridViewButtonColumn editColumn;
    private DataGridViewButtonColumn deleteColumn;
}