namespace WinForms.PointOfSale.Sale;

partial class SaleHistory
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
        loadRecordsButton = new Button();
        endDateTimePicker = new DateTimePicker();
        toLabel = new Label();
        filterByDateLabel = new Label();
        startDateTimePicker = new DateTimePicker();
        dataGridViewSale = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewSale).BeginInit();
        SuspendLayout();
        // 
        // loadRecordsButton
        // 
        loadRecordsButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        loadRecordsButton.Location = new Point(1048, 6);
        loadRecordsButton.Margin = new Padding(4, 3, 4, 3);
        loadRecordsButton.Name = "loadRecordsButton";
        loadRecordsButton.Size = new Size(239, 46);
        loadRecordsButton.TabIndex = 19;
        loadRecordsButton.Text = "Load Records";
        loadRecordsButton.UseVisualStyleBackColor = true;
        loadRecordsButton.Click += loadRecordsButton_Click;
        // 
        // endDateTimePicker
        // 
        endDateTimePicker.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        endDateTimePicker.Format = DateTimePickerFormat.Short;
        endDateTimePicker.Location = new Point(483, 15);
        endDateTimePicker.Margin = new Padding(4, 3, 4, 3);
        endDateTimePicker.Name = "endDateTimePicker";
        endDateTimePicker.Size = new Size(180, 31);
        endDateTimePicker.TabIndex = 18;
        // 
        // toLabel
        // 
        toLabel.AutoSize = true;
        toLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        toLabel.Location = new Point(414, 16);
        toLabel.Margin = new Padding(4, 0, 4, 0);
        toLabel.Name = "toLabel";
        toLabel.Size = new Size(52, 31);
        toLabel.TabIndex = 17;
        toLabel.Text = "TO";
        // 
        // filterByDateLabel
        // 
        filterByDateLabel.AutoSize = true;
        filterByDateLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        filterByDateLabel.Location = new Point(8, 15);
        filterByDateLabel.Margin = new Padding(4, 0, 4, 0);
        filterByDateLabel.Name = "filterByDateLabel";
        filterByDateLabel.Size = new Size(179, 31);
        filterByDateLabel.TabIndex = 16;
        filterByDateLabel.Text = "Filter By Date";
        // 
        // startDateTimePicker
        // 
        startDateTimePicker.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        startDateTimePicker.Format = DateTimePickerFormat.Short;
        startDateTimePicker.Location = new Point(225, 16);
        startDateTimePicker.Margin = new Padding(4, 3, 4, 3);
        startDateTimePicker.Name = "startDateTimePicker";
        startDateTimePicker.Size = new Size(180, 31);
        startDateTimePicker.TabIndex = 15;
        // 
        // dataGridViewSale
        // 
        dataGridViewSale.AllowUserToAddRows = false;
        dataGridViewSale.AllowUserToDeleteRows = false;
        dataGridViewSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewSale.Location = new Point(14, 62);
        dataGridViewSale.Margin = new Padding(4, 3, 4, 3);
        dataGridViewSale.Name = "dataGridViewSale";
        dataGridViewSale.ReadOnly = true;
        dataGridViewSale.Size = new Size(1273, 456);
        dataGridViewSale.TabIndex = 20;
        // 
        // SaleHistory
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1300, 532);
        Controls.Add(dataGridViewSale);
        Controls.Add(loadRecordsButton);
        Controls.Add(endDateTimePicker);
        Controls.Add(toLabel);
        Controls.Add(filterByDateLabel);
        Controls.Add(startDateTimePicker);
        Margin = new Padding(4, 3, 4, 3);
        Name = "SaleHistory";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SaleHistory";
        ((System.ComponentModel.ISupportInitialize)dataGridViewSale).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    public System.Windows.Forms.Button loadRecordsButton;
    private System.Windows.Forms.DateTimePicker endDateTimePicker;
    private System.Windows.Forms.Label toLabel;
    private System.Windows.Forms.Label filterByDateLabel;
    private System.Windows.Forms.DateTimePicker startDateTimePicker;
    private System.Windows.Forms.DataGridView dataGridViewSale;
}