namespace PointOfSale.Categories;

partial class CategoriesEditForm
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
        originalCategoryId = new Label();
        cancelButton = new Button();
        updateButton = new Button();
        saveButton = new Button();
        categoryNameTextBox = new TextBox();
        CategoryNameLabel = new Label();
        SuspendLayout();
        // 
        // originalCategoryId
        // 
        originalCategoryId.AutoSize = true;
        originalCategoryId.Location = new Point(484, 95);
        originalCategoryId.Name = "originalCategoryId";
        originalCategoryId.Size = new Size(62, 15);
        originalCategoryId.TabIndex = 11;
        originalCategoryId.Text = "Original Id";
        originalCategoryId.Visible = false;
        // 
        // cancelButton
        // 
        cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        cancelButton.Location = new Point(339, 78);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(114, 39);
        cancelButton.TabIndex = 10;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;
        cancelButton.KeyDown += cancelButton_KeyDown;
        // 
        // updateButton
        // 
        updateButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        updateButton.Location = new Point(202, 78);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(114, 39);
        updateButton.TabIndex = 9;
        updateButton.Text = "Update";
        updateButton.UseVisualStyleBackColor = true;
        updateButton.Click += updateButton_Click;
        updateButton.KeyDown += updateButton_KeyDown;
        // 
        // saveButton
        // 
        saveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        saveButton.Location = new Point(65, 78);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(114, 39);
        saveButton.TabIndex = 8;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        saveButton.KeyDown += saveButton_KeyDown;
        // 
        // categoryNameTextBox
        // 
        categoryNameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        categoryNameTextBox.Location = new Point(193, 14);
        categoryNameTextBox.Name = "categoryNameTextBox";
        categoryNameTextBox.PlaceholderText = "Category Name";
        categoryNameTextBox.Size = new Size(352, 39);
        categoryNameTextBox.TabIndex = 7;
        categoryNameTextBox.KeyDown += categoryNameTextBox_KeyDown;
        // 
        // CategoryNameLabel
        // 
        CategoryNameLabel.AutoSize = true;
        CategoryNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        CategoryNameLabel.Location = new Point(8, 18);
        CategoryNameLabel.Name = "CategoryNameLabel";
        CategoryNameLabel.Size = new Size(181, 32);
        CategoryNameLabel.TabIndex = 6;
        CategoryNameLabel.Text = "Category Name";
        // 
        // CategoriesEditForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(554, 131);
        Controls.Add(originalCategoryId);
        Controls.Add(cancelButton);
        Controls.Add(updateButton);
        Controls.Add(saveButton);
        Controls.Add(categoryNameTextBox);
        Controls.Add(CategoryNameLabel);
        Name = "CategoriesEditForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CategoriesEditForm";
        KeyDown += CategoriesEditForm_KeyDown;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    public Label originalCategoryId;
    private Button cancelButton;
    public Button updateButton;
    public Button saveButton;
    public TextBox categoryNameTextBox;
    private Label CategoryNameLabel;
}