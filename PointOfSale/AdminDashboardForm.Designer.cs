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
        leftPanel = new Panel();
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
        leftPanel.SuspendLayout();
        SuspendLayout();
        // 
        // leftPanel
        // 
        leftPanel.BackColor = Color.Black;
        leftPanel.Controls.Add(logoutButton);
        leftPanel.Controls.Add(userSettingsButton);
        leftPanel.Controls.Add(systemSettingsButton);
        leftPanel.Controls.Add(recordsButton);
        leftPanel.Controls.Add(manageBrandButton);
        leftPanel.Controls.Add(manageCategoryButton);
        leftPanel.Controls.Add(manageProductButton);
        leftPanel.Controls.Add(manageSalesButton);
        leftPanel.Controls.Add(dashboardButton);
        leftPanel.Controls.Add(adminLabel);
        leftPanel.Controls.Add(usernameLabel);
        leftPanel.Location = new Point(0, 0);
        leftPanel.Name = "leftPanel";
        leftPanel.Size = new Size(250, 618);
        leftPanel.TabIndex = 0;
        // 
        // logoutButton
        // 
        logoutButton.BackColor = Color.Transparent;
        logoutButton.Location = new Point(38, 552);
        logoutButton.Name = "logoutButton";
        logoutButton.Size = new Size(176, 31);
        logoutButton.TabIndex = 10;
        logoutButton.Text = "Log Out";
        logoutButton.UseVisualStyleBackColor = false;
        // 
        // userSettingsButton
        // 
        userSettingsButton.BackColor = Color.Transparent;
        userSettingsButton.Location = new Point(28, 479);
        userSettingsButton.Name = "userSettingsButton";
        userSettingsButton.Size = new Size(194, 40);
        userSettingsButton.TabIndex = 9;
        userSettingsButton.Text = "User Settings";
        userSettingsButton.UseVisualStyleBackColor = false;
        // 
        // systemSettingsButton
        // 
        systemSettingsButton.BackColor = Color.Transparent;
        systemSettingsButton.Location = new Point(28, 434);
        systemSettingsButton.Name = "systemSettingsButton";
        systemSettingsButton.Size = new Size(194, 40);
        systemSettingsButton.TabIndex = 8;
        systemSettingsButton.Text = "System Settings";
        systemSettingsButton.UseVisualStyleBackColor = false;
        // 
        // recordsButton
        // 
        recordsButton.BackColor = Color.Transparent;
        recordsButton.Location = new Point(28, 371);
        recordsButton.Name = "recordsButton";
        recordsButton.Size = new Size(194, 40);
        recordsButton.TabIndex = 7;
        recordsButton.Text = "Records";
        recordsButton.UseVisualStyleBackColor = false;
        // 
        // manageBrandButton
        // 
        manageBrandButton.BackColor = Color.Transparent;
        manageBrandButton.Location = new Point(28, 306);
        manageBrandButton.Name = "manageBrandButton";
        manageBrandButton.Size = new Size(194, 40);
        manageBrandButton.TabIndex = 6;
        manageBrandButton.Text = "Manage Brand";
        manageBrandButton.UseVisualStyleBackColor = false;
        manageBrandButton.Click += manageBrandButton_Click;
        // 
        // manageCategoryButton
        // 
        manageCategoryButton.BackColor = Color.Transparent;
        manageCategoryButton.Location = new Point(28, 256);
        manageCategoryButton.Name = "manageCategoryButton";
        manageCategoryButton.Size = new Size(194, 40);
        manageCategoryButton.TabIndex = 5;
        manageCategoryButton.Text = "Manage Category";
        manageCategoryButton.UseVisualStyleBackColor = false;
        // 
        // manageProductButton
        // 
        manageProductButton.BackColor = Color.Transparent;
        manageProductButton.Location = new Point(28, 206);
        manageProductButton.Name = "manageProductButton";
        manageProductButton.Size = new Size(194, 40);
        manageProductButton.TabIndex = 4;
        manageProductButton.Text = "Manage Products";
        manageProductButton.UseVisualStyleBackColor = false;
        // 
        // manageSalesButton
        // 
        manageSalesButton.BackColor = Color.Transparent;
        manageSalesButton.Location = new Point(28, 158);
        manageSalesButton.Name = "manageSalesButton";
        manageSalesButton.Size = new Size(194, 40);
        manageSalesButton.TabIndex = 3;
        manageSalesButton.Text = "Manage Sales";
        manageSalesButton.UseVisualStyleBackColor = false;
        // 
        // dashboardButton
        // 
        dashboardButton.BackColor = Color.Transparent;
        dashboardButton.Location = new Point(28, 94);
        dashboardButton.Name = "dashboardButton";
        dashboardButton.Size = new Size(194, 40);
        dashboardButton.TabIndex = 2;
        dashboardButton.Text = "Dashboard";
        dashboardButton.UseVisualStyleBackColor = false;
        // 
        // adminLabel
        // 
        adminLabel.ForeColor = Color.White;
        adminLabel.Location = new Point(68, 49);
        adminLabel.Name = "adminLabel";
        adminLabel.Size = new Size(108, 24);
        adminLabel.TabIndex = 1;
        adminLabel.Text = "Admin";
        adminLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // usernameLabel
        // 
        usernameLabel.ForeColor = Color.White;
        usernameLabel.Location = new Point(24, 0);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(198, 33);
        usernameLabel.TabIndex = 0;
        usernameLabel.Text = "Username";
        usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AdminDashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1184, 583);
        Controls.Add(leftPanel);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Name = "AdminDashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Admin Dashboard";
        leftPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel leftPanel;
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
}