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

using PointOfSale.Products;

namespace PointOfSale.Categories
{
    public partial class CategoriesListForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dbConnection = new DBConnection();

        public CategoriesListForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbConnection.MyConnection());
        }

        private void CategoriesListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointOfSaleDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.pointOfSaleDataSet.Category);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewCategories.DataSource as BindingSource).Filter = string.Format("{0} LIKE '%{1}%'", dataGridViewCategories.Columns[1].DataPropertyName, searchTextBox.Text);
        }

        private void addCategoriesButton_Click(object sender, EventArgs e)
        {
            CategoriesEditForm categoriesEditForm = new CategoriesEditForm();
            categoriesEditForm.Show();

            categoriesEditForm.Text = "Add Category";

            categoriesEditForm.saveButton.Enabled = true;
            categoriesEditForm.saveButton.Visible = true;

            categoriesEditForm.updateButton.Enabled = false;
            categoriesEditForm.updateButton.Visible = false;
        }

        private void dataGridViewCategories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridViewCategories.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewCategories.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewCategories.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        CategoriesEditForm categoriesEditForm = new CategoriesEditForm();
                        categoriesEditForm.Show();

                        categoriesEditForm.Text = "Edit Product";

                        categoriesEditForm.saveButton.Visible = false;
                        categoriesEditForm.saveButton.Enabled = false;

                        categoriesEditForm.updateButton.Visible = true;
                        categoriesEditForm.updateButton.Enabled = true;

                        categoriesEditForm.categoryId = Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells[0].Value);
                        categoriesEditForm.categoryTextBox.Text = dataGridViewCategories.Rows[rowIndex].Cells[1].Value.ToString();

                        categoriesEditForm.categoryTextBox.Select();
                    }
                }
            }

            else if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = dataGridViewCategories.CurrentCell.RowIndex;
                    if (rowIndex >= 0 && rowIndex < dataGridViewCategories.Rows.Count)
                    {
                        DataGridViewCell cell = dataGridViewCategories.Rows[rowIndex].Cells[1];
                        if (cell != null && cell.Value != null)
                        {
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand("DELETE FROM Category WHERE id = '" + dataGridViewCategories.Rows[rowIndex].Cells[0].Value.ToString() + "'", sqlConnection);
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
