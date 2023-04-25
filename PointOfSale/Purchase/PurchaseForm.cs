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

        public PurchaseForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbcon.MyConnection());

            purchaseDateTimePicker.Value = DateTime.Now;
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            DataGridRefresh();
        }

        public void DataGridRefresh()
        {
            this.vwStockInTableAdapter.Fill(this.pointOfSaleDataSet.vwStockIn);
        }

        private void referenceNoTextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewPurchase.DataSource as BindingSource).Filter = string.Format("{0} LIKE '%{1}%'", dataGridViewPurchase.Columns[1].DataPropertyName, referenceNoTextBox.Text);
        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            if ((referenceNoTextBox.Text != string.Empty) && (purchaseByTextBox.Text != string.Empty))
            {
                SearchProductsForm searchProductsForm = new SearchProductsForm(this);
                searchProductsForm.Show();

                searchProductsForm.referenceNo = referenceNoTextBox.Text;
                searchProductsForm.stockInBy = purchaseByTextBox.Text;
                searchProductsForm.stockInDate = purchaseDateTimePicker.Value;
            }

            else
            {
                MessageBox.Show("Please enter Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPurchase.Rows.Count > 0)
                {
                    if ((referenceNoTextBox.Text != string.Empty) && (purchaseByTextBox.Text != string.Empty))
                    {
                        if (MessageBox.Show("Are you sure you want to save these Records?", "Save Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < dataGridViewPurchase.Rows.Count; i++)
                            {
                                if (dataGridViewPurchase.Rows[i].Cells[7].Value.ToString() == "Pending")
                                {
                                    sqlConnection.Open();
                                    sqlCommand = new SqlCommand("UPDATE StockIn SET quantity = " + int.Parse(dataGridViewPurchase.Rows[i].Cells[4].Value.ToString()) + "" +
                                        ", status = 'Done' WHERE id = '" + dataGridViewPurchase.Rows[i].Cells[0].Value.ToString() + "'", sqlConnection);
                                    sqlCommand.ExecuteNonQuery();
                                    sqlConnection.Close();
                                }
                            }
                            DataGridRefresh();
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
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridViewPurchase.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewPurchase.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewPurchase.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        PurchaseEditForm purchaseEditForm = new PurchaseEditForm(this);
                        purchaseEditForm.Show();

                        purchaseEditForm.purchaseId = Convert.ToInt32(dataGridViewPurchase.Rows[rowIndex].Cells[0].Value);
                        purchaseEditForm.referenceNoTextBox.Text = dataGridViewPurchase.Rows[rowIndex].Cells[1].Value.ToString();
                        purchaseEditForm.pcodeTextBox.Text = dataGridViewPurchase.Rows[rowIndex].Cells[2].Value.ToString();
                        purchaseEditForm.productNameTextBox.Text = dataGridViewPurchase.Rows[rowIndex].Cells[3].Value.ToString();
                        purchaseEditForm.quantityNumericUpDown.Value = Convert.ToDecimal(dataGridViewPurchase.Rows[rowIndex].Cells[4].Value);
                        purchaseEditForm.purchaseDateTimePicker.Value = Convert.ToDateTime(dataGridViewPurchase.Rows[rowIndex].Cells[5].Value);
                        purchaseEditForm.purchaseByTextBox.Text = dataGridViewPurchase.Rows[rowIndex].Cells[6].Value.ToString();
                        purchaseEditForm.statusComboBox.Text = dataGridViewPurchase.Rows[rowIndex].Cells[7].Value.ToString();
                    }
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                int rowIndex = dataGridViewPurchase.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewPurchase.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewPurchase.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        if (dataGridViewPurchase.Rows[rowIndex].Cells[7].Value.ToString() == "Pending")
                        {
                            if (MessageBox.Show("Remove this Item?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                sqlConnection.Open();
                                sqlCommand = new SqlCommand("DELETE FROM StockIn WHERE id = '" + dataGridViewPurchase.Rows[rowIndex].Cells[0].Value.ToString() + "'", sqlConnection);
                                sqlCommand.ExecuteNonQuery();
                                sqlConnection.Close();

                                DataGridRefresh();

                                // Select the previous row
                                if (dataGridViewPurchase.Rows.Count > 1)
                                {
                                    int selectRowIndex = rowIndex - 1;
                                    if (selectRowIndex >= 0 && selectRowIndex < dataGridViewPurchase.Rows.Count)
                                    {
                                        dataGridViewPurchase.CurrentCell = dataGridViewPurchase.Rows[selectRowIndex].Cells[0];
                                        dataGridViewPurchase.Rows[selectRowIndex].Selected = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
