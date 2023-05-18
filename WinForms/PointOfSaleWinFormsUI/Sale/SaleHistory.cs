namespace WinForms.PointOfSale.Sale;

public partial class SaleHistory : Form
{
    SaleData saleData = new();
    List<ShowSaleModel> sales = new();

    public SaleHistory()
    {
        InitializeComponent();

        Task task = LoadSale();
    }

    private async Task LoadSale()
    {
        sales = (await saleData.GetSale()).ToList();

        dataGridViewSale.DataSource = new BindingSource(sales, null);
        dataGridViewSale.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private async void loadRecordsButton_Click(object sender, EventArgs e)
    {
        var startDate = startDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
        var endDate = endDateTimePicker.Value.Date.AddDays(1).ToString("yyyy-MM-dd");

        sales = (await saleData.GetSaleByDate(startDate, endDate)).ToList();

        dataGridViewSale.DataSource = new BindingSource(sales, null);
        dataGridViewSale.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
}
