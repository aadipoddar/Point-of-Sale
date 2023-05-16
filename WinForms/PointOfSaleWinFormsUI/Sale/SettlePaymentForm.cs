using System.Data.SqlClient;


namespace WinForms.PointOfSale.Sale;

public partial class SettlePaymentForm : Form
{
    SqlConnection sqlConnection = new();
    SqlCommand sqlCommand = new();
    DBConnection dbcon = new();
    SqlDataReader sqlDataReader;

    SaleForm saleForm;

    public SettlePaymentForm(SaleForm saleForm)
    {
        InitializeComponent();

        sqlConnection = new SqlConnection(dbcon.MyConnection());
        this.saleForm = saleForm;

        GetTransactionNo();
    }

    private void GetTransactionNo()
    {
        try
        {
            string saleDate = saleForm.saleDateTimePicker.Value.ToString("yyyyMMdd");
            string transactionNo = "";
            int count;
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT TOP 1 transactionNo FROM Sale WHERE transactionNo LIKE '" + saleDate + "%' ORDER BY id DESC", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();

            if (sqlDataReader.HasRows)
            {
                transactionNo = sqlDataReader[0].ToString();
                string i = transactionNo.Substring(8, 4);
                count = int.Parse(i);
                transactionNoTextBox.Text = saleDate + (count + 1);
            }

            else
            {
                transactionNo = saleDate + "1001";
                transactionNoTextBox.Text = transactionNo;
            }

            sqlDataReader.Close();
            sqlConnection.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            throw;
        }
    }

    private void cashNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        changeTextBox.Text = (cashNumericUpDown.Value - Convert.ToDecimal(totalTextBox.Text)).ToString();
    }

    private int GetSaleId()
    {
        int saleId = 1;

        sqlConnection.Open();
        sqlCommand = new SqlCommand("SELECT MAX(id) FROM Sale", sqlConnection);
        sqlDataReader = sqlCommand.ExecuteReader();

        if (sqlDataReader.Read())
        {
            if (sqlDataReader.IsDBNull(0))
            {
                MessageBox.Show("No Sale Record Found! Please retry Bill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saleId = sqlDataReader.GetInt32(0);
            }
        }

        sqlConnection.Close();

        return saleId;
    }

    private void payButton_Click(object sender, EventArgs e)
    {
        try
        {
            #region Sale Master Table

            sqlConnection.Open();
            sqlCommand = new SqlCommand("INSERT INTO Sale (transactionNo, saleDate, subTotal, discount, tax, total, cashGiven, change) VALUES" +
                " (@transactionNo, @saleDate, @subTotal, @discount, @tax, @total, @cashGiven, @change)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@transactionNo", transactionNoTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@saleDate", saleForm.saleDateTimePicker.Value);
            sqlCommand.Parameters.AddWithValue("@subTotal", Convert.ToDecimal(saleForm.subTotalBeforeDiscountTextBox.Text));
            sqlCommand.Parameters.AddWithValue("@discount", Convert.ToDecimal(saleForm.finalDiscountTextBox.Text));
            sqlCommand.Parameters.AddWithValue("@tax", Convert.ToDecimal(saleForm.totalTaxTextBox.Text));
            sqlCommand.Parameters.AddWithValue("@total", Convert.ToDecimal(saleForm.totalTextBox.Text));
            sqlCommand.Parameters.AddWithValue("@cashGiven", Convert.ToDecimal(cashNumericUpDown.Value));
            sqlCommand.Parameters.AddWithValue("@change", Convert.ToDecimal(changeTextBox.Text));

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            #endregion

            int saleId = GetSaleId();

            #region Sale Detail Table

            sqlConnection.Open();
            for (int i = 0; i < saleForm.dataGridViewCart.RowCount; i++)
            {
                sqlCommand = new SqlCommand("INSERT INTO SaleDetail (saleId, productId, quantity, price, discountAmount, discountPercent, taxPercent, taxAmount, finalPrize) VALUES" +
                                           " (@saleId, @productId, @quantity, @price, @discountAmount, @discountPercent, @taxPercent, @taxAmount, @finalPrize)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@saleId", saleId);
                sqlCommand.Parameters.AddWithValue("@productId", Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[0].Value));
                sqlCommand.Parameters.AddWithValue("@quantity", Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[2].Value));
                sqlCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[3].Value));
                sqlCommand.Parameters.AddWithValue("@discountAmount", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[4].Value));
                sqlCommand.Parameters.AddWithValue("@discountPercent", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[5].Value));
                sqlCommand.Parameters.AddWithValue("@taxPercent", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[6].Value));
                sqlCommand.Parameters.AddWithValue("@taxAmount", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[7].Value));
                sqlCommand.Parameters.AddWithValue("@finalPrize", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[8].Value));

                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();

            #endregion

            #region Inventory Table

            sqlConnection.Open();
            for (int i = 0; i < saleForm.dataGridViewCart.RowCount; i++)
            {
                sqlCommand = new SqlCommand("INSERT INTO Inventory(productId, quantity, billNo, price) VALUES" +
                               " (@productId, @quantity, @billNo, @price)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@productId", Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[0].Value));
                sqlCommand.Parameters.AddWithValue("@quantity", -Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[2].Value));
                sqlCommand.Parameters.AddWithValue("@billNo", transactionNoTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[8].Value));

                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();

            #endregion

            Close();
            saleForm.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
