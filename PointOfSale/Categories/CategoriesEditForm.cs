using Microsoft.Data.SqlClient;

namespace PointOfSale.Categories;

public partial class CategoriesEditForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    DBConnection dbcon = new DBConnection();
    CategoriesListForm categoriesListForm = new CategoriesListForm();

    public CategoriesEditForm(CategoriesListForm categoriesListForm)
    {
        InitializeComponent();

        cn = new SqlConnection(dbcon.MyConnection());
        this.categoriesListForm = categoriesListForm;
    }

    private void TextBoxClear()
    {
        saveButton.Enabled = true;
        updateButton.Enabled = false;

        categoryNameTextBox.Clear();
        categoryNameTextBox.Focus();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (MessageBox.Show("Are you sure you want to save this Category", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO Category(category) VALUES (@category)", cn);
                cm.Parameters.AddWithValue("@category", categoryNameTextBox.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Category Name has been successfully saved");
                TextBoxClear();
                categoriesListForm.LoadRecords();
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
                cn.Open();
                cm = new SqlCommand("UPDATE Category SET category = @category WHERE id like '" + originalCategoryId.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", categoryNameTextBox.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Category Name has been successfully updated");
                TextBoxClear();
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
        categoriesListForm.LoadRecords();
    }


    #region Key Events

    private void categoryNameTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (saveButton.Enabled == true)
            {
                saveButton_Click(this, new EventArgs());
            }

            if (updateButton.Enabled == true)
            {
                updateButton_Click(this, new EventArgs());
            }
        }

        else if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void CategoriesEditForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (saveButton.Enabled == true)
            {
                saveButton_Click(this, new EventArgs());
            }

            else if (updateButton.Enabled == false)
            {
                updateButton_Click(this, new EventArgs());
            }
        }

        else if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void saveButton_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void updateButton_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void cancelButton_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    #endregion
}
