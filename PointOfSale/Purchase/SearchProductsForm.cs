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
    public partial class SearchProductsForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public string referenceNo;
        public string stockInBy;
        public DateTime stockInDate;

        PurchaseForm purchaseForm;

        public SearchProductsForm(PurchaseForm purchaseForm)
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbcon.MyConnection());

            this.purchaseForm = purchaseForm;
        }

        private void SearchProductsForm_Load(object sender, EventArgs e)
        {
            this.vwShowProductsTableAdapter.Fill(this.pointOfSaleDataSet.vwShowProducts);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewProducts.DataSource as BindingSource).Filter = string.Format("{0} LIKE '%{1}%'", dataGridViewProducts.Columns[1].DataPropertyName, searchTextBox.Text);
        }

        private void dataGridViewProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridViewProducts.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewProducts.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewProducts.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        if (MessageBox.Show("Add this Item?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sqlConnection.Open();

                            sqlCommand = new SqlCommand("INSERT INTO StockIn(referenceNo, pcode, quantity, stockInDate, stockInBy) VALUES (@referenceNo, @pcode, @quantity, @stockInDate, @stockInBy)", sqlConnection);
                            sqlCommand.Parameters.AddWithValue("@referenceNo", referenceNo);
                            sqlCommand.Parameters.AddWithValue("@pcode", dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString());
                            sqlCommand.Parameters.AddWithValue("@quantity", quantityNumericUpDown.Value);
                            sqlCommand.Parameters.AddWithValue("@stockInDate", stockInDate);
                            sqlCommand.Parameters.AddWithValue("@stockInBy", stockInBy);

                            sqlCommand.ExecuteNonQuery();

                            sqlConnection.Close();

                            purchaseForm.DataGridRefresh();
                        }
                    }
                }
            }
        }
    }
}
