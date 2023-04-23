using Microsoft.Data.SqlClient;

namespace PointOfSale.Products;

public partial class ProductsEditForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    DBConnection dbcon = new DBConnection();
    SqlDataReader dr;
    ProductsListForm productsListForm = new ProductsListForm();

    public ProductsEditForm(ProductsListForm productsListForm)
    {
        InitializeComponent();

        cn = new SqlConnection(dbcon.MyConnection());
        this.productsListForm = productsListForm;

        LoadBrand();
        LoadCategory();
    }

    private void TextBoxClear()
    {
        saveButton.Enabled = true;
        updateButton.Enabled = false;

        productCodeTextBox.Clear();
        descriptionTextBox.Clear();
        priceTextBox.Clear();
        brandComboBox.SelectedIndex = -1;
        categoryComboBox.SelectedIndex = -1;

        productCodeTextBox.Focus();
    }

    public void LoadCategory()
    {
        categoryComboBox.Items.Clear();

        cn.Open();
        cm = new SqlCommand("select category from Category", cn);
        dr = cm.ExecuteReader();

        while (dr.Read())
        {
            categoryComboBox.Items.Add(dr[0].ToString());
        }

        dr.Close();
        cn.Close();
    }

    public void LoadBrand()
    {
        brandComboBox.Items.Clear();

        cn.Open();
        cm = new SqlCommand("select brand from Brand", cn);
        dr = cm.ExecuteReader();

        while (dr.Read())
        {
            brandComboBox.Items.Add(dr[0].ToString());
        }

        dr.Close();
        cn.Close();
    }

    private string GetBrandId()
    {
        string brandId;
        cn.Open();
        cm = new SqlCommand("SELECT id from Brand where brand like '" + brandComboBox.Text + "'", cn);
        dr = cm.ExecuteReader();
        dr.Read();

        if (dr.HasRows)
            brandId = dr[0].ToString();
        else
        {
            MessageBox.Show("Invalid Brand");
            brandId = "-1";
        }

        dr.Close();
        cn.Close();
        return brandId;
    }

    private string GetCategoryId()
    {
        string categoryid;
        cn.Open();
        cm = new SqlCommand("SELECT id from Category where category like '" + categoryComboBox.Text + "'", cn);
        dr = cm.ExecuteReader();
        dr.Read();

        if (dr.HasRows)
            categoryid = dr[0].ToString();
        else
        {
            MessageBox.Show("Invalid Category");
            categoryid = "-1";
        }

        dr.Close();
        cn.Close();
        return categoryid;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (MessageBox.Show("Are you sure you want to save this Product", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string brandId = GetBrandId();
                string categoryId = GetCategoryId();


                cn.Open();
                cm = new SqlCommand("INSERT INTO Product(pcode, [description], brandId, categoryId, price) VALUES (@pcode, @pdescription, @brandId, @categoryId, @price)", cn);

                cm.Parameters.AddWithValue("@pcode", productCodeTextBox.Text);
                cm.Parameters.AddWithValue("@pdescription", descriptionTextBox.Text);
                cm.Parameters.AddWithValue("@brandId", brandId);
                cm.Parameters.AddWithValue("@categoryId", categoryId);
                cm.Parameters.AddWithValue("@price", priceTextBox.Text);

                cm.ExecuteNonQuery();

                MessageBox.Show("Product has been successfully saved");
                TextBoxClear();
                productsListForm.LoadRecords();

                cn.Close();
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
                string brandId = GetBrandId();
                string categoryId = GetCategoryId();

                cn.Open();
                cm = new SqlCommand("UPDATE Product SET description = @description, brandId = @brandId, categoryId = @categoryId, price = @price where pcode like @pcode", cn);

                cm.Parameters.AddWithValue("@pcode", productCodeTextBox.Text);
                cm.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                cm.Parameters.AddWithValue("@brandId", brandId);
                cm.Parameters.AddWithValue("@categoryId", categoryId);
                cm.Parameters.AddWithValue("@price", priceTextBox.Text);

                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Product has been successfully Updated");

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
        productsListForm.LoadRecords();
    }


    #region Key Events

    private void productCodeTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void descriptionTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void brandComboBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void categoryComboBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void priceTextBox_KeyDown(object sender, KeyEventArgs e)
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

        if (e.KeyCode == Keys.Escape)
        {
            cancelButton_Click(this, new EventArgs());
        }
    }

    private void ProductsEditForm_KeyDown(object sender, KeyEventArgs e)
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
