namespace WinForms.PointOfSale.Sale;

partial class SettlePaymentForm
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
        this.totalTextBox = new System.Windows.Forms.TextBox();
        this.totalLabel = new System.Windows.Forms.Label();
        this.cashLabel = new System.Windows.Forms.Label();
        this.changeTextBox = new System.Windows.Forms.TextBox();
        this.changeLabel = new System.Windows.Forms.Label();
        this.payButton = new System.Windows.Forms.Button();
        this.cashNumericUpDown = new System.Windows.Forms.NumericUpDown();
        this.transactionNoLabel = new System.Windows.Forms.Label();
        this.transactionNoTextBox = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.cashNumericUpDown)).BeginInit();
        this.SuspendLayout();
        // 
        // totalTextBox
        // 
        this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.totalTextBox.Location = new System.Drawing.Point(218, 78);
        this.totalTextBox.Name = "totalTextBox";
        this.totalTextBox.ReadOnly = true;
        this.totalTextBox.Size = new System.Drawing.Size(254, 47);
        this.totalTextBox.TabIndex = 3;
        this.totalTextBox.Text = "0.00";
        this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // totalLabel
        // 
        this.totalLabel.AutoSize = true;
        this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.totalLabel.Location = new System.Drawing.Point(8, 81);
        this.totalLabel.Name = "totalLabel";
        this.totalLabel.Size = new System.Drawing.Size(94, 39);
        this.totalLabel.TabIndex = 2;
        this.totalLabel.Text = "Total";
        // 
        // cashLabel
        // 
        this.cashLabel.AutoSize = true;
        this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cashLabel.Location = new System.Drawing.Point(12, 160);
        this.cashLabel.Name = "cashLabel";
        this.cashLabel.Size = new System.Drawing.Size(98, 39);
        this.cashLabel.TabIndex = 6;
        this.cashLabel.Text = "Cash";
        // 
        // changeTextBox
        // 
        this.changeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.changeTextBox.Location = new System.Drawing.Point(218, 237);
        this.changeTextBox.Name = "changeTextBox";
        this.changeTextBox.ReadOnly = true;
        this.changeTextBox.Size = new System.Drawing.Size(254, 47);
        this.changeTextBox.TabIndex = 4;
        this.changeTextBox.Text = "0.00";
        this.changeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // changeLabel
        // 
        this.changeLabel.AutoSize = true;
        this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.changeLabel.Location = new System.Drawing.Point(12, 239);
        this.changeLabel.Name = "changeLabel";
        this.changeLabel.Size = new System.Drawing.Size(137, 39);
        this.changeLabel.TabIndex = 5;
        this.changeLabel.Text = "Change";
        // 
        // payButton
        // 
        this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.payButton.Location = new System.Drawing.Point(148, 312);
        this.payButton.Name = "payButton";
        this.payButton.Size = new System.Drawing.Size(156, 59);
        this.payButton.TabIndex = 1;
        this.payButton.Text = "PAY";
        this.payButton.UseVisualStyleBackColor = true;
        this.payButton.Click += new System.EventHandler(this.payButton_Click);
        // 
        // cashNumericUpDown
        // 
        this.cashNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cashNumericUpDown.Location = new System.Drawing.Point(218, 161);
        this.cashNumericUpDown.Maximum = new decimal(new int[] {
        1000000,
        0,
        0,
        0});
        this.cashNumericUpDown.Name = "cashNumericUpDown";
        this.cashNumericUpDown.Size = new System.Drawing.Size(254, 40);
        this.cashNumericUpDown.TabIndex = 0;
        this.cashNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.cashNumericUpDown.ValueChanged += new System.EventHandler(this.cashNumericUpDown_ValueChanged);
        // 
        // transactionNoLabel
        // 
        this.transactionNoLabel.AutoSize = true;
        this.transactionNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.transactionNoLabel.Location = new System.Drawing.Point(14, 18);
        this.transactionNoLabel.Name = "transactionNoLabel";
        this.transactionNoLabel.Size = new System.Drawing.Size(158, 25);
        this.transactionNoLabel.TabIndex = 7;
        this.transactionNoLabel.Text = "Transaction No";
        // 
        // transactionNoTextBox
        // 
        this.transactionNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.transactionNoTextBox.Location = new System.Drawing.Point(218, 15);
        this.transactionNoTextBox.Name = "transactionNoTextBox";
        this.transactionNoTextBox.ReadOnly = true;
        this.transactionNoTextBox.Size = new System.Drawing.Size(254, 31);
        this.transactionNoTextBox.TabIndex = 8;
        this.transactionNoTextBox.Text = "0";
        this.transactionNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // SettlePaymentForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(486, 383);
        this.Controls.Add(this.transactionNoTextBox);
        this.Controls.Add(this.transactionNoLabel);
        this.Controls.Add(this.cashNumericUpDown);
        this.Controls.Add(this.payButton);
        this.Controls.Add(this.changeTextBox);
        this.Controls.Add(this.changeLabel);
        this.Controls.Add(this.cashLabel);
        this.Controls.Add(this.totalTextBox);
        this.Controls.Add(this.totalLabel);
        this.Name = "SettlePaymentForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Payment";
        ((System.ComponentModel.ISupportInitialize)(this.cashNumericUpDown)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.TextBox totalTextBox;
    private System.Windows.Forms.Label totalLabel;
    private System.Windows.Forms.Label cashLabel;
    public System.Windows.Forms.TextBox changeTextBox;
    private System.Windows.Forms.Label changeLabel;
    public System.Windows.Forms.Button payButton;
    public System.Windows.Forms.NumericUpDown cashNumericUpDown;
    private System.Windows.Forms.Label transactionNoLabel;
    public System.Windows.Forms.TextBox transactionNoTextBox;
}