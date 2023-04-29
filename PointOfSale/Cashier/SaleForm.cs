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

        int taxPercentage = 10;

        public SaleForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbConnection.MyConnection());
            saleDateTimePicker.Value = DateTime.Now;
            GetTransactionNo();

            searchProductsButton.Focus();
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

        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowProductUpdatePanel();
        }

        private void dataGridViewCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowProductUpdatePanel();
            }

            if (e.KeyCode == Keys.Delete)
            {
                DeleteProductFromCart();
            }
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
                }
            }
        }

        private void ShowProductUpdatePanel()
        {
            int rowIndex = dataGridViewCart.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewCart.Rows.Count)
            {
                DataGridViewCell cell = dataGridViewCart.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    updateProductPanel.Visible = true;
                    quantityNumericUpDown.Maximum = Convert.ToInt16(dataGridViewCart.CurrentRow.Cells[8].Value);
                    discountAmountNumericUpDown.Maximum = Convert.ToDecimal(dataGridViewCart.CurrentRow.Cells[3].Value);

                    quantityNumericUpDown.Focus();

                    quantityNumericUpDown.Value = Convert.ToInt16(dataGridViewCart.Rows[rowIndex].Cells[2].Value);
                    discountAmountNumericUpDown.Value = Convert.ToDecimal(dataGridViewCart.Rows[rowIndex].Cells[5].Value);
                    discountPercentNumericUpDown.Value = Convert.ToDecimal(dataGridViewCart.Rows[rowIndex].Cells[6].Value);

                    if (discountAmountNumericUpDown.Value > 0)
                    {
                        orLabel.Visible = false;
                        discountPercentLabel.Visible = false;
                        discountPercentNumericUpDown.Visible = false;
                    }

                    if (discountPercentNumericUpDown.Value > 0)
                    {
                        orLabel.Visible = false;
                        discountAmountLabel.Visible = false;
                        discountAmountNumericUpDown.Visible = false;
                    }
                };
            }
        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Check if discount amount is greater than the total amount
            if (Convert.ToDecimal(dataGridViewCart.CurrentRow.Cells[4].Value)
                > (Convert.ToDecimal(dataGridViewCart.CurrentRow.Cells[9].Value)
                * quantityNumericUpDown.Value) &&
                Convert.ToDecimal(dataGridViewCart.CurrentRow.Cells[6].Value) == 0)
            {
                MessageBox.Show("Conflict Setting discount amount for this product to 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                discountAmountNumericUpDown.Value = 0;
                discountPercentNumericUpDown.Value = 0;

                dataGridViewCart.CurrentRow.Cells[4].Value = 0;
                dataGridViewCart.CurrentRow.Cells[5].Value = 0;
                dataGridViewCart.CurrentRow.Cells[6].Value = 0;
            }

            dataGridViewCart.CurrentRow.Cells[2].Value = quantityNumericUpDown.Value;
            discountAmountNumericUpDown.Maximum = Convert.ToDecimal(dataGridViewCart.CurrentRow.Cells[9].Value) * quantityNumericUpDown.Value;

            UpdateTotal();
        }

        private void discountAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewCart.CurrentRow.Cells[5].Value = discountAmountNumericUpDown.Value;

            if (discountAmountNumericUpDown.Value > 0)
            {
                orLabel.Visible = false;
                discountPercentLabel.Visible = false;
                discountPercentNumericUpDown.Visible = false;

                int rowIndex = dataGridViewCart.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewCart.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewCart.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        dataGridViewCart.Rows[rowIndex].Cells[6].Value = 0;
                    }
                }
            }

            if (discountAmountNumericUpDown.Value == 0)
            {
                orLabel.Visible = true;
                discountPercentLabel.Visible = true;
                discountPercentNumericUpDown.Visible = true;
            }

            UpdateTotal();
        }

        private void discountPercentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewCart.CurrentRow.Cells[6].Value = discountPercentNumericUpDown.Value;

            if (discountPercentNumericUpDown.Value > 0)
            {
                orLabel.Visible = false;
                discountAmountLabel.Visible = false;
                discountAmountNumericUpDown.Visible = false;

                int rowIndex = dataGridViewCart.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewCart.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewCart.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        dataGridViewCart.Rows[rowIndex].Cells[5].Value = 0;
                    }
                }
            }

            if (discountPercentNumericUpDown.Value == 0)
            {
                orLabel.Visible = true;
                discountAmountLabel.Visible = true;
                discountAmountNumericUpDown.Visible = true;
            }

            UpdateTotal();
        }

        public void UpdateTotal()
        {
            double subTotal = 0;
            double finalDiscount = 0;
            double subTotalAfterDiscount = 0;

            for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[4].Value) <= Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[3].Value))
                {
                    dataGridViewCart.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[2].Value)
                                                                * Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[9].Value);

                    #region Discount Calculation

                    double discount = 0;

                    if (Convert.ToInt16(dataGridViewCart.Rows[i].Cells[5].Value) == 0)
                    {
                        if (Convert.ToInt16(dataGridViewCart.Rows[i].Cells[6].Value) == 0)
                        {
                            discount = 0.0;
                        }

                        else if (Convert.ToInt16(dataGridViewCart.Rows[i].Cells[6].Value) > 0)
                        {
                            discount = (Convert.ToDouble(dataGridViewCart.Rows[i].Cells[6].Value) / 100) *
                                Convert.ToDouble(dataGridViewCart.Rows[i].Cells[3].Value);
                        }
                    }

                    else if (Convert.ToInt16(dataGridViewCart.Rows[i].Cells[5].Value) > 0)
                    {
                        discount = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[5].Value);
                    }

                    dataGridViewCart.Rows[i].Cells[4].Value = discount;
                    finalDiscount += discount;

                    #endregion

                    subTotal += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[3].Value);

                    dataGridViewCart.Rows[i].Cells[7].Value = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[3].Value) - discount;

                    subTotalAfterDiscount += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[7].Value);
                }

                else
                {
                    MessageBox.Show("There is some Error Please Retry the Bill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            subTotalTextBox.Text = subTotal.ToString("#,##0.00");

            finalDiscountTextBox.Text = finalDiscount.ToString("#,##0.00");

            if (subTotalAfterDiscount - Convert.ToDouble(subTotal - finalDiscount) <= 0.2)
            {
                subTotalAfterDiscountTextBox.Text = (subTotalAfterDiscount).ToString("#,##0.00");
            }

            else
            {
                MessageBox.Show("There is some Error Please Retry the Bill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            taxableTextBox.Text = (subTotalAfterDiscount * taxPercentage / 100).ToString("#,##0.00");

            totalTextBox.Text = (subTotalAfterDiscount + Convert.ToDouble(taxableTextBox.Text)).ToString("#,##0.00");
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            SettlePaymentForm settlePaymentForm = new SettlePaymentForm();
            settlePaymentForm.ShowDialog();
        }
    }
}
