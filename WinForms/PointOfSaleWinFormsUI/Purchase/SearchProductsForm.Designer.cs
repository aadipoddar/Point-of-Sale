namespace WinForms.PointOfSale.Purchase;

partial class SearchProductsForm
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
        searchTextBox = new TextBox();
        quantityLabel = new Label();
        quantityNumericUpDown = new NumericUpDown();
        dataGridViewProducts = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        SuspendLayout();
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
        // quantityLabel
        // 
        quantityLabel.AutoSize = true;
        quantityLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        quantityLabel.Location = new Point(792, 10);
        quantityLabel.Margin = new Padding(4, 0, 4, 0);
        quantityLabel.Name = "quantityLabel";
        quantityLabel.Size = new Size(116, 31);
        quantityLabel.TabIndex = 3;
        quantityLabel.Text = "Quantity";
        // 
        // quantityNumericUpDown
        // 
        quantityNumericUpDown.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        quantityNumericUpDown.Location = new Point(946, 8);
        quantityNumericUpDown.Margin = new Padding(4, 3, 4, 3);
        quantityNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        quantityNumericUpDown.Name = "quantityNumericUpDown";
        quantityNumericUpDown.Size = new Size(71, 38);
        quantityNumericUpDown.TabIndex = 1;
        quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // dataGridViewProducts
        // 
        dataGridViewProducts.AllowUserToAddRows = false;
        dataGridViewProducts.AllowUserToDeleteRows = false;
        dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewProducts.Location = new Point(14, 67);
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.ReadOnly = true;
        dataGridViewProducts.RowTemplate.Height = 25;
        dataGridViewProducts.Size = new Size(1003, 453);
        dataGridViewProducts.TabIndex = 4;
        dataGridViewProducts.KeyDown += dataGridViewProducts_KeyDown;
        // 
        // SearchProductsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1031, 532);
        Controls.Add(dataGridViewProducts);
        Controls.Add(quantityNumericUpDown);
        Controls.Add(quantityLabel);
        Controls.Add(searchTextBox);
        Margin = new Padding(4, 3, 4, 3);
        Name = "SearchProductsForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Search Products";
        ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox searchTextBox;
    private System.Windows.Forms.Label quantityLabel;
    public System.Windows.Forms.NumericUpDown quantityNumericUpDown;
    private DataGridView dataGridViewProducts;
}