namespace PointOfSale;

partial class AdminDashboard
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
        SuspendLayout();
        // 
        // leftPanel
        // 
        leftPanel.BackColor = Color.Black;
        leftPanel.Location = new Point(0, 0);
        leftPanel.Name = "leftPanel";
        leftPanel.Size = new Size(250, 600);
        leftPanel.TabIndex = 0;
        // 
        // AdminDashboard
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1184, 561);
        Controls.Add(leftPanel);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        Name = "AdminDashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Admin Dashboard";
        ResumeLayout(false);
    }

    #endregion

    private Panel leftPanel;
}