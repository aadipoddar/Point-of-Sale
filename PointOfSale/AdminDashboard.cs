using Microsoft.Data.SqlClient;

namespace PointOfSale;

public partial class AdminDashboard : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    DBConnection dbcon = new DBConnection();

    public AdminDashboard()
    {
        InitializeComponent();
        cn = new SqlConnection(dbcon.MyConnection());
        cn.Open();
        MessageBox.Show("Connected");
        cn.Close();
    }
}
