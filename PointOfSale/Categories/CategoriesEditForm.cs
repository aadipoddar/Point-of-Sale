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

namespace PointOfSale.Categories
{
    public partial class CategoriesEditForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dBConnection = new DBConnection();

        public int categoryId;

        CategoriesListForm categoriesListForm;

        public CategoriesEditForm(CategoriesListForm categoriesListForm)
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dBConnection.MyConnection());

            this.categoriesListForm = categoriesListForm;
        }

        private void TextBoxClear()
        {
            saveButton.Enabled = true;
            saveButton.Visible = true;

            updateButton.Enabled = false;
            updateButton.Visible = false;

            categoryTextBox.Clear();
            categoryTextBox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("INSERT INTO Category(category) VALUES (@category)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@category", categoryTextBox.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    TextBoxClear();

                    categoriesListForm.DataGridRefresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Category name", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("UPDATE Category SET category = @category WHERE id =  '" + categoryId + "'", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@category", categoryTextBox.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    cancelButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            categoriesListForm.DataGridRefresh();
        }
    }
}
