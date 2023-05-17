namespace WinForms.PointOfSale.Purchase;

partial class PurchaseHistoryForm
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
        startDateTimePicker = new DateTimePicker();
        filterByDateLabel = new Label();
        toLabel = new Label();
        endDateTimePicker = new DateTimePicker();
        loadRecordsButton = new Button();
        dataGridViewPurchase = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).BeginInit();
        SuspendLayout();
        // 
        // startDateTimePicker
        // 
        startDateTimePicker.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        startDateTimePicker.Format = DateTimePickerFormat.Short;
        startDateTimePicker.Location = new Point(224, 12);
        startDateTimePicker.Margin = new Padding(4, 3, 4, 3);
        startDateTimePicker.Name = "startDateTimePicker";
        startDateTimePicker.Size = new Size(180, 31);
        startDateTimePicker.TabIndex = 10;
        // 
        // filterByDateLabel
        // 
        filterByDateLabel.AutoSize = true;
        filterByDateLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        filterByDateLabel.Location = new Point(7, 10);
        filterByDateLabel.Margin = new Padding(4, 0, 4, 0);
        filterByDateLabel.Name = "filterByDateLabel";
        filterByDateLabel.Size = new Size(179, 31);
        filterByDateLabel.TabIndex = 11;
        filterByDateLabel.Text = "Filter By Date";
        // 
        // toLabel
        // 
        toLabel.AutoSize = true;
        toLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        toLabel.Location = new Point(413, 12);
        toLabel.Margin = new Padding(4, 0, 4, 0);
        toLabel.Name = "toLabel";
        toLabel.Size = new Size(52, 31);
        toLabel.TabIndex = 12;
        toLabel.Text = "TO";
        // 
        // endDateTimePicker
        // 
        endDateTimePicker.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        endDateTimePicker.Format = DateTimePickerFormat.Short;
        endDateTimePicker.Location = new Point(482, 10);
        endDateTimePicker.Margin = new Padding(4, 3, 4, 3);
        endDateTimePicker.Name = "endDateTimePicker";
        endDateTimePicker.Size = new Size(180, 31);
        endDateTimePicker.TabIndex = 13;
        // 
        // loadRecordsButton
        // 
        loadRecordsButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        loadRecordsButton.Location = new Point(1055, 5);
        loadRecordsButton.Margin = new Padding(4, 3, 4, 3);
        loadRecordsButton.Name = "loadRecordsButton";
        loadRecordsButton.Size = new Size(212, 46);
        loadRecordsButton.TabIndex = 14;
        loadRecordsButton.Text = "Load Records";
        loadRecordsButton.UseVisualStyleBackColor = true;
        loadRecordsButton.Click += loadRecordsButton_Click;
        // 
        // dataGridViewPurchase
        // 
        dataGridViewPurchase.AllowUserToAddRows = false;
        dataGridViewPurchase.AllowUserToDeleteRows = false;
        dataGridViewPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewPurchase.Location = new Point(14, 58);
        dataGridViewPurchase.Margin = new Padding(4, 3, 4, 3);
        dataGridViewPurchase.Name = "dataGridViewPurchase";
        dataGridViewPurchase.ReadOnly = true;
        dataGridViewPurchase.Size = new Size(1253, 551);
        dataGridViewPurchase.TabIndex = 15;
        // 
        // PurchaseHistoryForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 621);
        Controls.Add(dataGridViewPurchase);
        Controls.Add(loadRecordsButton);
        Controls.Add(endDateTimePicker);
        Controls.Add(toLabel);
        Controls.Add(filterByDateLabel);
        Controls.Add(startDateTimePicker);
        Margin = new Padding(4, 3, 4, 3);
        Name = "PurchaseHistoryForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Purchase History";
        ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DateTimePicker startDateTimePicker;
    private System.Windows.Forms.Label filterByDateLabel;
    private System.Windows.Forms.Label toLabel;
    private System.Windows.Forms.DateTimePicker endDateTimePicker;
    public System.Windows.Forms.Button loadRecordsButton;
    private System.Windows.Forms.DataGridView dataGridViewPurchase;
}