namespace WinForms.PointOfSale.Categories;

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
        searchTextBox = new TextBox();
        addCategoriesButton = new Button();
        dataGridViewCategories = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
        SuspendLayout();
        // 
        // searchTextBox
        // 
        searchTextBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        searchTextBox.Location = new Point(12, 13);
        searchTextBox.Margin = new Padding(4, 3, 4, 3);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.Size = new Size(668, 31);
        searchTextBox.TabIndex = 0;
        searchTextBox.TextChanged += searchTextBox_TextChanged;
        // 
        // addCategoriesButton
        // 
        addCategoriesButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        addCategoriesButton.Location = new Point(813, 9);
        addCategoriesButton.Margin = new Padding(4, 3, 4, 3);
        addCategoriesButton.Name = "addCategoriesButton";
        addCategoriesButton.Size = new Size(204, 46);
        addCategoriesButton.TabIndex = 2;
        addCategoriesButton.Text = "Add Categories";
        addCategoriesButton.UseVisualStyleBackColor = true;
        addCategoriesButton.Click += addCategoriesButton_Click;
        // 
        // dataGridViewCategories
        // 
        dataGridViewCategories.AllowUserToAddRows = false;
        dataGridViewCategories.AllowUserToDeleteRows = false;
        dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCategories.Location = new Point(2, 70);
        dataGridViewCategories.Margin = new Padding(4, 3, 4, 3);
        dataGridViewCategories.Name = "dataGridViewCategories";
        dataGridViewCategories.ReadOnly = true;
        dataGridViewCategories.Size = new Size(1026, 460);
        dataGridViewCategories.TabIndex = 1;
        dataGridViewCategories.KeyDown += dataGridViewCategories_KeyDown;
        // 
        // CategoriesListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1031, 532);
        Controls.Add(dataGridViewCategories);
        Controls.Add(searchTextBox);
        Controls.Add(addCategoriesButton);
        Margin = new Padding(4, 3, 4, 3);
        Name = "CategoriesListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Categories";
        Load += CategoriesListForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox searchTextBox;
    private System.Windows.Forms.Button addCategoriesButton;
    private System.Windows.Forms.DataGridView dataGridViewCategories;
}