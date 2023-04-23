namespace PointOfSale;

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
        logoutButton = new Button();
        userSettingsButton = new Button();
        systemSettingsButton = new Button();
        recordsButton = new Button();
        manageBrandButton = new Button();
        manageCategoryButton = new Button();
        manageProductButton = new Button();
        manageSalesButton = new Button();
        dashboardButton = new Button();
        adminLabel = new Label();
        usernameLabel = new Label();
        stockInButton = new Button();
        SuspendLayout();
        // 
        // logoutButton
        // 
        logoutButton.BackColor = Color.Transparent;
        logoutButton.Location = new Point(14, 556);
        logoutButton.Name = "logoutButton";
        logoutButton.Size = new Size(176, 31);
        logoutButton.TabIndex = 10;
        logoutButton.Text = "Log Out";
        logoutButton.UseVisualStyleBackColor = false;
        logoutButton.KeyDown += logoutButton_KeyDown;
        // 
        // userSettingsButton
        // 
        userSettingsButton.BackColor = Color.Transparent;
        userSettingsButton.Location = new Point(965, 251);
        userSettingsButton.Name = "userSettingsButton";
        userSettingsButton.Size = new Size(194, 40);
        userSettingsButton.TabIndex = 9;
        userSettingsButton.Text = "User Settings";
        userSettingsButton.UseVisualStyleBackColor = false;
        userSettingsButton.KeyDown += userSettingsButton_KeyDown;
        // 
        // systemSettingsButton
        // 
        systemSettingsButton.BackColor = Color.Transparent;
        systemSettingsButton.Location = new Point(964, 206);
        systemSettingsButton.Name = "systemSettingsButton";
        systemSettingsButton.Size = new Size(194, 40);
        systemSettingsButton.TabIndex = 8;
        systemSettingsButton.Text = "System Settings";
        systemSettingsButton.UseVisualStyleBackColor = false;
        systemSettingsButton.KeyDown += systemSettingsButton_KeyDown;
        // 
        // recordsButton
        // 
        recordsButton.BackColor = Color.Transparent;
        recordsButton.Location = new Point(644, 220);
        recordsButton.Name = "recordsButton";
        recordsButton.Size = new Size(194, 40);
        recordsButton.TabIndex = 7;
        recordsButton.Text = "Records";
        recordsButton.UseVisualStyleBackColor = false;
        recordsButton.KeyDown += recordsButton_KeyDown;
        // 
        // manageBrandButton
        // 
        manageBrandButton.BackColor = Color.Transparent;
        manageBrandButton.Location = new Point(316, 472);
        manageBrandButton.Name = "manageBrandButton";
        manageBrandButton.Size = new Size(194, 40);
        manageBrandButton.TabIndex = 6;
        manageBrandButton.Text = "Manage Brand (B)";
        manageBrandButton.UseVisualStyleBackColor = false;
        manageBrandButton.Click += manageBrandButton_Click;
        manageBrandButton.KeyDown += manageBrandButton_KeyDown;
        // 
        // manageCategoryButton
        // 
        manageCategoryButton.BackColor = Color.Transparent;
        manageCategoryButton.Location = new Point(316, 422);
        manageCategoryButton.Name = "manageCategoryButton";
        manageCategoryButton.Size = new Size(194, 40);
        manageCategoryButton.TabIndex = 5;
        manageCategoryButton.Text = "Manage Category (C)";
        manageCategoryButton.UseVisualStyleBackColor = false;
        manageCategoryButton.Click += manageCategoryButton_Click;
        manageCategoryButton.KeyDown += manageCategoryButton_KeyDown;
        // 
        // manageProductButton
        // 
        manageProductButton.BackColor = Color.Transparent;
        manageProductButton.Location = new Point(316, 372);
        manageProductButton.Name = "manageProductButton";
        manageProductButton.Size = new Size(194, 40);
        manageProductButton.TabIndex = 4;
        manageProductButton.Text = "Manage Products (P)";
        manageProductButton.UseVisualStyleBackColor = false;
        manageProductButton.Click += manageProductButton_Click;
        manageProductButton.KeyDown += manageProductButton_KeyDown;
        // 
        // manageSalesButton
        // 
        manageSalesButton.BackColor = Color.Transparent;
        manageSalesButton.Location = new Point(315, 324);
        manageSalesButton.Name = "manageSalesButton";
        manageSalesButton.Size = new Size(194, 40);
        manageSalesButton.TabIndex = 3;
        manageSalesButton.Text = "Manage Sales (S)";
        manageSalesButton.UseVisualStyleBackColor = false;
        manageSalesButton.Click += manageSalesButton_Click;
        manageSalesButton.KeyDown += manageSalesButton_KeyDown;
        // 
        // dashboardButton
        // 
        dashboardButton.BackColor = Color.White;
        dashboardButton.ForeColor = Color.Black;
        dashboardButton.Location = new Point(4, 220);
        dashboardButton.Name = "dashboardButton";
        dashboardButton.Size = new Size(194, 40);
        dashboardButton.TabIndex = 2;
        dashboardButton.Text = "Dashboard";
        dashboardButton.UseVisualStyleBackColor = false;
        dashboardButton.KeyDown += dashboardButton_KeyDown;
        // 
        // adminLabel
        // 
        adminLabel.ForeColor = Color.White;
        adminLabel.Location = new Point(44, 53);
        adminLabel.Name = "adminLabel";
        adminLabel.Size = new Size(108, 24);
        adminLabel.TabIndex = 1;
        adminLabel.Text = "Admin";
        adminLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // usernameLabel
        // 
        usernameLabel.BackColor = Color.Transparent;
        usernameLabel.ForeColor = Color.White;
        usernameLabel.Location = new Point(0, 4);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(198, 33);
        usernameLabel.TabIndex = 0;
        usernameLabel.Text = "Username";
        usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // stockInButton
        // 
        stockInButton.BackColor = Color.Transparent;
        stockInButton.Location = new Point(324, 101);
        stockInButton.Name = "stockInButton";
        stockInButton.Size = new Size(194, 40);
        stockInButton.TabIndex = 11;
        stockInButton.Text = "Stock In (I)";
        stockInButton.UseVisualStyleBackColor = false;
        stockInButton.Click += manageStockInButton_Click;
        stockInButton.KeyDown += stockInButton_KeyDown;
        // 
        // AdminDashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1184, 583);
        Controls.Add(stockInButton);
        Controls.Add(logoutButton);
        Controls.Add(userSettingsButton);
        Controls.Add(manageProductButton);
        Controls.Add(systemSettingsButton);
        Controls.Add(usernameLabel);
        Controls.Add(recordsButton);
        Controls.Add(adminLabel);
        Controls.Add(manageBrandButton);
        Controls.Add(dashboardButton);
        Controls.Add(manageCategoryButton);
        Controls.Add(manageSalesButton);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Name = "AdminDashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Admin Dashboard";
        KeyDown += AdminDashboardForm_KeyDown;
        ResumeLayout(false);
    }

    #endregion
    private Label usernameLabel;
    private Label adminLabel;
    private Button dashboardButton;
    private Button recordsButton;
    private Button manageBrandButton;
    private Button manageCategoryButton;
    private Button manageProductButton;
    private Button manageSalesButton;
    private Button systemSettingsButton;
    private Button userSettingsButton;
    private Button logoutButton;
    private Button stockInButton;
}