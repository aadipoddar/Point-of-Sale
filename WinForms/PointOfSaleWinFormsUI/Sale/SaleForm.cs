using System.Data.SqlClient;

using WinForms.PointOfSale.Purchase;

namespace WinForms.PointOfSale.Sale;

public partial class SaleForm : Form
{
    SqlConnection sqlConnection = new SqlConnection();
    SqlCommand sqlCommand = new SqlCommand();
    SqlDataReader sqlDataReader;

    DBConnection dbConnection = new DBConnection();

    public SaleForm()
    {
        InitializeComponent();

        sqlConnection = new SqlConnection(dbConnection.MyConnection());
        saleDateTimePicker.Value = DateTime.Now;
        GetTransactionNo();

        searchProductsButton.Focus();
    }

    private void GetTransactionNo()
    {
        try
        {
            string saleDate = saleDateTimePicker.Value.ToString("yyyyMMdd");
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

    private void searchProductsButton_Click(object sender, EventArgs e)
    {
        SearchProductsForm searchProductsForm = new SearchProductsForm(this);
        searchProductsForm.Show();
    }


    private void dataGridViewCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        double price = Convert.ToDouble(dataGridViewCart.Rows[e.RowIndex].Cells[3].Value);
        double discountAmount = Convert.ToDouble(dataGridViewCart.Rows[e.RowIndex].Cells[4].Value);
        double discountPercent = Convert.ToDouble(dataGridViewCart.Rows[e.RowIndex].Cells[5].Value);

        switch (e.ColumnIndex)
        {
            case 4:
                dataGridViewCart.Rows[e.RowIndex].Cells[5].Value = discountAmount / price * 100;
                break;
            case 5:
                dataGridViewCart.Rows[e.RowIndex].Cells[4].Value = discountPercent / 100 * price;
                break;
        }

        UpdateTotal();
    }

    private void AssigningValues()
    {
        for (int i = 0; i < dataGridViewCart.RowCount; i++)
        {
            #region Quantity Assignment

            int quantity = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[2].Value);
            int quantityInStock = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[9].Value);

            if (quantity <= 0)
            {
                dataGridViewCart.Rows.RemoveAt(i);
            }

            else if (quantity > quantityInStock)
            {
                MessageBox.Show("Quantity is greater than the quantity in stock. Setting it to Maximum!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridViewCart.Rows[i].Cells[2].Value = quantityInStock;
            }

            #endregion

            #region Price Assignment

            dataGridViewCart.Rows[i].Cells[3].Value = Convert.ToInt64(dataGridViewCart.Rows[i].Cells[2].Value) *
                Convert.ToDouble(dataGridViewCart.Rows[i].Cells[10].Value);

            #endregion

            #region Discount Assignment

            double price = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[3].Value);
            double discountAmount = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[4].Value);
            double discountPercent = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[5].Value);

            if ((discountAmount < 0) || (discountPercent < 0))
            {
                MessageBox.Show("Please enter a positive value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewCart.Rows[i].Cells[4].Value = 0;
                dataGridViewCart.Rows[i].Cells[5].Value = 0;
            }

            else if (discountAmount > price)
            {
                MessageBox.Show("Discount Amount cannot be greater than the price. Setting to Maximum", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridViewCart.Rows[i].Cells[4].Value = price;
                dataGridViewCart.Rows[i].Cells[5].Value = 100;
            }

            else if (discountPercent > 100)
            {
                MessageBox.Show("Discount Percent cannot be greater than 100. Setting to Maximum!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridViewCart.Rows[i].Cells[4].Value = price;
                dataGridViewCart.Rows[i].Cells[5].Value = 100;
            }

            discountAmount = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[4].Value);
            discountPercent = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[5].Value);

            if (price - (discountPercent / 100 * price) != (price - discountAmount))
            {
                MessageBox.Show("Some Problem in Discount calculation. Setting discount to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewCart.Rows[i].Cells[4].Value = 0;
                dataGridViewCart.Rows[i].Cells[5].Value = 0;
            }

            discountAmount = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[4].Value);

            double subTotalAfterDiscount = price - discountAmount;

            #endregion

            #region Tax Assignment

            double taxPercent = Convert.ToDouble(dataGridViewCart.Rows[i].Cells[6].Value);
            double taxAmount = subTotalAfterDiscount * taxPercent / 100;

            dataGridViewCart.Rows[i].Cells[7].Value = taxAmount;

            #endregion

            #region Total Assignment

            double total = subTotalAfterDiscount + taxAmount;
            dataGridViewCart.Rows[i].Cells[8].Value = total;

            #endregion
        }
    }

    public void UpdateTotal()
    {
        AssigningValues();

        double subTotalBeforeDiscount = 0;
        double discount = 0;
        double tax = 0;
        double finalPrize = 0;

        for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
        {
            subTotalBeforeDiscount += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[3].Value);
            discount += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[4].Value);
            tax += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[7].Value);
            finalPrize += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[8].Value);
        }

        subTotalBeforeDiscountTextBox.Text = subTotalBeforeDiscount.ToString("#,##0.00");

        finalDiscountTextBox.Text = discount.ToString("#,##0.00");

        subTotalAfterDiscountTextBox.Text = (subTotalBeforeDiscount - discount).ToString("#,##0.00");

        totalTaxTextBox.Text = tax.ToString("#,##0.00");

        if (finalPrize - (subTotalBeforeDiscount - discount + tax) <= 1)
        {
            totalTextBox.Text = finalPrize.ToString("#,##0.00");
        }

        else
        {
            MessageBox.Show("Some problem in total calculation. Please Retry the Bill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void paymentButton_Click(object sender, EventArgs e)
    {
        if (dataGridViewCart.Rows.Count == 0)
        {
            MessageBox.Show("Please add some items to the cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        else
        {
            SettlePaymentForm settlePaymentForm = new SettlePaymentForm(this);

            settlePaymentForm.totalTextBox.Text = totalTextBox.Text;
            settlePaymentForm.cashNumericUpDown.Minimum = Convert.ToDecimal(settlePaymentForm.totalTextBox.Text);
            settlePaymentForm.cashNumericUpDown.Maximum = Convert.ToDecimal(settlePaymentForm.totalTextBox.Text) + 1000;

            settlePaymentForm.ShowDialog();
        }
    }
}
