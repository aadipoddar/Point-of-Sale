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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        dataGridViewbrands = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        idColumn = new DataGridViewTextBoxColumn();
        brandColumn = new DataGridViewTextBoxColumn();
        editColumn = new DataGridViewButtonColumn();
        deleteColumn = new DataGridViewButtonColumn();
        topPanel = new Panel();
        addBrandButton = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewbrands).BeginInit();
        topPanel.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridViewbrands
        // 
        dataGridViewbrands.AllowUserToAddRows = false;
        dataGridViewbrands.AllowUserToDeleteRows = false;
        dataGridViewbrands.AllowUserToOrderColumns = true;
        dataGridViewbrands.BackgroundColor = Color.White;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.Black;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle4.ForeColor = Color.White;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dataGridViewbrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dataGridViewbrands.Columns.AddRange(new DataGridViewColumn[] { Column1, idColumn, brandColumn, editColumn, deleteColumn });
        dataGridViewbrands.EnableHeadersVisualStyles = false;
        dataGridViewbrands.Location = new Point(0, 53);
        dataGridViewbrands.Name = "dataGridViewbrands";
        dataGridViewbrands.ReadOnly = true;
        dataGridViewbrands.RowHeadersVisible = false;
        dataGridViewbrands.RowTemplate.Height = 25;
        dataGridViewbrands.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewbrands.Size = new Size(800, 397);
        dataGridViewbrands.TabIndex = 0;
        dataGridViewbrands.CellContentClick += dataGridViewbrands_CellContentClick;
        dataGridViewbrands.KeyDown += dataGridViewbrands_KeyDown;
        // 
        // Column1
        // 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
        brandColumn.HeaderText = "BRAND";
        brandColumn.Name = "brandColumn";
        brandColumn.ReadOnly = true;
        // 
        // editColumn
        // 
        editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle5.BackColor = Color.FromArgb(128, 128, 255);
        editColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 128);
        dataGridViewCellStyle6.ForeColor = Color.White;
        deleteColumn.DefaultCellStyle = dataGridViewCellStyle6;
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
        // topPanel
        // 
        topPanel.Controls.Add(addBrandButton);
        topPanel.Location = new Point(0, 0);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(800, 51);
        topPanel.TabIndex = 1;
        // 
        // addBrandButton
        // 
        addBrandButton.Location = new Point(403, 12);
        addBrandButton.Name = "addBrandButton";
        addBrandButton.Size = new Size(226, 35);
        addBrandButton.TabIndex = 0;
        addBrandButton.Text = "Add Brand (A)";
        addBrandButton.UseVisualStyleBackColor = true;
        addBrandButton.Click += addBrandButton_Click;
        // 
        // BrandsListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(800, 450);
        Controls.Add(topPanel);
        Controls.Add(dataGridViewbrands);
        Name = "BrandsListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Brands";
        KeyDown += BrandsListForm_KeyDown;
        ((System.ComponentModel.ISupportInitialize)dataGridViewbrands).EndInit();
        topPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridViewbrands;
    private Panel topPanel;
    private Button addBrandButton;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn idColumn;
    private DataGridViewTextBoxColumn brandColumn;
    private DataGridViewButtonColumn editColumn;
    private DataGridViewButtonColumn deleteColumn;
}