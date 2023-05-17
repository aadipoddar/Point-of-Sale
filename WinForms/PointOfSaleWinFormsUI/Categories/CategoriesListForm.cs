namespace WinForms.PointOfSale.Categories;

public partial class CategoriesListForm : Form
{
    CategoryData categoryData = new();
    List<CategoryModel> categories = new();

    public CategoriesListForm()
    {
        InitializeComponent();

        Task task = DataGridRefresh();
    }

    public async Task DataGridRefresh(string searchText = "")
    {
        categories = (await categoryData.GetCategoriesBySearch(searchText)).ToList();
        dataGridViewCategories.DataSource = new BindingSource(categories, null);

        dataGridViewCategories.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCategories.Columns[1].HeaderText = "Category Name";
    }

    private async void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        await DataGridRefresh(searchTextBox.Text);
    }

    private void addCategoriesButton_Click(object sender, EventArgs e)
    {
        CategoriesEditForm categoriesEditForm = new(this);
        categoriesEditForm.Show();

        categoriesEditForm.Text = "Add Category";

        categoriesEditForm.saveButton.Enabled = true;
        categoriesEditForm.saveButton.Visible = true;

        categoriesEditForm.updateButton.Enabled = false;
        categoriesEditForm.updateButton.Visible = false;
    }

    private async void dataGridViewCategories_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            int rowIndex = dataGridViewCategories.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewCategories.Rows.Count)
            {
                DataGridViewCell cell = dataGridViewCategories.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    CategoriesEditForm categoriesEditForm = new(this);
                    categoriesEditForm.Show();

                    categoriesEditForm.Text = "Edit Category";

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
            int rowIndex = dataGridViewCategories.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewCategories.Rows.Count)
            {
                DataGridViewCell cell = dataGridViewCategories.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await categoryData.DeleteCategory(Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells[0].Value));

                        await DataGridRefresh();

                        // Select the previous row
                        if (dataGridViewCategories.Rows.Count > 1)
                        {
                            int selectRowIndex = rowIndex - 1;
                            if (selectRowIndex >= 0 && selectRowIndex < dataGridViewCategories.Rows.Count)
                            {
                                dataGridViewCategories.CurrentCell = dataGridViewCategories.Rows[selectRowIndex].Cells[0];
                                dataGridViewCategories.Rows[selectRowIndex].Selected = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
