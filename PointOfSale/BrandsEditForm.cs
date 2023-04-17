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
            if (MessageBox.Show("Are you sure you want to save this brand", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
        brandsListForm.LoadRecords();
    }
}
