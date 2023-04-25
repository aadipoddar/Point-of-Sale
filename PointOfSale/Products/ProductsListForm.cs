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

namespace PointOfSale.Products
{
    public partial class ProductsListForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dbConnection = new DBConnection();

        public ProductsListForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbConnection.MyConnection());
        }

        private void ProductsListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointOfSaleDataSet.vwShowProducts' table. You can move, or remove it, as needed.
            this.vwShowProductsTableAdapter.Fill(this.pointOfSaleDataSet.vwShowProducts);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewProducts.DataSource as BindingSource).Filter = string.Format("{0} LIKE '%{1}%'", dataGridViewProducts.Columns[1].DataPropertyName, searchTextBox.Text);
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
            ProductsEditForm productsEditForm = new ProductsEditForm();
            productsEditForm.Show();
            productsEditForm.Text = "Add Products";

            productsEditForm.saveButton.Visible = true;
            productsEditForm.saveButton.Enabled = true;

            productsEditForm.updateButton.Visible = false;
            productsEditForm.updateButton.Enabled = false;
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
                        ProductsEditForm productsEditForm = new ProductsEditForm();
                        productsEditForm.Show();

                        productsEditForm.Text = "Edit Product";

                        productsEditForm.saveButton.Visible = false;
                        productsEditForm.saveButton.Enabled = false;

                        productsEditForm.updateButton.Visible = true;
                        productsEditForm.updateButton.Enabled = true;

                        productsEditForm.pcodeNumericUpDown.Value = Convert.ToInt32(dataGridViewProducts.Rows[rowIndex].Cells[0].Value);
                        productsEditForm.descriptionTextBox.Text = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
                        productsEditForm.brandComboBox.Text = dataGridViewProducts.Rows[rowIndex].Cells[2].Value.ToString();
                        productsEditForm.categoryComboBox.Text = dataGridViewProducts.Rows[rowIndex].Cells[3].Value.ToString();
                        productsEditForm.priceNumericUpDown.Value = Convert.ToDecimal(dataGridViewProducts.Rows[rowIndex].Cells[4].Value);

                        productsEditForm.pcodeNumericUpDown.ReadOnly = true;
                        productsEditForm.descriptionTextBox.Select();
                    }
                }
            }

            else if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = dataGridViewProducts.CurrentCell.RowIndex;
                    if (rowIndex >= 0 && rowIndex < dataGridViewProducts.Rows.Count)
                    {
                        DataGridViewCell cell = dataGridViewProducts.Rows[rowIndex].Cells[1];
                        if (cell != null && cell.Value != null)
                        {
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand("DELETE FROM Product WHERE pcode = '" + dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString() + "'", sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();

                            MessageBox.Show("Record has been successfully deleted");
                        }
                    }
                }
            }
        }
    }
}
