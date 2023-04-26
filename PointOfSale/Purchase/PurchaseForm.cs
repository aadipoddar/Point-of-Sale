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
    public partial class PurchaseForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader sqlDataReader;

        int purchaseId;

        public PurchaseForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbcon.MyConnection());

            purchaseDateTimePicker.Value = DateTime.Now;
            GetPurchaseId();
        }

        private void GetPurchaseId()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT MAX(id) FROM Purchase", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                if (sqlDataReader.IsDBNull(0))
                {
                    purchaseId = 1;
                }
                else
                {
                    purchaseId = sqlDataReader.GetInt32(0) + 1;
                }
            }

            sqlConnection.Close();
        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            if (purchaseByTextBox.Text != string.Empty)
            {
                SearchProductsForm searchProductsForm = new SearchProductsForm(this);
                searchProductsForm.Show();
            }

            else
            {
                MessageBox.Show("Please enter Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                purchaseByTextBox.Focus();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPurchase.Rows.Count > 0)
                {
                    if (purchaseByTextBox.Text != string.Empty)
                    {
                        if (MessageBox.Show("Are you sure you want to save these Records?", "Save Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Purchase Table
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand("INSERT INTO Purchase(id, purchaseBy, purchaseDate) VALUES (@id, @purchaseBy, @purchaseDate)", sqlConnection);

                            sqlCommand.Parameters.AddWithValue("@id", purchaseId);
                            sqlCommand.Parameters.AddWithValue("@purchaseBy", purchaseByTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@purchaseDate", purchaseDateTimePicker.Value);

                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();


                            // Purchase Detail Table
                            sqlConnection.Open();
                            for (int i = 0; i < dataGridViewPurchase.Rows.Count; i++)
                            {
                                sqlCommand = new SqlCommand("INSERT INTO PurchaseDetail(purchaseId, productId, quantity, status) VALUES (@purchaseId, @productId, @quantity, @status)", sqlConnection);

                                sqlCommand.Parameters.AddWithValue("@purchaseId", purchaseId);
                                sqlCommand.Parameters.AddWithValue("@productId", int.Parse(dataGridViewPurchase.Rows[i].Cells[0].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@quantity", int.Parse(dataGridViewPurchase.Rows[i].Cells[2].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@status", "Done");

                                sqlCommand.ExecuteNonQuery();
                            }
                            sqlConnection.Close();

                            dataGridViewPurchase.Rows.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int rowIndex = dataGridViewPurchase.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewPurchase.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewPurchase.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        dataGridViewPurchase.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }
    }
}
