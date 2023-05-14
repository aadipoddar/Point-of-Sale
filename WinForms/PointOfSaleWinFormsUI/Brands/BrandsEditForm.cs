using WinForms.PointOfSaleLibrary.Data;
using WinForms.PointOfSaleLibrary.Models;

namespace WinForms.PointOfSale.Brands;

public partial class BrandsEditForm : Form
{
    BrandData brandData = new();
    BrandModel brandModel = new();

    BrandsListForm brandsListForm;

    public int brandId;

    public BrandsEditForm(BrandsListForm brandsListForm)
    {
        InitializeComponent();

        this.brandsListForm = brandsListForm;
    }

    private void TextBoxClear()
    {
        saveButton.Enabled = true;
        saveButton.Visible = true;

        updateButton.Enabled = false;
        updateButton.Visible = false;

        brandTextBox.Clear();
        brandTextBox.Focus();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to save this Brand", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            brandModel.BrandName = brandTextBox.Text;

            brandData.InsertBrand(brandModel);

            TextBoxClear();

            _ = brandsListForm.DataGridRefresh();
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to update this Brand Name", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            brandModel.BrandId = brandId;
            brandModel.BrandName = brandTextBox.Text;

            brandData.UpdateBrand(brandModel);

            cancelButton_Click(sender, e);
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
        _ = brandsListForm.DataGridRefresh();
    }
}
