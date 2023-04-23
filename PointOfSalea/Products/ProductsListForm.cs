using System.Data;

using Microsoft.Data.SqlClient;

namespace PointOfSale.Products;

public partial class ProductsListForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;

    DBConnection dbcon = new DBConnection();

    public ProductsListForm()
    {
        InitializeComponent();

        cn = new SqlConnection(dbcon.MyConnection());
        //LoadRecords();

        dataGridViewProducts.Focus();
    }

    #region Key Events

    private void KeyEvents(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.A)
        {
            addProductButton_Click(sender, e);
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
            dataGridViewProducts_CellContentClick(sender, new DataGridViewCellEventArgs(6, dataGridViewProducts.CurrentRow.Index));
        }

        if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.D)
        {
            dataGridViewProducts_CellContentClick(sender, new DataGridViewCellEventArgs(7, dataGridViewProducts.CurrentRow.Index));
        }
    }

    private void ProductsListForm_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void dataGridViewProducts_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void addProductButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    #endregion

    public void LoadRecords()
    {
        dataGridViewProducts.Rows.Clear();
        cn.Open();
        cm = new SqlCommand("Select p.pcode, p.description, b.brand, c.category, p.price, p.quantity from Product as p inner join Brand as b on b.id = p.brandId  inner join Category as c on c.id = p.categoryId order by p.description", cn);

        //SqlDataAdapter da = new SqlDataAdapter(cm);
        //DataTable dt = new DataTable();
        //da.Fill(dt);
        //dataGridViewProducts.DataSource = dt;
        //cn.Close();

        dr = cm.ExecuteReader();

        while (dr.Read())
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridViewProducts);
            row.Cells[0].Value = dr["pcode"];
            row.Cells[1].Value = dr["description"];
            row.Cells[2].Value = dr["brand"];
            row.Cells[3].Value = dr["category"];
            row.Cells[4].Value = dr["price"];
            row.Cells[5].Value = dr["quantity"];
            dataGridViewProducts.Rows.Add(row);
        }

        dr.Close();
        cn.Close();
    }

    private void addProductButton_Click(object sender, EventArgs e)
    {
        ProductsEditForm frm = new ProductsEditForm(this);
        frm.Show();
        frm.updateButton.Visible = false;
        frm.updateButton.Enabled = false;
        frm.LoadCategory();
        frm.LoadBrand();
        frm.Text = "Add New Product";
    }

    private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        string colName = dataGridViewProducts.Columns[e.ColumnIndex].Name;

        if (colName == "editColumn")
        {

            ProductsEditForm frm = new ProductsEditForm(this);
            frm.saveButton.Visible = false;
            frm.saveButton.Enabled = false;
            frm.Text = "Edit Product";

            frm.productCodeTextBox.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.descriptionTextBox.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.brandComboBox.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            frm.categoryComboBox.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
            frm.priceTextBox.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[5].Value.ToString();

            frm.productCodeTextBox.ReadOnly = true;
            frm.descriptionTextBox.Select();

            frm.Show();
        }

        else if (colName == "deleteColumn")
        {
            if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("delete from Product where pcode like '" + dataGridViewProducts.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Record has been successfully deleted");
                LoadRecords();
            }
        }
    }

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        LoadRecords();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        LoadRecords();
    }
}
