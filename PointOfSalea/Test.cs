using System.Data;

using Microsoft.Data.SqlClient;

namespace PointOfSale;

public partial class Test : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;

    DBConnection dbcon = new DBConnection();

    public Test()
    {
        InitializeComponent();

        cn = new SqlConnection(dbcon.MyConnection());
    }

    private void button1_Click(object sender, EventArgs e)
    {
        cn.Open();
        cm = new SqlCommand("Select p.pcode, p.description, b.brand, c.category, p.price, p.quantity from Product as p inner join Brand as b on b.id = p.brandId  inner join Category as c on c.id = p.categoryId order by p.description", cn);

        DataTable dt = new DataTable();
        dt.Load(cm.ExecuteReader());
        dataGridView1.DataSource = dt;

        cn.Close();

    }
}
