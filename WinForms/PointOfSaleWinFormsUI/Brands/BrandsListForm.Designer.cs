namespace WinForms.PointOfSale.Brands;

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
        searchTextBox = new TextBox();
        addBrandsButton = new Button();
        dataGridViewBrands = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewBrands).BeginInit();
        SuspendLayout();
        // 
        // searchTextBox
        // 
        searchTextBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        searchTextBox.Location = new Point(13, 15);
        searchTextBox.Margin = new Padding(4, 3, 4, 3);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.Size = new Size(668, 31);
        searchTextBox.TabIndex = 3;
        searchTextBox.TextChanged += searchTextBox_TextChanged;
        // 
        // addBrandsButton
        // 
        addBrandsButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        addBrandsButton.Location = new Point(814, 12);
        addBrandsButton.Margin = new Padding(4, 3, 4, 3);
        addBrandsButton.Name = "addBrandsButton";
        addBrandsButton.Size = new Size(204, 46);
        addBrandsButton.TabIndex = 4;
        addBrandsButton.Text = "Add Brands";
        addBrandsButton.UseVisualStyleBackColor = true;
        addBrandsButton.Click += addBrandsButton_Click;
        // 
        // dataGridViewBrands
        // 
        dataGridViewBrands.AllowUserToAddRows = false;
        dataGridViewBrands.AllowUserToDeleteRows = false;
        dataGridViewBrands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewBrands.Location = new Point(4, 82);
        dataGridViewBrands.Margin = new Padding(4, 3, 4, 3);
        dataGridViewBrands.Name = "dataGridViewBrands";
        dataGridViewBrands.ReadOnly = true;
        dataGridViewBrands.Size = new Size(1027, 449);
        dataGridViewBrands.TabIndex = 5;
        dataGridViewBrands.KeyDown += dataGridViewBrands_KeyDown;
        // 
        // BrandsListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1031, 532);
        Controls.Add(dataGridViewBrands);
        Controls.Add(searchTextBox);
        Controls.Add(addBrandsButton);
        Margin = new Padding(4, 3, 4, 3);
        Name = "BrandsListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Brands";
        Load += BrandsListForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewBrands).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox searchTextBox;
    private System.Windows.Forms.Button addBrandsButton;
    private System.Windows.Forms.DataGridView dataGridViewBrands;
}