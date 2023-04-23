namespace PointOfSale.Cashier;

partial class BaseCashierModuleForm
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
        newTransactionButton = new Button();
        searchProductButton = new Button();
        addDiscountButton = new Button();
        settlePaymentButton = new Button();
        cancelSalesButton = new Button();
        dailySalesButton = new Button();
        changePasswordButton = new Button();
        SuspendLayout();
        // 
        // newTransactionButton
        // 
        newTransactionButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        newTransactionButton.Location = new Point(12, 12);
        newTransactionButton.Name = "newTransactionButton";
        newTransactionButton.Size = new Size(274, 39);
        newTransactionButton.TabIndex = 6;
        newTransactionButton.Text = "New Transcastion [F1]";
        newTransactionButton.UseVisualStyleBackColor = true;
        // 
        // searchProductButton
        // 
        searchProductButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        searchProductButton.Location = new Point(12, 76);
        searchProductButton.Name = "searchProductButton";
        searchProductButton.Size = new Size(274, 39);
        searchProductButton.TabIndex = 7;
        searchProductButton.Text = "Search Product [F2]";
        searchProductButton.UseVisualStyleBackColor = true;
        // 
        // addDiscountButton
        // 
        addDiscountButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        addDiscountButton.Location = new Point(12, 140);
        addDiscountButton.Name = "addDiscountButton";
        addDiscountButton.Size = new Size(274, 39);
        addDiscountButton.TabIndex = 8;
        addDiscountButton.Text = "Add Discount [F3]";
        addDiscountButton.UseVisualStyleBackColor = true;
        // 
        // settlePaymentButton
        // 
        settlePaymentButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        settlePaymentButton.Location = new Point(12, 204);
        settlePaymentButton.Name = "settlePaymentButton";
        settlePaymentButton.Size = new Size(274, 39);
        settlePaymentButton.TabIndex = 9;
        settlePaymentButton.Text = "Settle Payment [F4]";
        settlePaymentButton.UseVisualStyleBackColor = true;
        // 
        // cancelSalesButton
        // 
        cancelSalesButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        cancelSalesButton.Location = new Point(12, 268);
        cancelSalesButton.Name = "cancelSalesButton";
        cancelSalesButton.Size = new Size(274, 39);
        cancelSalesButton.TabIndex = 10;
        cancelSalesButton.Text = "Cancel Sales [F5]";
        cancelSalesButton.UseVisualStyleBackColor = true;
        // 
        // dailySalesButton
        // 
        dailySalesButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        dailySalesButton.Location = new Point(12, 332);
        dailySalesButton.Name = "dailySalesButton";
        dailySalesButton.Size = new Size(274, 39);
        dailySalesButton.TabIndex = 11;
        dailySalesButton.Text = "Daily Sales [F6]";
        dailySalesButton.UseVisualStyleBackColor = true;
        // 
        // changePasswordButton
        // 
        changePasswordButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        changePasswordButton.Location = new Point(12, 396);
        changePasswordButton.Name = "changePasswordButton";
        changePasswordButton.Size = new Size(274, 39);
        changePasswordButton.TabIndex = 12;
        changePasswordButton.Text = "Change Password [F7]";
        changePasswordButton.UseVisualStyleBackColor = true;
        // 
        // BaseCashierModuleForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(800, 450);
        Controls.Add(changePasswordButton);
        Controls.Add(dailySalesButton);
        Controls.Add(cancelSalesButton);
        Controls.Add(settlePaymentButton);
        Controls.Add(addDiscountButton);
        Controls.Add(searchProductButton);
        Controls.Add(newTransactionButton);
        Name = "BaseCashierModuleForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cashier";
        ResumeLayout(false);
    }

    #endregion

    public Button newTransactionButton;
    public Button searchProductButton;
    public Button addDiscountButton;
    public Button settlePaymentButton;
    public Button cancelSalesButton;
    public Button dailySalesButton;
    public Button changePasswordButton;
}