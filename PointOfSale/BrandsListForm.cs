namespace PointOfSale;

public partial class BrandsListForm : Form
{
    public BrandsListForm()
    {
        InitializeComponent();

        for (int i = 0; i <= 100; ++i)
        {
            dataGridViewbrands.Rows.Add(i, "1", "Brand " + i);
        }
    }

    private void addBrandButton_Click(object sender, EventArgs e)
    {
        BrandsEditForm frm = new BrandsEditForm();
        frm.Show();
    }
}
