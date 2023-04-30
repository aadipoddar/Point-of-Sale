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

        public PurchaseForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbcon.MyConnection());

            purchaseDateTimePicker.Value = DateTime.Now;
            GetTransactionNo();
        }


        private void purchaseDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            GetTransactionNo();
        }

        private void GetTransactionNo()
        {
            try
            {
                string saleDate = purchaseDateTimePicker.Value.ToString("yyyyMMdd");
                string transactionNo = "";
                int count;

                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT TOP 1 transactionNo FROM Purchase WHERE transactionNo LIKE 'P" + saleDate + "%' ORDER BY id DESC", sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                if (sqlDataReader.HasRows)
                {
                    transactionNo = sqlDataReader[0].ToString();
                    string i = transactionNo.Substring(9);
                    count = int.Parse(i);
                    transactionNoTextBox.Text = transactionNo.Substring(0, 9) + (count + 1);
                }

                else
                {
                    transactionNo = "P" + saleDate + "1001";
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

        private void dataGridViewPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteProductFromCart();
            }
        }

        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCart.Rows.Count > 0)
            {
                int rowIndex = dataGridViewCart.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewCart.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewCart.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        updateProductPanel.Visible = true;

                        quantityNumericUpDown.Value = Convert.ToInt16(dataGridViewCart.Rows[rowIndex].Cells[2].Value);
                        pricePerQuantityNumericUpDown.Value = Convert.ToDecimal(dataGridViewCart.Rows[rowIndex].Cells[3].Value);
                        totalPriceProductNumericUpDown.Value = Convert.ToDecimal(dataGridViewCart.Rows[rowIndex].Cells[5].Value);

                        quantityNumericUpDown.Focus();
                    }
                }
            }
        }


        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalPriceProductNumericUpDown.Value = quantityNumericUpDown.Value * pricePerQuantityNumericUpDown.Value;
            dataGridViewCart.CurrentRow.Cells[2].Value = quantityNumericUpDown.Value;
            UpdateTotal();
        }

        private void pricePerQuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalPriceProductNumericUpDown.Value = quantityNumericUpDown.Value * pricePerQuantityNumericUpDown.Value;
            dataGridViewCart.CurrentRow.Cells[3].Value = pricePerQuantityNumericUpDown.Value;
            UpdateTotal();
        }

        private void totalPriceProductNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pricePerQuantityNumericUpDown.Value = totalPriceProductNumericUpDown.Value / quantityNumericUpDown.Value;
            dataGridViewCart.CurrentRow.Cells[5].Value = totalPriceProductNumericUpDown.Value;
            UpdateTotal();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProductFromCart();
        }

        private void DeleteProductFromCart()
        {
            int rowIndex = dataGridViewCart.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewCart.Rows.Count)
            {
                DataGridViewCell cell = dataGridViewCart.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    dataGridViewCart.Rows.RemoveAt(rowIndex);
                    UpdateTotal();
                }
            }
        }


        public void UpdateTotal()
        {
            double subTotal = 0;
            double tax = 0;
            double finalPrize = 0;

            for (int i = 0; i < dataGridViewCart.RowCount; i++)
            {
                dataGridViewCart.Rows[i].Cells[5].Value =
                    Convert.ToDouble(dataGridViewCart.Rows[i].Cells[2].Value)
                        * Convert.ToDouble(dataGridViewCart.Rows[i].Cells[3].Value);

                dataGridViewCart.Rows[i].Cells[6].Value =
                    Convert.ToDouble(dataGridViewCart.Rows[i].Cells[4].Value) / 100
                        * Convert.ToDouble(dataGridViewCart.Rows[i].Cells[5].Value);

                dataGridViewCart.Rows[i].Cells[7].Value =
                    Convert.ToDouble(dataGridViewCart.Rows[i].Cells[5].Value)
                        + Convert.ToDouble(dataGridViewCart.Rows[i].Cells[6].Value);

                subTotal += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[5].Value);
                tax += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[6].Value);
                finalPrize += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[7].Value);
            }

            if ((subTotal + tax) - finalPrize <= 1)
            {
                subTotalTextBox.Text = subTotal.ToString("#,##0.00");
                totalTaxTextBox.Text = tax.ToString("#,##0.00");
                totalTextBox.Text = finalPrize.ToString("#,##0.00");
            }

            else
            {
                MessageBox.Show("Error in Calculation! Retry Purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int GetPurchaseId()
        {
            int purchaseId = 1;

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT MAX(id) FROM Purchase", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                if (sqlDataReader.IsDBNull(0))
                {
                    MessageBox.Show("No Purchase Record Found! Please retry Bill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    purchaseId = sqlDataReader.GetInt32(0);
                }
            }

            sqlDataReader.Close();
            sqlConnection.Close();

            return purchaseId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCart.Rows.Count > 0)
                {
                    if (purchaseByTextBox.Text != string.Empty)
                    {
                        if (MessageBox.Show("Are you sure you want to save these Records?", "Save Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Purchase Table
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand("INSERT INTO Purchase(transactionNo, purchaseBy, purchaseDate, subTotal, tax, total) VALUES" +
                                " (@transactionNo, @purchaseBy, @purchaseDate, @subTotal, @tax, @total)", sqlConnection);

                            sqlCommand.Parameters.AddWithValue("@transactionNo", transactionNoTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@purchaseBy", purchaseByTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@purchaseDate", purchaseDateTimePicker.Value);
                            sqlCommand.Parameters.AddWithValue("@subTotal", Convert.ToDecimal(subTotalTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@tax", Convert.ToDecimal(totalTaxTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@total", Convert.ToDecimal(totalTextBox.Text));

                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();

                            int purchaseId = GetPurchaseId();

                            // Purchase Detail Table
                            sqlConnection.Open();
                            for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
                            {
                                sqlCommand = new SqlCommand("INSERT INTO PurchaseDetail(purchaseId, productId, quantity, pricePerQuantity, subTotal, tax, total) VALUES" +
                                    " (@purchaseId, @productId, @quantity, @pricePerQuantity, @subTotal, @tax, @total)", sqlConnection);

                                sqlCommand.Parameters.AddWithValue("@purchaseId", purchaseId);
                                sqlCommand.Parameters.AddWithValue("@productId", int.Parse(dataGridViewCart.Rows[i].Cells[0].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@quantity", int.Parse(dataGridViewCart.Rows[i].Cells[2].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@pricePerQuantity", double.Parse(dataGridViewCart.Rows[i].Cells[3].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@subTotal", double.Parse(dataGridViewCart.Rows[i].Cells[5].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@tax", double.Parse(dataGridViewCart.Rows[i].Cells[6].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@total", double.Parse(dataGridViewCart.Rows[i].Cells[7].Value.ToString()));

                                sqlCommand.ExecuteNonQuery();
                            }
                            sqlConnection.Close();

                            // Inventory Table
                            sqlConnection.Open();
                            for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
                            {
                                sqlCommand = new SqlCommand("INSERT INTO Inventory(productId, quantity, billNo, price) VALUES" +
                                   " (@productId, @quantity, @billNo, @price)", sqlConnection);

                                sqlCommand.Parameters.AddWithValue("@productId", int.Parse(dataGridViewCart.Rows[i].Cells[0].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@quantity", int.Parse(dataGridViewCart.Rows[i].Cells[2].Value.ToString()));
                                sqlCommand.Parameters.AddWithValue("@billNo", transactionNoTextBox.Text);
                                sqlCommand.Parameters.AddWithValue("@price", double.Parse(dataGridViewCart.Rows[i].Cells[7].Value.ToString()));

                                sqlCommand.ExecuteNonQuery();
                            }
                            sqlConnection.Close();

                            TextBoxClear();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please enter the name of the person who is purchasing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("Please add some products to cart!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
            }
        }

        private void TextBoxClear()
        {
            dataGridViewCart.Rows.Clear();
            transactionNoTextBox.Clear();
            purchaseDateTimePicker.Value = DateTime.Now;
            purchaseByTextBox.Clear();
            subTotalTextBox.Clear();
            totalTaxTextBox.Clear();
            totalTextBox.Clear();

            updateProductPanel.Visible = false;

            GetTransactionNo();
        }
    }
}
