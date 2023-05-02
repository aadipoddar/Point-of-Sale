namespace WinForms.PointOfSale;

partial class AdminDashboardForm
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
        this.manageProductsButton = new System.Windows.Forms.Button();
        this.manageCategoriesButton = new System.Windows.Forms.Button();
        this.manageBrandButton = new System.Windows.Forms.Button();
        this.purchaseButton = new System.Windows.Forms.Button();
        this.purchaseHistoryButton = new System.Windows.Forms.Button();
        this.newSaleButton = new System.Windows.Forms.Button();
        this.saleHistoryButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // manageProductsButton
        // 
        this.manageProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.manageProductsButton.Location = new System.Drawing.Point(12, 12);
        this.manageProductsButton.Name = "manageProductsButton";
        this.manageProductsButton.Size = new System.Drawing.Size(208, 50);
        this.manageProductsButton.TabIndex = 0;
        this.manageProductsButton.Text = "Manage Products";
        this.manageProductsButton.UseVisualStyleBackColor = true;
        this.manageProductsButton.Click += new System.EventHandler(this.manageProductsButton_Click);
        // 
        // manageCategoriesButton
        // 
        this.manageCategoriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.manageCategoriesButton.Location = new System.Drawing.Point(12, 80);
        this.manageCategoriesButton.Name = "manageCategoriesButton";
        this.manageCategoriesButton.Size = new System.Drawing.Size(208, 50);
        this.manageCategoriesButton.TabIndex = 1;
        this.manageCategoriesButton.Text = "Manage Categories";
        this.manageCategoriesButton.UseVisualStyleBackColor = true;
        this.manageCategoriesButton.Click += new System.EventHandler(this.manageCategoriesButton_Click);
        // 
        // manageBrandButton
        // 
        this.manageBrandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.manageBrandButton.Location = new System.Drawing.Point(12, 148);
        this.manageBrandButton.Name = "manageBrandButton";
        this.manageBrandButton.Size = new System.Drawing.Size(208, 50);
        this.manageBrandButton.TabIndex = 2;
        this.manageBrandButton.Text = "Manage Brands";
        this.manageBrandButton.UseVisualStyleBackColor = true;
        this.manageBrandButton.Click += new System.EventHandler(this.manageBrandButton_Click);
        // 
        // purchaseButton
        // 
        this.purchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.purchaseButton.Location = new System.Drawing.Point(656, 12);
        this.purchaseButton.Name = "purchaseButton";
        this.purchaseButton.Size = new System.Drawing.Size(208, 50);
        this.purchaseButton.TabIndex = 3;
        this.purchaseButton.Text = "Purcahse";
        this.purchaseButton.UseVisualStyleBackColor = true;
        this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
        // 
        // purchaseHistoryButton
        // 
        this.purchaseHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.purchaseHistoryButton.Location = new System.Drawing.Point(657, 80);
        this.purchaseHistoryButton.Name = "purchaseHistoryButton";
        this.purchaseHistoryButton.Size = new System.Drawing.Size(208, 50);
        this.purchaseHistoryButton.TabIndex = 4;
        this.purchaseHistoryButton.Text = "Purchase History";
        this.purchaseHistoryButton.UseVisualStyleBackColor = true;
        this.purchaseHistoryButton.Click += new System.EventHandler(this.purchaseHistoryButton_Click);
        // 
        // newSaleButton
        // 
        this.newSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.newSaleButton.Location = new System.Drawing.Point(334, 12);
        this.newSaleButton.Name = "newSaleButton";
        this.newSaleButton.Size = new System.Drawing.Size(208, 50);
        this.newSaleButton.TabIndex = 9;
        this.newSaleButton.Text = "New Sale";
        this.newSaleButton.UseVisualStyleBackColor = true;
        this.newSaleButton.Click += new System.EventHandler(this.cashierDashboardButton_Click);
        // 
        // saleHistoryButton
        // 
        this.saleHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.saleHistoryButton.Location = new System.Drawing.Point(334, 80);
        this.saleHistoryButton.Name = "saleHistoryButton";
        this.saleHistoryButton.Size = new System.Drawing.Size(208, 50);
        this.saleHistoryButton.TabIndex = 10;
        this.saleHistoryButton.Text = "Sale History";
        this.saleHistoryButton.UseVisualStyleBackColor = true;
        this.saleHistoryButton.Click += new System.EventHandler(this.saleHistoryButton_Click);
        // 
        // AdminDashboardForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(934, 561);
        this.Controls.Add(this.saleHistoryButton);
        this.Controls.Add(this.newSaleButton);
        this.Controls.Add(this.purchaseHistoryButton);
        this.Controls.Add(this.purchaseButton);
        this.Controls.Add(this.manageBrandButton);
        this.Controls.Add(this.manageCategoriesButton);
        this.Controls.Add(this.manageProductsButton);
        this.Name = "AdminDashboardForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Admin Dashboard";
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button manageProductsButton;
    private System.Windows.Forms.Button manageCategoriesButton;
    private System.Windows.Forms.Button manageBrandButton;
    private System.Windows.Forms.Button purchaseButton;
    private System.Windows.Forms.Button purchaseHistoryButton;
    private System.Windows.Forms.Button newSaleButton;
    private System.Windows.Forms.Button saleHistoryButton;
}