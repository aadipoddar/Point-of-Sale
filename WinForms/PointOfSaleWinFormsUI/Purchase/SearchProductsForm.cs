using WinForms.PointOfSale.Sale;

namespace WinForms.PointOfSale.Purchase;

public partial class SearchProductsForm : Form
{
    ProductData productData = new();
    List<ShowProductModel> products = new();

    PurchaseForm purchaseForm;
    SaleForm saleForm;
    bool isSaleForm = false;

    public SearchProductsForm(PurchaseForm purchaseForm)
    {
        InitializeComponent();

        this.purchaseForm = purchaseForm;
        isSaleForm = false;

        Task task = DataGridRefresh();
    }

    public SearchProductsForm(SaleForm saleForm)
    {
        InitializeComponent();

        this.saleForm = saleForm;
        isSaleForm = true;

        Task task = DataGridRefresh();
    }

    public async Task DataGridRefresh(string searchText = "")
    {
        products = (await productData.GetProductsBySearch(searchText)).ToList();
        dataGridViewProducts.DataSource = new BindingSource(products, null);

        dataGridViewProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private async void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        await DataGridRefresh(searchTextBox.Text);
    }

    private void dataGridViewProducts_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            int rowIndex = dataGridViewProducts.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewProducts.RowCount)
            {
                DataGridViewCell cell = dataGridViewProducts.Rows[rowIndex].Cells[1];
                if (cell != null && cell.Value != null)
                {
                    if (isSaleForm) // For Sale Form
                    {
                        if (saleForm.dataGridViewCart.RowCount > 0)
                        {
                            for (int i = 0; i < saleForm.dataGridViewCart.RowCount; i++)
                            {
                                // Check if the product is already in the cart
                                if (Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[0].Value) == Convert.ToInt32(dataGridViewProducts.Rows[rowIndex].Cells[0].Value))
                                {
                                    UpdateQuantityOfExistingProductInSale(rowIndex, i);
                                    return;
                                }
                            }
                        }

                        AddNewProductToSale(rowIndex);
                    }

                    else // For Purchase Form
                    {
                        AddNewProductToPurchase(rowIndex);
                    }
                }
            }
        }
    }

    private void UpdateQuantityOfExistingProductInSale(int rowIndex, int i)
    {
        // Check if the quantity is available
        if ((Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[2].Value)
            + Convert.ToInt32(quantityNumericUpDown.Value))
            <= Convert.ToInt32(dataGridViewProducts.Rows[rowIndex].Cells[5].Value))
        {
            saleForm.dataGridViewCart.Rows[i].Cells[2].Value = Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[2].Value) + Convert.ToInt32(quantityNumericUpDown.Value);
            saleForm.UpdateTotal();
            return;
        }

        else
        {
            MessageBox.Show("Product No more available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void AddNewProductToSale(int rowIndex)
    {
        // Check if the quantity is available
        if (Convert.ToInt32(quantityNumericUpDown.Value) <= Convert.ToInt32(dataGridViewProducts.Rows[rowIndex].Cells[5].Value))
        {
            saleForm.dataGridViewCart.Rows.Add();
            int saleRowIndex = saleForm.dataGridViewCart.RowCount - 1;
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[0].Value = dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString();
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[1].Value = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[2].Value = Convert.ToInt32(quantityNumericUpDown.Value);
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[3].Value = 0;
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[4].Value = 0;
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[5].Value = 0;
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[6].Value = dataGridViewProducts.Rows[rowIndex].Cells[6].Value;
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[7].Value = 0;
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[8].Value = 0;
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[9].Value = dataGridViewProducts.Rows[rowIndex].Cells[5].Value;
            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[10].Value = Convert.ToDecimal(dataGridViewProducts.Rows[rowIndex].Cells[4].Value);

            saleForm.UpdateTotal();
        }

        else
        {
            MessageBox.Show("Product No more available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void AddNewProductToPurchase(int rowIndex)
    {
        purchaseForm.dataGridViewCart.Rows.Add();
        int purchaseRowIndex = purchaseForm.dataGridViewCart.RowCount - 1;
        purchaseForm.dataGridViewCart.Rows[purchaseRowIndex].Cells[0].Value = dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString();
        purchaseForm.dataGridViewCart.Rows[purchaseRowIndex].Cells[1].Value = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
        purchaseForm.dataGridViewCart.Rows[purchaseRowIndex].Cells[2].Value = quantityNumericUpDown.Value;
        purchaseForm.dataGridViewCart.Rows[purchaseRowIndex].Cells[3].Value = dataGridViewProducts.Rows[rowIndex].Cells[4].Value.ToString();
        purchaseForm.dataGridViewCart.Rows[purchaseRowIndex].Cells[4].Value = 0;
        purchaseForm.dataGridViewCart.Rows[purchaseRowIndex].Cells[5].Value = dataGridViewProducts.Rows[rowIndex].Cells[6].Value.ToString();
        purchaseForm.dataGridViewCart.Rows[purchaseRowIndex].Cells[6].Value = 0;
        purchaseForm.dataGridViewCart.Rows[purchaseRowIndex].Cells[7].Value = 0;

        purchaseForm.UpdateTotal();
    }
}
