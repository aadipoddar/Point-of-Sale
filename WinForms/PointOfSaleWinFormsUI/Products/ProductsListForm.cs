namespace WinForms.PointOfSale.Products;

public partial class ProductsListForm : Form
{
    ProductData productData = new();
    List<ShowProductModel> products = new();

    public ProductsListForm()
    {
        InitializeComponent();

        Task task = DataGridRefresh();
    }

    public async Task DataGridRefresh(string searchText = "")
    {
        products = (await productData.GetProductsBySearch(searchText)).ToList();
        dataGridViewProducts.DataSource = new BindingSource(products, null);

        dataGridViewProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private async void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        await DataGridRefresh(searchTextBox.Text);
    }

    private void addProductsButton_Click(object sender, EventArgs e)
    {
        ProductsEditForm productsEditForm = new(this);
        productsEditForm.Show();
        productsEditForm.Text = "Add Products";

        productsEditForm.saveButton.Visible = true;
        productsEditForm.saveButton.Enabled = true;

        productsEditForm.updateButton.Visible = false;
        productsEditForm.updateButton.Enabled = false;

        productsEditForm.brnadName = "";
        productsEditForm.categoryName = "";
    }

    private async void dataGridViewProducts_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            int rowIndex = dataGridViewProducts.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewProducts.Rows.Count)
            {
                DataGridViewCell cell = dataGridViewProducts.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    ProductsEditForm productsEditForm = new(this);
                    productsEditForm.Show();


                    productsEditForm.Text = "Edit Product";

                    productsEditForm.saveButton.Visible = false;
                    productsEditForm.saveButton.Enabled = false;

                    productsEditForm.updateButton.Visible = true;
                    productsEditForm.updateButton.Enabled = true;

                    productsEditForm.productId = Convert.ToInt32(dataGridViewProducts.Rows[rowIndex].Cells[0].Value);
                    productsEditForm.descriptionTextBox.Text = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();

                    productsEditForm.brnadName = dataGridViewProducts.Rows[rowIndex].Cells[2].Value.ToString();
                    productsEditForm.categoryName = dataGridViewProducts.Rows[rowIndex].Cells[3].Value.ToString();

                    productsEditForm.priceNumericUpDown.Value = Convert.ToDecimal(dataGridViewProducts.Rows[rowIndex].Cells[4].Value);
                    productsEditForm.taxNumericUpDown.Value = Convert.ToDecimal(dataGridViewProducts.Rows[rowIndex].Cells[6].Value);

                    productsEditForm.descriptionTextBox.Select();

                    await productsEditForm.LoadComboBox();
                }
            }
        }

        else if (e.KeyCode == Keys.Delete)
        {
            int rowIndex = dataGridViewProducts.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewProducts.Rows.Count)
            {
                DataGridViewCell cell = dataGridViewProducts.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await productData.DeleteProduct(Convert.ToInt32(dataGridViewProducts.Rows[rowIndex].Cells[0].Value));

                        await DataGridRefresh();

                        // Select the previous row
                        if (dataGridViewProducts.Rows.Count > 1)
                        {
                            int selectRowIndex = rowIndex - 1;
                            if (selectRowIndex >= 0 && selectRowIndex < dataGridViewProducts.Rows.Count)
                            {
                                dataGridViewProducts.CurrentCell = dataGridViewProducts.Rows[selectRowIndex].Cells[0];
                                dataGridViewProducts.Rows[selectRowIndex].Selected = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
