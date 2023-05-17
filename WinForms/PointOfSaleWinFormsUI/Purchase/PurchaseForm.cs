namespace WinForms.PointOfSale.Purchase;

public partial class PurchaseForm : Form
{
    PurchaseData purchaseData = new();

    PurchaseModel purchaseModel = new();
    PurchaseDetailModel purchaseDetailModel = new();
    InventoryModel inventoryModel = new();

    public PurchaseForm()
    {
        InitializeComponent();

        purchaseDateTimePicker.Value = DateTime.Now;
    }


    private async void purchaseDateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        transactionNoTextBox.Text = "";

        await GetTransactionNoAsync(purchaseDateTimePicker.Value.ToString("yyyyMMdd"));
    }

    private async Task GetTransactionNoAsync(string saleDate)
    {
        string transactionNo = await purchaseData.GetTransactionNo(purchaseDateTimePicker.Value.ToString("yyyyMMdd"));

        if (transactionNo is not null)
        {
            if (transactionNo is not null)
            {
                string i = transactionNo.Substring(9);
                int count = int.Parse(i);
                transactionNoTextBox.Text = transactionNo.Substring(0, 9) + (count + 1);
            }
        }

        else
            transactionNoTextBox.Text = "P" + saleDate + "1001";
    }


    private void searchProductsButton_Click(object sender, EventArgs e)
    {
        SearchProductsForm searchProductsForm = new(this);
        searchProductsForm.Show();
    }


    private void dataGridViewCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        switch (e.ColumnIndex)
        {
            case 4:
                dataGridViewCart.CurrentRow.Cells[3].Value = Convert.ToDecimal(dataGridViewCart.CurrentRow.Cells[4].Value) / Convert.ToDecimal(dataGridViewCart.CurrentRow.Cells[2].Value);
                UpdateTotal();
                break;
        }
        UpdateTotal();
    }

    public void UpdateTotal()
    {
        double subTotal = 0;
        double tax = 0;
        double finalPrize = 0;

        for (int i = 0; i < dataGridViewCart.RowCount; i++)
        {
            dataGridViewCart.Rows[i].Cells[4].Value =
                Convert.ToDouble(dataGridViewCart.Rows[i].Cells[2].Value)
                    * Convert.ToDouble(dataGridViewCart.Rows[i].Cells[3].Value);

            dataGridViewCart.Rows[i].Cells[6].Value =
                Convert.ToDouble(dataGridViewCart.Rows[i].Cells[5].Value) / 100
                    * Convert.ToDouble(dataGridViewCart.Rows[i].Cells[4].Value);

            dataGridViewCart.Rows[i].Cells[7].Value =
                Convert.ToDouble(dataGridViewCart.Rows[i].Cells[4].Value)
                    + Convert.ToDouble(dataGridViewCart.Rows[i].Cells[6].Value);

            subTotal += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[4].Value);
            tax += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[6].Value);
            finalPrize += Convert.ToDouble(dataGridViewCart.Rows[i].Cells[7].Value);
        }

        if (subTotal + tax - finalPrize <= 1)
        {
            subTotalTextBox.Text = subTotal.ToString("#,##0.00");
            totalTaxTextBox.Text = tax.ToString("#,##0.00");
            totalTextBox.Text = finalPrize.ToString("#,##0.00");
        }

        else
        {
            MessageBox.Show("Error in Calculation! Retry Purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    private void dataGridViewPurchase_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            int rowIndex = dataGridViewCart.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewCart.Rows.Count)
            {
                DataGridViewCell cell = dataGridViewCart.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    dataGridViewCart.Rows.RemoveAt(rowIndex);
                    UpdateTotal();
                }
            }
        }
    }


    private async void saveButton_Click(object sender, EventArgs e)
    {
        if (dataGridViewCart.Rows.Count > 0)
        {
            if (purchaseByTextBox.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to save these Records?", "Save Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Purchase Table
                    purchaseModel = new PurchaseModel
                    {
                        PurchaseId = 0,
                        TransactionNo = transactionNoTextBox.Text,
                        PurchaseBy = purchaseByTextBox.Text,
                        PurchaseDate = purchaseDateTimePicker.Value,
                        SubTotal = Convert.ToDecimal(subTotalTextBox.Text),
                        Tax = Convert.ToDecimal(totalTaxTextBox.Text),
                        Total = Convert.ToDecimal(totalTextBox.Text)
                    };

                    await purchaseData.InsertPurchase(purchaseModel);


                    int purchaseId = await purchaseData.GetPurchaseId(transactionNoTextBox.Text);


                    // Purchase Detail Table
                    for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
                    {
                        purchaseDetailModel = new PurchaseDetailModel
                        {
                            PurchaseDetailId = 0,
                            PurchaseId = purchaseId,
                            ProductId = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[0].Value),
                            Quantity = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[2].Value),
                            PrizePerQuantity = Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[3].Value),
                            SubTotal = Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[4].Value),
                            Tax = Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[6].Value),
                            Total = Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[7].Value)
                        };

                        await purchaseData.InsertPurchaseDetail(purchaseDetailModel);
                    }


                    // Inventory Table
                    for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
                    {
                        inventoryModel = new InventoryModel
                        {
                            InventoryId = 0,
                            ProductId = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[0].Value),
                            Quantity = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[2].Value),
                            BillNo = transactionNoTextBox.Text,
                            Prize = Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[7].Value)
                        };

                        await purchaseData.InsertInventory(inventoryModel);
                    }

                    TextBoxClear();
                }
            }

            else
            {
                MessageBox.Show("Please enter the name of the person who is purchasing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        else
        {
            MessageBox.Show("Please add some products to cart!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void TextBoxClear()
    {
        dataGridViewCart.Rows.Clear();
        transactionNoTextBox.Clear();
        purchaseDateTimePicker.Value = DateTime.Now;
        purchaseByTextBox.Clear();
        subTotalTextBox.Clear();
        totalTaxTextBox.Clear();
        totalTextBox.Clear();
    }
}
