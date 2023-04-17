namespace PointOfSale;

public partial class AdminDashboardForm : Form
{
    public AdminDashboardForm()
    {
        InitializeComponent();
    }

    private void manageBrandButton_Click(object sender, EventArgs e)
    {
        BrandsListForm frm = new BrandsListForm();
        frm.Show();
    }
}
