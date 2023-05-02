using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinForms.PointOfSale.Brands
{
    public partial class BrandsListForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnection dbConnection = new DBConnection();

        public BrandsListForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(dbConnection.MyConnection());
        }

        private void BrandsListForm_Load(object sender, EventArgs e)
        {
            DataGridRefresh();
        }

        public void DataGridRefresh()
        {
            this.brandTableAdapter.Fill(this.pointOfSaleDataSet.Brand);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewBrands.DataSource as BindingSource).Filter = string.Format("{0} LIKE '%{1}%'", dataGridViewBrands.Columns[1].DataPropertyName, searchTextBox.Text);
        }

        private void addBrandsButton_Click(object sender, EventArgs e)
        {
            BrandsEditForm brandsEditForm = new BrandsEditForm(this);
            brandsEditForm.Show();

            brandsEditForm.Text = "Add Brand";

            brandsEditForm.updateButton.Enabled = false;
            brandsEditForm.updateButton.Visible = false;

            brandsEditForm.saveButton.Enabled = true;
            brandsEditForm.saveButton.Visible = true;
        }

        private void dataGridViewBrands_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridViewBrands.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewBrands.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewBrands.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        BrandsEditForm brandsEditForm = new BrandsEditForm(this);
                        brandsEditForm.Show();

                        brandsEditForm.Text = "Edit Brand";

                        brandsEditForm.saveButton.Visible = false;
                        brandsEditForm.saveButton.Enabled = false;

                        brandsEditForm.updateButton.Visible = true;
                        brandsEditForm.updateButton.Enabled = true;

                        brandsEditForm.brandId = Convert.ToInt32(dataGridViewBrands.Rows[rowIndex].Cells[0].Value);
                        brandsEditForm.brandTextBox.Text = dataGridViewBrands.Rows[rowIndex].Cells[1].Value.ToString();

                        brandsEditForm.brandTextBox.Select();
                    }
                }
            }

            else if (e.KeyCode == Keys.Delete)
            {
                int rowIndex = dataGridViewBrands.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewBrands.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewBrands.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand("DELETE FROM Brand WHERE id = '" + dataGridViewBrands.Rows[rowIndex].Cells[0].Value.ToString() + "'", sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();

                            DataGridRefresh();

                            // Select the previous row
                            if (dataGridViewBrands.Rows.Count > 1)
                            {
                                int selectRowIndex = rowIndex - 1;
                                if (selectRowIndex >= 0 && selectRowIndex < dataGridViewBrands.Rows.Count)
                                {
                                    dataGridViewBrands.CurrentCell = dataGridViewBrands.Rows[selectRowIndex].Cells[0];
                                    dataGridViewBrands.Rows[selectRowIndex].Selected = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
