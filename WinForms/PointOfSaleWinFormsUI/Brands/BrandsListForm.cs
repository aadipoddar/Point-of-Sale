namespace WinForms.PointOfSale.Brands;

public partial class BrandsListForm : Form
{
    BrandData brandData = new();
    List<BrandModel> brands = new();

    public BrandsListForm()
    {
        InitializeComponent();

        Task task = DataGridRefresh();
    }

    public async Task DataGridRefresh(string searchText = "")
    {
        brands = (await brandData.GetBrandsBySearch(searchText)).ToList();
        dataGridViewBrands.DataSource = new BindingSource(brands, null);

        dataGridViewBrands.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewBrands.Columns[1].HeaderText = "Brand Name";
    }

    private async void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        await DataGridRefresh(searchTextBox.Text);
    }

    private void addBrandsButton_Click(object sender, EventArgs e)
    {
        BrandsEditForm brandsEditForm = new(this);
        brandsEditForm.Show();

        brandsEditForm.Text = "Add Brand";

        brandsEditForm.updateButton.Enabled = false;
        brandsEditForm.updateButton.Visible = false;

        brandsEditForm.saveButton.Enabled = true;
        brandsEditForm.saveButton.Visible = true;
    }

    private async void dataGridViewBrands_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            int rowIndex = dataGridViewBrands.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewBrands.Rows.Count)
            {
                DataGridViewCell cell = dataGridViewBrands.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    BrandsEditForm brandsEditForm = new(this);
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
                        await brandData.DeleteBrand(Convert.ToInt32(dataGridViewBrands.Rows[rowIndex].Cells[0].Value));

                        await DataGridRefresh();

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
