using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Purchase
{
    public partial class PurchaseEditForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public int purchaseId;

        PurchaseForm purchaseForm;

        public PurchaseEditForm(PurchaseForm purchaseForm)
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbcon.MyConnection());

            this.purchaseForm = purchaseForm;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update these Records?", "Update Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("UPDATE StockIn SET referenceNo = @referenceNo, quantity = @quantity, stockInBy = @stockInBy, stockInDate = @stockInDate, status = @status" +
                    " WHERE id = @id", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@referenceNo", referenceNoTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@quantity", quantityNumericUpDown.Value);
                sqlCommand.Parameters.AddWithValue("@stockInBy", purchaseByTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@stockInDate", purchaseDateTimePicker.Value);
                sqlCommand.Parameters.AddWithValue("@status", statusComboBox.Text);
                sqlCommand.Parameters.AddWithValue("@id", purchaseId);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                cancelButton_Click(sender, e);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            purchaseForm.DataGridRefresh();
        }
    }
}
