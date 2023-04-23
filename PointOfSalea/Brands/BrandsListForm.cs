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

    #region Key Events

    private void KeyEvents(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.A)
        {
            addBrandButton_Click(sender, e);
        }

        if (e.KeyCode == Keys.S)
        {
            searchTextBox.Focus();
        }

        if (e.KeyCode == Keys.Escape)
        {
            Close();
        }

        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.E)
        {
            dataGridViewbrands_CellContentClick(sender, new DataGridViewCellEventArgs(3, dataGridViewBrands.CurrentRow.Index));
        }

        if (e.KeyCode == Keys.Delete)
        {
            dataGridViewbrands_CellContentClick(sender, new DataGridViewCellEventArgs(4, dataGridViewBrands.CurrentRow.Index));
        }
    }

    private void BrandsListForm_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void dataGridViewbrands_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void addBrandButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    #endregion

    public void LoadRecords()
    {
        int i = 0;

        dataGridViewBrands.Rows.Clear();
        cn.Open();
        cm = new SqlCommand("select * from Brand order by brand", cn);
        dr = cm.ExecuteReader();

        while (dr.Read())
        {
            i += 1;
            dataGridViewBrands.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
        }

        dr.Close();
        cn.Close();
    }

    private void addBrandButton_Click(object sender, EventArgs e)
    {
        BrandsEditForm frm = new BrandsEditForm(this);
        frm.Show();
        frm.updateButton.Visible = false;
        frm.updateButton.Enabled = false;
        frm.Text = "Add New Brand";
    }

    private void dataGridViewbrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        string colName = dataGridViewBrands.Columns[e.ColumnIndex].Name;

        if (colName == "editColumn")
        {
            BrandsEditForm frm = new BrandsEditForm(this);
            frm.originalBrandId.Text = dataGridViewBrands.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.brandNameTextBox.Text = dataGridViewBrands.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.saveButton.Visible = false;
            frm.saveButton.Enabled = false;
            frm.Text = "Edit Brand";
            frm.Show();
        }

        else if (colName == "deleteColumn")
        {
            if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("delete from Brand where id like '" + dataGridViewBrands.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Record has been successfully deleted");
                LoadRecords();
            }
        }
    }

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        dataGridViewBrands.Rows.Clear();

        cn.Open();
        cm = new SqlCommand("select * from Brand where brand like '%" + searchTextBox.Text + "%' order by brand", cn);
        dr = cm.ExecuteReader();

        int i = 0;
        while (dr.Read())
        {
            i += 1;
            dataGridViewBrands.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
        }

        dr.Close();
        cn.Close();
    }
}
