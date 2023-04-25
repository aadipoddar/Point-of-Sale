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
    public partial class ProductsEditForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dbConnection = new DBConnection();
        SqlDataReader sqlDataReader;

        public ProductsEditForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbConnection.MyConnection());

            GetPcode();
        }

        private void ProductsEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointOfSaleDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.pointOfSaleDataSet.Category);
            // TODO: This line of code loads data into the 'pointOfSaleDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.pointOfSaleDataSet.Brand);
        }


        #region Miscellaneous

        private void GetPcode()
        {
            int maxPcode = 0;

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT MAX(pcode) FROM Product", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                maxPcode = sqlDataReader.GetInt32(0);
            }

            sqlConnection.Close();

            pcodeNumericUpDown.Value = maxPcode + 1;
        }

        private void TextBoxClear()
        {
            saveButton.Enabled = true;
            saveButton.Visible = true;

            updateButton.Enabled = false;
            updateButton.Visible = false;

            pcodeNumericUpDown.Value = 0;
            descriptionTextBox.Clear();
            priceNumericUpDown.Value = 0;
            brandComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndex = 0;

            GetPcode();
            descriptionTextBox.Focus();
        }

        #endregion


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Product", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlConnection.Open();

                    sqlCommand = new SqlCommand("INSERT INTO Product([description], brandId, categoryId, price) VALUES (@pdescription, @brandId, @categoryId, @price)", sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@pdescription", descriptionTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@brandId", brandComboBox.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@categoryId", categoryComboBox.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@price", priceNumericUpDown.Text);

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    TextBoxClear();
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
                if (MessageBox.Show("Are you sure you want to update this Product", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("UPDATE Product SET description = @description, brandId = @brandId, categoryId = @categoryId, price = @price where pcode like @pcode", sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@pcode", pcodeNumericUpDown.Text);
                    sqlCommand.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@brandId", brandComboBox.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@categoryId", categoryComboBox.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@price", priceNumericUpDown.Text);

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
        }
    }
}
