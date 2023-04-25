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

namespace PointOfSale.Brands
{
    public partial class BrandsEditForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dBConnection = new DBConnection();

        public int brandId;

        BrandsListForm brandsListForm;

        public BrandsEditForm(BrandsListForm  brandsListForm)
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dBConnection.MyConnection());

            this.brandsListForm = brandsListForm;
        }

        private void TextBoxClear()
        {
            saveButton.Enabled = true;
            saveButton.Visible = true;

            updateButton.Enabled = false;
            updateButton.Visible = false;

            brandTextBox.Clear();
            brandTextBox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Brand", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("INSERT INTO Brand(brand) VALUES (@brand)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@brand", brandTextBox.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    TextBoxClear();

                    brandsListForm.DataGridRefresh();
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
                if (MessageBox.Show("Are you sure you want to update this Brand Name", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("UPDATE Brand SET brand = @brand WHERE id = '" + brandId + "'", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@brand", brandTextBox.Text);
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
            brandsListForm.DataGridRefresh();
        }
    }
}
