namespace PointOfSale.Cashier
{
    partial class CashierDashboardForm
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
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.newTransactionButton = new System.Windows.Forms.Button();
            this.dailySalesButton = new System.Windows.Forms.Button();
            this.cancelSalesButton = new System.Windows.Forms.Button();
            this.settlePaymentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiscountButton.Location = new System.Drawing.Point(115, 216);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(208, 50);
            this.addDiscountButton.TabIndex = 5;
            this.addDiscountButton.Text = "Add Discount";
            this.addDiscountButton.UseVisualStyleBackColor = true;
            // 
            // searchProductButton
            // 
            this.searchProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductButton.Location = new System.Drawing.Point(115, 148);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(208, 50);
            this.searchProductButton.TabIndex = 4;
            this.searchProductButton.Text = "Search Product";
            this.searchProductButton.UseVisualStyleBackColor = true;
            // 
            // newTransactionButton
            // 
            this.newTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTransactionButton.Location = new System.Drawing.Point(115, 80);
            this.newTransactionButton.Name = "newTransactionButton";
            this.newTransactionButton.Size = new System.Drawing.Size(208, 50);
            this.newTransactionButton.TabIndex = 3;
            this.newTransactionButton.Text = "New Transaction";
            this.newTransactionButton.UseVisualStyleBackColor = true;
            // 
            // dailySalesButton
            // 
            this.dailySalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailySalesButton.Location = new System.Drawing.Point(380, 216);
            this.dailySalesButton.Name = "dailySalesButton";
            this.dailySalesButton.Size = new System.Drawing.Size(208, 50);
            this.dailySalesButton.TabIndex = 8;
            this.dailySalesButton.Text = "Daily Sales";
            this.dailySalesButton.UseVisualStyleBackColor = true;
            // 
            // cancelSalesButton
            // 
            this.cancelSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSalesButton.Location = new System.Drawing.Point(380, 148);
            this.cancelSalesButton.Name = "cancelSalesButton";
            this.cancelSalesButton.Size = new System.Drawing.Size(208, 50);
            this.cancelSalesButton.TabIndex = 7;
            this.cancelSalesButton.Text = "Cancel Sales";
            this.cancelSalesButton.UseVisualStyleBackColor = true;
            // 
            // settlePaymentButton
            // 
            this.settlePaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlePaymentButton.Location = new System.Drawing.Point(380, 80);
            this.settlePaymentButton.Name = "settlePaymentButton";
            this.settlePaymentButton.Size = new System.Drawing.Size(208, 50);
            this.settlePaymentButton.TabIndex = 6;
            this.settlePaymentButton.Text = "Settle Payment";
            this.settlePaymentButton.UseVisualStyleBackColor = true;
            // 
            // CashierDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 399);
            this.Controls.Add(this.dailySalesButton);
            this.Controls.Add(this.cancelSalesButton);
            this.Controls.Add(this.settlePaymentButton);
            this.Controls.Add(this.addDiscountButton);
            this.Controls.Add(this.searchProductButton);
            this.Controls.Add(this.newTransactionButton);
            this.Name = "CashierDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.Button newTransactionButton;
        private System.Windows.Forms.Button dailySalesButton;
        private System.Windows.Forms.Button cancelSalesButton;
        private System.Windows.Forms.Button settlePaymentButton;
    }
}