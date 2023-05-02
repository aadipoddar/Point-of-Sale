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
        this.searchTextBox = new System.Windows.Forms.TextBox();
        this.addCategoriesButton = new System.Windows.Forms.Button();
        this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
        this.SuspendLayout();
        // 
        // searchTextBox
        // 
        this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.searchTextBox.Location = new System.Drawing.Point(10, 11);
        this.searchTextBox.Name = "searchTextBox";
        this.searchTextBox.Size = new System.Drawing.Size(573, 31);
        this.searchTextBox.TabIndex = 0;
        this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
        // 
        // addCategoriesButton
        // 
        this.addCategoriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.addCategoriesButton.Location = new System.Drawing.Point(697, 8);
        this.addCategoriesButton.Name = "addCategoriesButton";
        this.addCategoriesButton.Size = new System.Drawing.Size(175, 40);
        this.addCategoriesButton.TabIndex = 2;
        this.addCategoriesButton.Text = "Add Categories";
        this.addCategoriesButton.UseVisualStyleBackColor = true;
        this.addCategoriesButton.Click += new System.EventHandler(this.addCategoriesButton_Click);
        // 
        // dataGridViewCategories
        // 
        this.dataGridViewCategories.AllowUserToAddRows = false;
        this.dataGridViewCategories.AllowUserToDeleteRows = false;
        this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewCategories.Location = new System.Drawing.Point(2, 61);
        this.dataGridViewCategories.Name = "dataGridViewCategories";
        this.dataGridViewCategories.ReadOnly = true;
        this.dataGridViewCategories.Size = new System.Drawing.Size(879, 399);
        this.dataGridViewCategories.TabIndex = 1;
        this.dataGridViewCategories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCategories_KeyDown);
        // 
        // CategoriesListForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(884, 461);
        this.Controls.Add(this.dataGridViewCategories);
        this.Controls.Add(this.searchTextBox);
        this.Controls.Add(this.addCategoriesButton);
        this.Name = "CategoriesListForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Categories";
        this.Load += new System.EventHandler(this.CategoriesListForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox searchTextBox;
    private System.Windows.Forms.Button addCategoriesButton;
    private System.Windows.Forms.DataGridView dataGridViewCategories;
}