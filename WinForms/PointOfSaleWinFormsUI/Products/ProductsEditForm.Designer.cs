namespace WinForms.PointOfSale.Products;

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
        descriptionTextBox = new TextBox();
        decriptionLabel = new Label();
        brandLabel = new Label();
        categoryLabel = new Label();
        priceLabel = new Label();
        brandComboBox = new ComboBox();
        categoryComboBox = new ComboBox();
        priceNumericUpDown = new NumericUpDown();
        saveButton = new Button();
        updateButton = new Button();
        cancelButton = new Button();
        taxNumericUpDown = new NumericUpDown();
        taxLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)taxNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        descriptionTextBox.Location = new Point(284, 18);
        descriptionTextBox.Margin = new Padding(4, 3, 4, 3);
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(426, 38);
        descriptionTextBox.TabIndex = 1;
        // 
        // decriptionLabel
        // 
        decriptionLabel.AutoSize = true;
        decriptionLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        decriptionLabel.Location = new Point(14, 24);
        decriptionLabel.Margin = new Padding(4, 0, 4, 0);
        decriptionLabel.Name = "decriptionLabel";
        decriptionLabel.Size = new Size(151, 31);
        decriptionLabel.TabIndex = 0;
        decriptionLabel.Text = "Description";
        // 
        // brandLabel
        // 
        brandLabel.AutoSize = true;
        brandLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        brandLabel.Location = new Point(14, 97);
        brandLabel.Margin = new Padding(4, 0, 4, 0);
        brandLabel.Name = "brandLabel";
        brandLabel.Size = new Size(86, 31);
        brandLabel.TabIndex = 2;
        brandLabel.Text = "Brand";
        // 
        // categoryLabel
        // 
        categoryLabel.AutoSize = true;
        categoryLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        categoryLabel.Location = new Point(14, 170);
        categoryLabel.Margin = new Padding(4, 0, 4, 0);
        categoryLabel.Name = "categoryLabel";
        categoryLabel.Size = new Size(125, 31);
        categoryLabel.TabIndex = 4;
        categoryLabel.Text = "Category";
        // 
        // priceLabel
        // 
        priceLabel.AutoSize = true;
        priceLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        priceLabel.Location = new Point(14, 242);
        priceLabel.Margin = new Padding(4, 0, 4, 0);
        priceLabel.Name = "priceLabel";
        priceLabel.Size = new Size(76, 31);
        priceLabel.TabIndex = 6;
        priceLabel.Text = "Price";
        // 
        // brandComboBox
        // 
        brandComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        brandComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        brandComboBox.DisplayMember = "id";
        brandComboBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        brandComboBox.FormattingEnabled = true;
        brandComboBox.Location = new Point(284, 92);
        brandComboBox.Margin = new Padding(4, 3, 4, 3);
        brandComboBox.Name = "brandComboBox";
        brandComboBox.Size = new Size(426, 39);
        brandComboBox.TabIndex = 3;
        brandComboBox.ValueMember = "id";
        // 
        // categoryComboBox
        // 
        categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        categoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        categoryComboBox.DisplayMember = "id";
        categoryComboBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        categoryComboBox.FormattingEnabled = true;
        categoryComboBox.Location = new Point(284, 167);
        categoryComboBox.Margin = new Padding(4, 3, 4, 3);
        categoryComboBox.Name = "categoryComboBox";
        categoryComboBox.Size = new Size(426, 39);
        categoryComboBox.TabIndex = 5;
        categoryComboBox.ValueMember = "id";
        // 
        // priceNumericUpDown
        // 
        priceNumericUpDown.DecimalPlaces = 2;
        priceNumericUpDown.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        priceNumericUpDown.Location = new Point(284, 242);
        priceNumericUpDown.Margin = new Padding(4, 3, 4, 3);
        priceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        priceNumericUpDown.Name = "priceNumericUpDown";
        priceNumericUpDown.Size = new Size(427, 38);
        priceNumericUpDown.TabIndex = 7;
        priceNumericUpDown.TextAlign = HorizontalAlignment.Right;
        // 
        // saveButton
        // 
        saveButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        saveButton.Location = new Point(46, 397);
        saveButton.Margin = new Padding(4, 3, 4, 3);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(192, 58);
        saveButton.TabIndex = 10;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // updateButton
        // 
        updateButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        updateButton.Location = new Point(271, 397);
        updateButton.Margin = new Padding(4, 3, 4, 3);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(192, 58);
        updateButton.TabIndex = 11;
        updateButton.Text = "Update";
        updateButton.UseVisualStyleBackColor = true;
        updateButton.Click += updateButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        cancelButton.Location = new Point(500, 397);
        cancelButton.Margin = new Padding(4, 3, 4, 3);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(192, 58);
        cancelButton.TabIndex = 12;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;
        // 
        // taxNumericUpDown
        // 
        taxNumericUpDown.DecimalPlaces = 2;
        taxNumericUpDown.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        taxNumericUpDown.Location = new Point(284, 316);
        taxNumericUpDown.Margin = new Padding(4, 3, 4, 3);
        taxNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        taxNumericUpDown.Name = "taxNumericUpDown";
        taxNumericUpDown.Size = new Size(427, 38);
        taxNumericUpDown.TabIndex = 9;
        taxNumericUpDown.TextAlign = HorizontalAlignment.Right;
        // 
        // taxLabel
        // 
        taxLabel.AutoSize = true;
        taxLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        taxLabel.Location = new Point(14, 315);
        taxLabel.Margin = new Padding(4, 0, 4, 0);
        taxLabel.Name = "taxLabel";
        taxLabel.Size = new Size(90, 31);
        taxLabel.TabIndex = 8;
        taxLabel.Text = "Tax %";
        // 
        // ProductsEditForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(740, 482);
        Controls.Add(taxNumericUpDown);
        Controls.Add(taxLabel);
        Controls.Add(cancelButton);
        Controls.Add(updateButton);
        Controls.Add(saveButton);
        Controls.Add(priceNumericUpDown);
        Controls.Add(categoryComboBox);
        Controls.Add(brandComboBox);
        Controls.Add(priceLabel);
        Controls.Add(categoryLabel);
        Controls.Add(brandLabel);
        Controls.Add(descriptionTextBox);
        Controls.Add(decriptionLabel);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ProductsEditForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Products Edit";
        ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)taxNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.Label decriptionLabel;
    private System.Windows.Forms.Label brandLabel;
    private System.Windows.Forms.Label categoryLabel;
    private System.Windows.Forms.Label priceLabel;
    public System.Windows.Forms.NumericUpDown priceNumericUpDown;
    private System.Windows.Forms.Button cancelButton;
    public System.Windows.Forms.Button saveButton;
    public System.Windows.Forms.Button updateButton;
    public System.Windows.Forms.TextBox descriptionTextBox;
    public System.Windows.Forms.ComboBox brandComboBox;
    public System.Windows.Forms.ComboBox categoryComboBox;
    public System.Windows.Forms.NumericUpDown taxNumericUpDown;
    private System.Windows.Forms.Label taxLabel;
}