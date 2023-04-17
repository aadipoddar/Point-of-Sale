using Microsoft.Data.SqlClient;

namespace PointOfSale;

public partial class BrandsListForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;

    DBConnection dbcon = new DBConnection();

    public BrandsListForm()
    {
        InitializeComponent();

        cn = new SqlConnection(dbcon.MyConnection());
        LoadRecords();
    }

    public void LoadRecords()
    {
        int i = 0;
        dataGridViewbrands.Rows.Clear();
        cn.Open();
        cm = new SqlCommand("select * from Brand order by brand", cn);
        dr = cm.ExecuteReader();
        while (dr.Read())
        {
            i += 1;
            dataGridViewbrands.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
        }
        dr.Close();
        cn.Close();
    }

    private void addBrandButton_Click(object sender, EventArgs e)
    {
        BrandsEditForm frm = new BrandsEditForm(this);
        frm.Show();
    }
}
