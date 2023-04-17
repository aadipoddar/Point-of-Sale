using Microsoft.Data.SqlClient;

namespace PointOfSale;

public partial class AdminDashboardForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    DBConnection dbcon = new DBConnection();

    public AdminDashboardForm()
    {
        InitializeComponent();

        // cn = new SqlConnection(dbcon.MyConnection());
        // cn.Open();
        // MessageBox.Show("Connected");
        // cn.Close();
    }

    private void manageBrandButton_Click(object sender, EventArgs e)
    {
        BrandsForm frm = new BrandsForm();
        // frm.TopLevel = false;
        // leftPanel.Controls.Add(frm);
        // frm.BringToFront();
        frm.Show();
    }
}
