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

    private void KeyEvents(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.A)
        {
            addBrandButton_Click(sender, e);
        }

        if (e.KeyCode == Keys.Escape)
        {
            Close();
        }

        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.E)
        {
            dataGridViewbrands_CellContentClick(sender, new DataGridViewCellEventArgs(3, dataGridViewbrands.CurrentRow.Index));
        }

        if (e.KeyCode == Keys.Delete)
        {
            dataGridViewbrands_CellContentClick(sender, new DataGridViewCellEventArgs(4, dataGridViewbrands.CurrentRow.Index));
        }
    }

    private void BrandsListForm_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
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
        frm.updateButton.Visible = false;
        frm.updateButton.Enabled = false;
        frm.Text = "Add New Brand";
    }

    private void dataGridViewbrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        string colName = dataGridViewbrands.Columns[e.ColumnIndex].Name;

        if (colName == "editColumn")
        {
            BrandsEditForm frm = new BrandsEditForm(this);
            frm.originalBrandId.Text = dataGridViewbrands.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.brandNameTextBox.Text = dataGridViewbrands.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                cm = new SqlCommand("delete from Brand where id like '" + dataGridViewbrands.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Record has been successfully deleted");
                LoadRecords();
            }
        }
    }

    private void dataGridViewbrands_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }
}
