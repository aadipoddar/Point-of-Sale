namespace PointOfSale.StockIn;

partial class StockInForm
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
        DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
        dataGridViewStockIn = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        idColumn = new DataGridViewTextBoxColumn();
        refernceColumn = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        quantityColumn = new DataGridViewTextBoxColumn();
        stockInDateColumn = new DataGridViewTextBoxColumn();
        stockInByColumn = new DataGridViewTextBoxColumn();
        deleteColumn = new DataGridViewButtonColumn();
        referenceNumberLabel = new Label();
        referenceNumberTextBox = new TextBox();
        stockInByTextBox = new TextBox();
        stockInByLabel = new Label();
        stockInDatelabel = new Label();
        stockIndateTimePicker = new DateTimePicker();
        saveButton = new Button();
        searchProductsButton = new Button();
        tabControl = new TabControl();
        stockEntryTabPage = new TabPage();
        stockInHistoryTabPage = new TabPage();
        stockInHistoryDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        filterByDateLabel = new Label();
        startDateTimePicker = new DateTimePicker();
        endDateTimePicker = new DateTimePicker();
        loadRecordsButton = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewStockIn).BeginInit();
        tabControl.SuspendLayout();
        stockEntryTabPage.SuspendLayout();
        stockInHistoryTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)stockInHistoryDataGridView).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewStockIn
        // 
        dataGridViewStockIn.AllowUserToAddRows = false;
        dataGridViewStockIn.AllowUserToDeleteRows = false;
        dataGridViewStockIn.AllowUserToOrderColumns = true;
        dataGridViewStockIn.BackgroundColor = Color.White;
        dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle7.BackColor = Color.Black;
        dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle7.ForeColor = Color.White;
        dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
        dataGridViewStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
        dataGridViewStockIn.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, idColumn, refernceColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, quantityColumn, stockInDateColumn, stockInByColumn, deleteColumn });
        dataGridViewStockIn.EnableHeadersVisualStyles = false;
        dataGridViewStockIn.GridColor = Color.Black;
        dataGridViewStockIn.Location = new Point(0, 154);
        dataGridViewStockIn.Name = "dataGridViewStockIn";
        dataGridViewStockIn.RowHeadersVisible = false;
        dataGridViewStockIn.RowTemplate.Height = 25;
        dataGridViewStockIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewStockIn.Size = new Size(933, 371);
        dataGridViewStockIn.TabIndex = 10;
        dataGridViewStockIn.CellContentClick += dataGridViewStockIn_CellContentClick;
        dataGridViewStockIn.KeyDown += dataGridViewStockIn_KeyDown;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle8.BackColor = Color.Black;
        dataGridViewCellStyle8.ForeColor = Color.White;
        dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
        dataGridViewTextBoxColumn1.HeaderText = "#";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.Width = 39;
        // 
        // idColumn
        // 
        idColumn.HeaderText = "ID";
        idColumn.Name = "idColumn";
        idColumn.Visible = false;
        // 
        // refernceColumn
        // 
        refernceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        refernceColumn.HeaderText = "REFERNCE #";
        refernceColumn.Name = "refernceColumn";
        refernceColumn.Width = 97;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.HeaderText = "PCODE";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.Width = 70;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        // 
        // quantityColumn
        // 
        quantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        quantityColumn.HeaderText = "QTY";
        quantityColumn.Name = "quantityColumn";
        quantityColumn.Width = 53;
        // 
        // stockInDateColumn
        // 
        stockInDateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        stockInDateColumn.HeaderText = "STOCK IN DATE";
        stockInDateColumn.Name = "stockInDateColumn";
        stockInDateColumn.Width = 112;
        // 
        // stockInByColumn
        // 
        stockInByColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        stockInByColumn.HeaderText = "STOCK IN BY";
        stockInByColumn.Name = "stockInByColumn";
        stockInByColumn.Width = 99;
        // 
        // deleteColumn
        // 
        deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 128, 255);
        deleteColumn.DefaultCellStyle = dataGridViewCellStyle9;
        deleteColumn.FlatStyle = FlatStyle.Popup;
        deleteColumn.HeaderText = "DELETE";
        deleteColumn.Name = "deleteColumn";
        deleteColumn.Resizable = DataGridViewTriState.True;
        deleteColumn.SortMode = DataGridViewColumnSortMode.Automatic;
        deleteColumn.Text = "DEL (D)";
        deleteColumn.ToolTipText = "Edit Brand Details";
        deleteColumn.UseColumnTextForButtonValue = true;
        deleteColumn.Width = 70;
        // 
        // referenceNumberLabel
        // 
        referenceNumberLabel.AutoSize = true;
        referenceNumberLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        referenceNumberLabel.Location = new Point(9, 14);
        referenceNumberLabel.Name = "referenceNumberLabel";
        referenceNumberLabel.Size = new Size(99, 20);
        referenceNumberLabel.TabIndex = 11;
        referenceNumberLabel.Text = "Reference No";
        // 
        // referenceNumberTextBox
        // 
        referenceNumberTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        referenceNumberTextBox.Location = new Point(125, 9);
        referenceNumberTextBox.Name = "referenceNumberTextBox";
        referenceNumberTextBox.PlaceholderText = "Reference Number";
        referenceNumberTextBox.Size = new Size(307, 29);
        referenceNumberTextBox.TabIndex = 12;
        // 
        // stockInByTextBox
        // 
        stockInByTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        stockInByTextBox.Location = new Point(125, 57);
        stockInByTextBox.Name = "stockInByTextBox";
        stockInByTextBox.PlaceholderText = "Stock In By";
        stockInByTextBox.Size = new Size(307, 29);
        stockInByTextBox.TabIndex = 14;
        // 
        // stockInByLabel
        // 
        stockInByLabel.AutoSize = true;
        stockInByLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        stockInByLabel.Location = new Point(9, 61);
        stockInByLabel.Name = "stockInByLabel";
        stockInByLabel.Size = new Size(81, 20);
        stockInByLabel.TabIndex = 13;
        stockInByLabel.Text = "Stock In By";
        // 
        // stockInDatelabel
        // 
        stockInDatelabel.AutoSize = true;
        stockInDatelabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        stockInDatelabel.Location = new Point(9, 108);
        stockInDatelabel.Name = "stockInDatelabel";
        stockInDatelabel.Size = new Size(97, 20);
        stockInDatelabel.TabIndex = 15;
        stockInDatelabel.Text = "Stock In Date";
        // 
        // stockIndateTimePicker
        // 
        stockIndateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        stockIndateTimePicker.Location = new Point(125, 105);
        stockIndateTimePicker.Name = "stockIndateTimePicker";
        stockIndateTimePicker.Size = new Size(307, 23);
        stockIndateTimePicker.TabIndex = 16;
        // 
        // saveButton
        // 
        saveButton.BackColor = Color.Transparent;
        saveButton.Location = new Point(759, 87);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(159, 41);
        saveButton.TabIndex = 17;
        saveButton.Text = "SAVE";
        saveButton.UseVisualStyleBackColor = false;
        saveButton.Click += saveButton_Click;
        // 
        // searchProductsButton
        // 
        searchProductsButton.BackColor = Color.Transparent;
        searchProductsButton.Location = new Point(759, 14);
        searchProductsButton.Name = "searchProductsButton";
        searchProductsButton.Size = new Size(159, 41);
        searchProductsButton.TabIndex = 18;
        searchProductsButton.Text = "Search Products (P)";
        searchProductsButton.UseVisualStyleBackColor = false;
        searchProductsButton.Click += searchProductsButton_Click;
        // 
        // tabControl
        // 
        tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControl.Controls.Add(stockEntryTabPage);
        tabControl.Controls.Add(stockInHistoryTabPage);
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(941, 553);
        tabControl.TabIndex = 19;
        // 
        // stockEntryTabPage
        // 
        stockEntryTabPage.Controls.Add(stockIndateTimePicker);
        stockEntryTabPage.Controls.Add(dataGridViewStockIn);
        stockEntryTabPage.Controls.Add(searchProductsButton);
        stockEntryTabPage.Controls.Add(referenceNumberLabel);
        stockEntryTabPage.Controls.Add(saveButton);
        stockEntryTabPage.Controls.Add(referenceNumberTextBox);
        stockEntryTabPage.Controls.Add(stockInByLabel);
        stockEntryTabPage.Controls.Add(stockInDatelabel);
        stockEntryTabPage.Controls.Add(stockInByTextBox);
        stockEntryTabPage.Location = new Point(4, 24);
        stockEntryTabPage.Name = "stockEntryTabPage";
        stockEntryTabPage.Padding = new Padding(3);
        stockEntryTabPage.Size = new Size(933, 525);
        stockEntryTabPage.TabIndex = 0;
        stockEntryTabPage.Text = "Stock Entry";
        stockEntryTabPage.UseVisualStyleBackColor = true;
        // 
        // stockInHistoryTabPage
        // 
        stockInHistoryTabPage.Controls.Add(loadRecordsButton);
        stockInHistoryTabPage.Controls.Add(endDateTimePicker);
        stockInHistoryTabPage.Controls.Add(startDateTimePicker);
        stockInHistoryTabPage.Controls.Add(filterByDateLabel);
        stockInHistoryTabPage.Controls.Add(stockInHistoryDataGridView);
        stockInHistoryTabPage.Location = new Point(4, 24);
        stockInHistoryTabPage.Name = "stockInHistoryTabPage";
        stockInHistoryTabPage.Padding = new Padding(3);
        stockInHistoryTabPage.Size = new Size(933, 525);
        stockInHistoryTabPage.TabIndex = 1;
        stockInHistoryTabPage.Text = "Stock In History";
        stockInHistoryTabPage.UseVisualStyleBackColor = true;
        // 
        // stockInHistoryDataGridView
        // 
        stockInHistoryDataGridView.AllowUserToAddRows = false;
        stockInHistoryDataGridView.AllowUserToDeleteRows = false;
        stockInHistoryDataGridView.AllowUserToOrderColumns = true;
        stockInHistoryDataGridView.BackgroundColor = Color.White;
        dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle10.BackColor = Color.Black;
        dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle10.ForeColor = Color.White;
        dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
        stockInHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
        stockInHistoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewButtonColumn1 });
        stockInHistoryDataGridView.EnableHeadersVisualStyles = false;
        stockInHistoryDataGridView.GridColor = Color.Black;
        stockInHistoryDataGridView.Location = new Point(0, 53);
        stockInHistoryDataGridView.Name = "stockInHistoryDataGridView";
        stockInHistoryDataGridView.RowHeadersVisible = false;
        stockInHistoryDataGridView.RowTemplate.Height = 25;
        stockInHistoryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        stockInHistoryDataGridView.Size = new Size(933, 476);
        stockInHistoryDataGridView.TabIndex = 11;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle11.BackColor = Color.Black;
        dataGridViewCellStyle11.ForeColor = Color.White;
        dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
        dataGridViewTextBoxColumn4.HeaderText = "#";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.Width = 39;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.HeaderText = "ID";
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.Visible = false;
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn6.HeaderText = "REFERNCE #";
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        dataGridViewTextBoxColumn6.Width = 97;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn7.HeaderText = "PCODE";
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.Width = 70;
        // 
        // dataGridViewTextBoxColumn8
        // 
        dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewTextBoxColumn8.HeaderText = "DESCRIPTION";
        dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
        // 
        // dataGridViewTextBoxColumn9
        // 
        dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn9.HeaderText = "QTY";
        dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
        dataGridViewTextBoxColumn9.Width = 53;
        // 
        // dataGridViewTextBoxColumn10
        // 
        dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn10.HeaderText = "STOCK IN DATE";
        dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
        dataGridViewTextBoxColumn10.Width = 112;
        // 
        // dataGridViewTextBoxColumn11
        // 
        dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn11.HeaderText = "STOCK IN BY";
        dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
        dataGridViewTextBoxColumn11.Width = 99;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle12.BackColor = Color.FromArgb(128, 128, 255);
        dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle12;
        dataGridViewButtonColumn1.FlatStyle = FlatStyle.Popup;
        dataGridViewButtonColumn1.HeaderText = "DELETE";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
        dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
        dataGridViewButtonColumn1.Text = "DEL (D)";
        dataGridViewButtonColumn1.ToolTipText = "Edit Brand Details";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 70;
        // 
        // filterByDateLabel
        // 
        filterByDateLabel.AutoSize = true;
        filterByDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        filterByDateLabel.Location = new Point(8, 15);
        filterByDateLabel.Name = "filterByDateLabel";
        filterByDateLabel.Size = new Size(102, 21);
        filterByDateLabel.TabIndex = 12;
        filterByDateLabel.Text = "Filter By Date";
        // 
        // startDateTimePicker
        // 
        startDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        startDateTimePicker.Format = DateTimePickerFormat.Short;
        startDateTimePicker.Location = new Point(116, 11);
        startDateTimePicker.Name = "startDateTimePicker";
        startDateTimePicker.Size = new Size(122, 29);
        startDateTimePicker.TabIndex = 13;
        // 
        // endDateTimePicker
        // 
        endDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        endDateTimePicker.Format = DateTimePickerFormat.Short;
        endDateTimePicker.Location = new Point(244, 11);
        endDateTimePicker.Name = "endDateTimePicker";
        endDateTimePicker.Size = new Size(122, 29);
        endDateTimePicker.TabIndex = 14;
        // 
        // loadRecordsButton
        // 
        loadRecordsButton.BackColor = Color.Transparent;
        loadRecordsButton.Location = new Point(383, 6);
        loadRecordsButton.Name = "loadRecordsButton";
        loadRecordsButton.Size = new Size(137, 41);
        loadRecordsButton.TabIndex = 18;
        loadRecordsButton.Text = "Load Records";
        loadRecordsButton.UseVisualStyleBackColor = false;
        loadRecordsButton.Click += loadRecordsButton_Click;
        // 
        // StockInForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(943, 550);
        Controls.Add(tabControl);
        Name = "StockInForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Stock In";
        ((System.ComponentModel.ISupportInitialize)dataGridViewStockIn).EndInit();
        tabControl.ResumeLayout(false);
        stockEntryTabPage.ResumeLayout(false);
        stockEntryTabPage.PerformLayout();
        stockInHistoryTabPage.ResumeLayout(false);
        stockInHistoryTabPage.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)stockInHistoryDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private DataGridView dataGridViewStockIn;
    private Label referenceNumberLabel;
    private Label stockInByLabel;
    private Label stockInDatelabel;
    private Button saveButton;
    public TextBox referenceNumberTextBox;
    public TextBox stockInByTextBox;
    public DateTimePicker stockIndateTimePicker;
    private Button searchProductsButton;
    private TabControl tabControl;
    private TabPage stockEntryTabPage;
    private TabPage stockInHistoryTabPage;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn idColumn;
    private DataGridViewTextBoxColumn refernceColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn quantityColumn;
    private DataGridViewTextBoxColumn stockInDateColumn;
    private DataGridViewTextBoxColumn stockInByColumn;
    private DataGridViewButtonColumn deleteColumn;
    private DataGridView stockInHistoryDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private DateTimePicker endDateTimePicker;
    private DateTimePicker startDateTimePicker;
    private Label filterByDateLabel;
    private Button loadRecordsButton;
}