namespace PointOfSale;

partial class BrandsEditForm
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
        brandNameLabel = new Label();
        brandNameTextBox = new TextBox();
        saveButton = new Button();
        updateButton = new Button();
        cancelButton = new Button();
        SuspendLayout();
        // 
        // brandNameLabel
        // 
        brandNameLabel.AutoSize = true;
        brandNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        brandNameLabel.Location = new Point(25, 18);
        brandNameLabel.Name = "brandNameLabel";
        brandNameLabel.Size = new Size(147, 32);
        brandNameLabel.TabIndex = 0;
        brandNameLabel.Text = "Brand Name";
        // 
        // brandNameTextBox
        // 
        brandNameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        brandNameTextBox.Location = new Point(178, 16);
        brandNameTextBox.Name = "brandNameTextBox";
        brandNameTextBox.PlaceholderText = "Brand Name";
        brandNameTextBox.Size = new Size(352, 39);
        brandNameTextBox.TabIndex = 1;
        // 
        // saveButton
        // 
        saveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        saveButton.Location = new Point(73, 80);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(114, 39);
        saveButton.TabIndex = 2;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // updateButton
        // 
        updateButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        updateButton.Location = new Point(210, 80);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(114, 39);
        updateButton.TabIndex = 3;
        updateButton.Text = "Update";
        updateButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        cancelButton.Location = new Point(347, 80);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(114, 39);
        cancelButton.TabIndex = 4;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;
        // 
        // BrandsEditForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(554, 131);
        Controls.Add(cancelButton);
        Controls.Add(updateButton);
        Controls.Add(saveButton);
        Controls.Add(brandNameTextBox);
        Controls.Add(brandNameLabel);
        Name = "BrandsEditForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Manage Brand";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label brandNameLabel;
    private TextBox brandNameTextBox;
    private Button saveButton;
    private Button updateButton;
    private Button cancelButton;
}