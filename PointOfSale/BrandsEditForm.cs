using Microsoft.Data.SqlClient;

namespace PointOfSale;

public partial class BrandsEditForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    DBConnection dbcon = new DBConnection();
    BrandsListForm brandsListForm;

    public BrandsEditForm(BrandsListForm brandsListForm)
    {
        InitializeComponent();

        cn = new SqlConnection(dbcon.MyConnection());
        this.brandsListForm = brandsListForm;
    }

    private void TextBoxClear()
    {
        saveButton.Enabled = true;
        updateButton.Enabled = false;

        brandNameTextBox.Clear();
        brandNameTextBox.Focus();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (MessageBox.Show("Are you sure you want to save this brand", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO Brand(brand) VALUES (@brand)", cn);
                cm.Parameters.AddWithValue("@brand", brandNameTextBox.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Brand Name has been successfully saved");
                TextBoxClear();
                brandsListForm.LoadRecords();
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
            if (MessageBox.Show("Are you sure you want to update this brand name", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Brand SET brand = @brand WHERE id like '" + originalBrandId.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand", brandNameTextBox.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Brand Name has been successfully updated");
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
        brandsListForm.LoadRecords();
    }


    #region Key Events

    private void brandNameTextBox_KeyDown(object sender, KeyEventArgs e)
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

    private void BrandsEditForm_KeyDown(object sender, KeyEventArgs e)
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
