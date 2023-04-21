using Microsoft.Data.SqlClient;

namespace PointOfSale.StockIn;

public partial class SearchProductsStockInForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;

    DBConnection dbcon = new DBConnection();

    StockInForm stockInForm = new StockInForm();

    public SearchProductsStockInForm(StockInForm stockInForm)
    {
        InitializeComponent();

        this.stockInForm = stockInForm;

        cn = new SqlConnection(dbcon.MyConnection());
        LoadProducts();
    }

    public void LoadProducts()
    {
        int i = 0;
        dataGridViewProducts.Rows.Clear();
        cn.Open();
        cm = new SqlCommand("SELECT pcode, [description], quantity FROM Product WHERE [description] LIKE '%" + searchTextBox.Text + "%' ORDER BY [description]", cn);
        dr = cm.ExecuteReader();

        while (dr.Read())
        {
            i++;
            dataGridViewProducts.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
        }

        dr.Close();
        cn.Close();
    }

    private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridViewProducts.Columns[e.ColumnIndex].Name == "selectColumn")
        {
            if (stockInForm.referenceNumberTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter reference number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stockInForm.referenceNumberTextBox.Focus();
                return;
            }

            if (stockInForm.stockInByTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter Stock In By!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stockInForm.stockInByTextBox.Focus();
                return;
            }

            if (MessageBox.Show("Add this Item?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO StockIn(referenceNo, pcode, quantity,stockInDate, stockInBy) VALUES (@referenceNo, @pcode, @quantity, @stockInDate, @stockInBy)", cn);
                cm.Parameters.AddWithValue("@referenceNo", stockInForm.referenceNumberTextBox.Text);
                cm.Parameters.AddWithValue("@pcode", dataGridViewProducts.Rows[e.RowIndex].Cells[1].Value.ToString());
                cm.Parameters.AddWithValue("@quantity", quantityNumericUpDown.Value);
                cm.Parameters.AddWithValue("@stockInDate", stockInForm.stockIndateTimePicker.Value);
                cm.Parameters.AddWithValue("@stockInBy", stockInForm.stockInByTextBox.Text);

                cm.ExecuteNonQuery();

                cn.Close();

                MessageBox.Show("Successfully Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stockInForm.LoadStockIn();
            }
        }
    }

    private void dataGridViewProducts_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.S)
        {
            dataGridViewProducts_CellContentClick(sender, new DataGridViewCellEventArgs(4, dataGridViewProducts.CurrentRow.Index));
        }
    }

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        LoadProducts();
    }
}
