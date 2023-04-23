namespace PointOfSale.Products;

partial class ProductsEditForm
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
        originalProductId = new Label();
        cancelButton = new Button();
        updateButton = new Button();
        saveButton = new Button();
        productCodeTextBox = new TextBox();
        productCodeLabel = new Label();
        descriptionTextBox = new TextBox();
        descriptionLabel = new Label();
        brandLabel = new Label();
        categoryLabel = new Label();
        brandComboBox = new ComboBox();
        categoryComboBox = new ComboBox();
        priceTextBox = new TextBox();
        priceLabel = new Label();
        SuspendLayout();
        // 
        // originalProductId
        // 
        originalProductId.AutoSize = true;
        originalProductId.Location = new Point(500, 322);
        originalProductId.Name = "originalProductId";
        originalProductId.Size = new Size(62, 15);
        originalProductId.TabIndex = 17;
        originalProductId.Text = "Original Id";
        originalProductId.Visible = false;
        // 
        // cancelButton
        // 
        cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        cancelButton.Location = new Point(355, 305);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(114, 39);
        cancelButton.TabIndex = 7;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;
        cancelButton.KeyDown += cancelButton_KeyDown;
        // 
        // updateButton
        // 
        updateButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        updateButton.Location = new Point(218, 305);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(114, 39);
        updateButton.TabIndex = 6;
        updateButton.Text = "Update";
        updateButton.UseVisualStyleBackColor = true;
        updateButton.Click += updateButton_Click;
        updateButton.KeyDown += updateButton_KeyDown;
        // 
        // saveButton
        // 
        saveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        saveButton.Location = new Point(81, 305);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(114, 39);
        saveButton.TabIndex = 5;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        saveButton.KeyDown += saveButton_KeyDown;
        // 
        // productCodeTextBox
        // 
        productCodeTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        productCodeTextBox.Location = new Point(219, 5);
        productCodeTextBox.Name = "productCodeTextBox";
        productCodeTextBox.PlaceholderText = "Product Code";
        productCodeTextBox.Size = new Size(383, 39);
        productCodeTextBox.TabIndex = 0;
        productCodeTextBox.KeyDown += productCodeTextBox_KeyDown;
        // 
        // productCodeLabel
        // 
        productCodeLabel.AutoSize = true;
        productCodeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        productCodeLabel.Location = new Point(30, 9);
        productCodeLabel.Name = "productCodeLabel";
        productCodeLabel.Size = new Size(159, 32);
        productCodeLabel.TabIndex = 12;
        productCodeLabel.Text = "Product Code";
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        descriptionTextBox.Location = new Point(219, 66);
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.PlaceholderText = "Product Description";
        descriptionTextBox.Size = new Size(383, 39);
        descriptionTextBox.TabIndex = 1;
        descriptionTextBox.KeyDown += descriptionTextBox_KeyDown;
        // 
        // descriptionLabel
        // 
        descriptionLabel.AutoSize = true;
        descriptionLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        descriptionLabel.Location = new Point(30, 69);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(135, 32);
        descriptionLabel.TabIndex = 18;
        descriptionLabel.Text = "Description";
        // 
        // brandLabel
        // 
        brandLabel.AutoSize = true;
        brandLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        brandLabel.Location = new Point(30, 129);
        brandLabel.Name = "brandLabel";
        brandLabel.Size = new Size(76, 32);
        brandLabel.TabIndex = 20;
        brandLabel.Text = "Brand";
        // 
        // categoryLabel
        // 
        categoryLabel.AutoSize = true;
        categoryLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        categoryLabel.Location = new Point(30, 189);
        categoryLabel.Name = "categoryLabel";
        categoryLabel.Size = new Size(110, 32);
        categoryLabel.TabIndex = 22;
        categoryLabel.Text = "Category";
        // 
        // brandComboBox
        // 
        brandComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        brandComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        brandComboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        brandComboBox.FormattingEnabled = true;
        brandComboBox.Location = new Point(219, 127);
        brandComboBox.Name = "brandComboBox";
        brandComboBox.Size = new Size(383, 40);
        brandComboBox.TabIndex = 2;
        brandComboBox.KeyDown += brandComboBox_KeyDown;
        // 
        // categoryComboBox
        // 
        categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        categoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        categoryComboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        categoryComboBox.FormattingEnabled = true;
        categoryComboBox.Location = new Point(219, 189);
        categoryComboBox.Name = "categoryComboBox";
        categoryComboBox.Size = new Size(383, 40);
        categoryComboBox.TabIndex = 3;
        categoryComboBox.KeyDown += categoryComboBox_KeyDown;
        // 
        // priceTextBox
        // 
        priceTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        priceTextBox.Location = new Point(219, 246);
        priceTextBox.Name = "priceTextBox";
        priceTextBox.PlaceholderText = "Price";
        priceTextBox.Size = new Size(383, 39);
        priceTextBox.TabIndex = 4;
        priceTextBox.KeyDown += priceTextBox_KeyDown;
        // 
        // priceLabel
        // 
        priceLabel.AutoSize = true;
        priceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        priceLabel.Location = new Point(30, 249);
        priceLabel.Name = "priceLabel";
        priceLabel.Size = new Size(65, 32);
        priceLabel.TabIndex = 26;
        priceLabel.Text = "Price";
        // 
        // ProductsEditForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(614, 358);
        Controls.Add(priceTextBox);
        Controls.Add(priceLabel);
        Controls.Add(categoryComboBox);
        Controls.Add(brandComboBox);
        Controls.Add(categoryLabel);
        Controls.Add(brandLabel);
        Controls.Add(descriptionTextBox);
        Controls.Add(descriptionLabel);
        Controls.Add(originalProductId);
        Controls.Add(cancelButton);
        Controls.Add(updateButton);
        Controls.Add(saveButton);
        Controls.Add(productCodeTextBox);
        Controls.Add(productCodeLabel);
        Name = "ProductsEditForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Add Products";
        KeyDown += ProductsEditForm_KeyDown;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    public Label originalProductId;
    private Button cancelButton;
    public Button updateButton;
    public Button saveButton;
    public TextBox productCodeTextBox;
    private Label productCodeLabel;
    public TextBox descriptionTextBox;
    private Label descriptionLabel;
    private Label brandLabel;
    private Label categoryLabel;
    public TextBox priceTextBox;
    private Label priceLabel;
    public ComboBox brandComboBox;
    public ComboBox categoryComboBox;
}