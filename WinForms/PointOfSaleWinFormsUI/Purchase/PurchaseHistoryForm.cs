namespace WinForms.PointOfSale.Purchase;

public partial class PurchaseHistoryForm : Form
{
    PurchaseData purchaseData = new();
    List<ShowPurchaseModel> purchases = new();

    public PurchaseHistoryForm()
    {
        InitializeComponent();
        Task task = LoadPurchase();
    }

    public async Task LoadPurchase()
    {
        purchases = (await purchaseData.GetPurchase()).ToList();
        dataGridViewPurchase.DataSource = new BindingSource(purchases, null);

        dataGridViewPurchase.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private async void loadRecordsButton_Click(object sender, EventArgs e)
    {
        var startDate = startDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
        var endDate = endDateTimePicker.Value.Date.AddDays(1).ToString("yyyy-MM-dd");

        purchases = (await purchaseData.GetPurchaseByDate(startDate, endDate)).ToList();
        dataGridViewPurchase.DataSource = new BindingSource(purchases, null);

        dataGridViewPurchase.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
}
