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

namespace PointOfSale.Cashier
{
    public partial class SettlePaymentForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader sqlDataReader;

        SaleForm saleForm;

        public SettlePaymentForm(SaleForm saleForm)
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbcon.MyConnection());
            this.saleForm = saleForm;
        }

        private void cashNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            changeTextBox.Text = (cashNumericUpDown.Value - Convert.ToDecimal(totalTextBox.Text)).ToString();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Sale Master table
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO Sale (transactionNo, saleDate, subTotal, discount, tax, total, cashGiven, change) VALUES" +
                    " (@transactionNo, @saleDate, @subTotal, @discount, @tax, @total, @cashGiven, @change)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@transactionNo", saleForm.transactionNoTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@saleDate", saleForm.saleDateTimePicker.Value);
                sqlCommand.Parameters.AddWithValue("@subTotal", Convert.ToDecimal(saleForm.subTotalTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@discount", Convert.ToDecimal(saleForm.finalDiscountTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@tax", Convert.ToDecimal(saleForm.taxableTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@total", Convert.ToDecimal(saleForm.totalTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@cashGiven", Convert.ToDecimal(cashNumericUpDown.Value));
                sqlCommand.Parameters.AddWithValue("@change", Convert.ToDecimal(changeTextBox.Text));

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                int saleId = GetSaleId();

                // Sale Details table
                sqlConnection.Open();
                for (int i = 0; i < saleForm.dataGridViewCart.RowCount; i++)
                {
                    sqlCommand = new SqlCommand("INSERT INTO SaleDetail (saleId, productId, quantity, price, discountAmount, discountPercent, finalPrize) VALUES" +
                                               " (@saleId, @productId, @quantity, @price, @discountAmount, @discountPercent, @finalPrize)", sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@saleId", saleId);
                    sqlCommand.Parameters.AddWithValue("@productId", Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[0].Value));
                    sqlCommand.Parameters.AddWithValue("@quantity", Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[2].Value));
                    sqlCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[3].Value));
                    sqlCommand.Parameters.AddWithValue("@discountAmount", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[4].Value));
                    sqlCommand.Parameters.AddWithValue("@discountPercent", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[6].Value));
                    sqlCommand.Parameters.AddWithValue("@finalPrize", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[7].Value));

                    sqlCommand.ExecuteNonQuery();
                }

                sqlConnection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSaleId()
        {
            int saleId = 1;

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT MAX(id) FROM Sale", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                if (sqlDataReader.IsDBNull(0))
                {
                    saleId = 1;
                }
                else
                {
                    saleId = sqlDataReader.GetInt32(0) + 1;
                }
            }

            sqlConnection.Close();

            return saleId;
        }
    }
}
