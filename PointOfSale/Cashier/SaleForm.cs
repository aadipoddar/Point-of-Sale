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

using PointOfSale.Purchase;

namespace PointOfSale.Cashier
{
    public partial class SaleForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader sqlDataReader;

        DBConnection dbConnection = new DBConnection();

        public SaleForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbConnection.MyConnection());
            saleDateTimePicker.Value = DateTime.Now;
            GetTransactionNo();
        }

        private void GetTransactionNo()
        {
            try
            {
                string saleDate = saleDateTimePicker.Value.ToString("yyyyMMdd");
                string transactionNo = "";
                int count;
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT TOP 1 transactionNo FROM Sale WHERE transactionNo LIKE '" + saleDate + "%' ORDER BY id DESC", sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                if (sqlDataReader.HasRows)
                {
                    transactionNo = sqlDataReader[0].ToString();
                    string i = transactionNo.Substring(8, 4);
                    count = int.Parse(i);
                    transactionNoTextBox.Text = saleDate + (count + 1);
                }

                else
                {
                    transactionNo = saleDate + "1001";
                    transactionNoTextBox.Text = transactionNo;
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            SearchProductsForm searchProductsForm = new SearchProductsForm(this);
            searchProductsForm.Show();
        }

        private void dataGridViewCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int rowIndex = dataGridViewCart.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewCart.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewCart.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        dataGridViewCart.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }
    }
}
