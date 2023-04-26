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

        ProductsListForm productsListForm;

        public int productId;

        public ProductsEditForm(ProductsListForm productsListForm)
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbConnection.MyConnection());
            
            this.productsListForm = productsListForm;
        }

        private void ProductsEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointOfSaleDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.pointOfSaleDataSet.Category);
            // TODO: This line of code loads data into the 'pointOfSaleDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.pointOfSaleDataSet.Brand);
        }

        private void TextBoxClear()
        {
            saveButton.Enabled = true;
            saveButton.Visible = true;

            updateButton.Enabled = false;
            updateButton.Visible = false;

            descriptionTextBox.Clear();
            priceNumericUpDown.Value = 0;
            brandComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndex = 0;

            descriptionTextBox.Focus();
        }

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

                    productsListForm.DataGridRefresh();
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
                    sqlCommand = new SqlCommand("UPDATE Product SET description = @description, brandId = @brandId, categoryId = @categoryId, price = @price where id like @id", sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@id", productId);
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
            
            productsListForm.DataGridRefresh();
        }
    }
}
