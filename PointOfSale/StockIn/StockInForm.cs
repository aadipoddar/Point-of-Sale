using System.Globalization;

using Microsoft.Data.SqlClient;

namespace PointOfSale.StockIn;

public partial class StockInForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;

    DBConnection dbcon = new DBConnection();

    int rowIndex;

    public StockInForm()
    {
        InitializeComponent();

        cn = new SqlConnection(dbcon.MyConnection());
        LoadStockIn();
    }

    public void LoadStockIn()
    {
        int i = 0;

        dataGridViewStockIn.Rows.Clear();

        cn.Open();
        cm = new SqlCommand("SELECT * FROM vwStockIn WHERE referenceNo = '" + referenceNumberTextBox.Text + "' AND status LIKE 'Pending'", cn);
        dr = cm.ExecuteReader();

        while (dr.Read())
        {
            i++;
            dataGridViewStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
        }

        dr.Close();
        cn.Close();
    }

    public void LoadStockInHistory()
    {
        int i = 0;

        stockInHistoryDataGridView.Rows.Clear();

        DateTime dt = DateTime.ParseExact(startDateTimePicker.Value.ToShortDateString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        string startDate = dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

        cn.Open();
        cm = new SqlCommand("SELECT * FROM vwStockIn WHERE cast(stockInDate as date) LIKE '" + startDate + "' AND status LIKE 'Done'", cn);
        dr = cm.ExecuteReader();

        while (dr.Read())
        {
            i++;
            stockInHistoryDataGridView.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
        }

        dr.Close();
        cn.Close();
    }

    public void Clear()
    {
        referenceNumberTextBox.Clear();
        stockInByTextBox.Clear();
        stockIndateTimePicker.Value = DateTime.Now;
        dataGridViewStockIn.Rows.Clear();
    }

    private void dataGridViewStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridViewStockIn.Columns[e.ColumnIndex].Name == "deleteColumn")
        {
            if (MessageBox.Show("Remove this Item?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("DELETE from StockIn WHERE id = '" + dataGridViewStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Successfully Removed!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStockIn();
            }
        }
    }

    private void dataGridViewStockIn_KeyDown(object sender, KeyEventArgs e)
    {
        if ((e.KeyCode == Keys.D) || (e.KeyCode == Keys.Delete))
        {
            dataGridViewStockIn_CellContentClick(sender, new DataGridViewCellEventArgs(8, dataGridViewStockIn.CurrentRow.Index));
        }
    }

    private void searchProductsButton_Click(object sender, EventArgs e)
    {
        SearchProductsStockInForm frm = new SearchProductsStockInForm(this);
        frm.Show();
        frm.searchTextBox.Focus();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridViewStockIn.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to save these Records?", "Save Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewStockIn.Rows.Count; i++)
                    {
                        // Update Product Quantity
                        cn.Open();
                        cm = new SqlCommand("UPDATE Product SET quantity = quantity + " + int.Parse(dataGridViewStockIn.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE '" + dataGridViewStockIn.Rows[i].Cells[3].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        // Update Stock In Quantity
                        cn.Open();
                        cm = new SqlCommand("UPDATE StockIn SET quantity = " + int.Parse(dataGridViewStockIn.Rows[i].Cells[5].Value.ToString()) + "" +
                            ", status = 'Done' WHERE id = '" + dataGridViewStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                }

                Clear();
                LoadStockIn();
            }
        }
        catch (Exception ex)
        {
            cn.Close();
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void loadRecordsButton_Click(object sender, EventArgs e)
    {
        LoadStockInHistory();
    }
}
