namespace WinForms.PointOfSale.Sale;

public partial class SettlePaymentForm : Form
{
    SaleData saleData = new();

    SaleModel saleModel = new();
    SaleDetailModel saleDetailModel = new();
    InventoryModel inventoryModel = new();

    SaleForm saleForm;

    public SettlePaymentForm(SaleForm saleForm)
    {
        InitializeComponent();

        this.saleForm = saleForm;

        Task task = GetTransactionNoAsync(saleForm.saleDateTimePicker.Value.ToString("yyyyMMdd"));
    }

    private async Task GetTransactionNoAsync(string saleDate)
    {
        string transactionNo = await saleData.GetTransactionNo(saleDate);

        if (transactionNo is not null)
        {
            if (transactionNo is not null)
            {
                string i = transactionNo.Substring(8, 4);
                transactionNoTextBox.Text = saleDate + (int.Parse(i) + 1);
            }
        }


        else
            transactionNoTextBox.Text = saleDate + "1001";
    }

    private void cashNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        changeTextBox.Text = (cashNumericUpDown.Value - Convert.ToDecimal(totalTextBox.Text)).ToString();
    }

    private async void payButton_Click(object sender, EventArgs e)
    {
        #region Sale Master Table

        saleModel = new SaleModel
        {
            SaleId = 0,
            TransactionNo = transactionNoTextBox.Text,
            SaleDate = saleForm.saleDateTimePicker.Value,
            SubTotal = Convert.ToDecimal(saleForm.subTotalBeforeDiscountTextBox.Text),
            Discount = Convert.ToDecimal(saleForm.finalDiscountTextBox.Text),
            Tax = Convert.ToDecimal(saleForm.totalTaxTextBox.Text),
            Total = Convert.ToDecimal(saleForm.totalTextBox.Text),
            CashGiven = cashNumericUpDown.Value,
            Change = Convert.ToDecimal(changeTextBox.Text)
        };

        await saleData.InsertSale(saleModel);

        #endregion

        int saleId = await saleData.GetSaleId(transactionNoTextBox.Text);

        #region Sale Detail Table

        for (int i = 0; i < saleForm.dataGridViewCart.RowCount; i++)
        {
            saleDetailModel = new SaleDetailModel
            {
                SaleDetailId = 0,
                SaleId = saleId,
                ProductId = Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[0].Value),
                Quantity = Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[2].Value),
                Prize = Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[3].Value),
                DiscountAmount = Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[4].Value),
                DiscountPercent = Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[5].Value),
                TaxPercent = Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[6].Value),
                TaxAmount = Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[7].Value),
                FinalPrize = Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[8].Value)
            };

            await saleData.InsertSaleDetail(saleDetailModel);
        }

        #endregion

        #region Inventory Table

        for (int i = 0; i < saleForm.dataGridViewCart.RowCount; i++)
        {
            inventoryModel = new InventoryModel
            {
                InventoryId = 0,
                ProductId = Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[0].Value),
                Quantity = -Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[2].Value),
                BillNo = transactionNoTextBox.Text,
                Prize = Convert.ToDecimal(saleForm.dataGridViewCart.Rows[i].Cells[8].Value)
            };

            await saleData.InsertInventory(inventoryModel);
        }

        #endregion

        Close();
        saleForm.Close();
    }
}
