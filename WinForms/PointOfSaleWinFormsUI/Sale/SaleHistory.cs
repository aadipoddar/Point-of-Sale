namespace WinForms.PointOfSale.Sale;

public partial class SaleHistory : Form
{
    public SaleHistory()
    {
        InitializeComponent();
    }

    private void SaleHistory_Load(object sender, EventArgs e)
    {
        // TODO: This line of code loads data into the 'pointOfSaleDataSet.Sale' table. You can move, or remove it, as needed.
        this.saleTableAdapter.Fill(this.pointOfSaleDataSet.Sale);
    }

    private void loadRecordsButton_Click(object sender, EventArgs e)
    {
        var startDate = startDateTimePicker.Value.Date;
        var endDate = endDateTimePicker.Value.Date.AddDays(1);

        string filterExpression = string.Format("{0} >= #{1}# AND {0} <= #{2}#", dataGridViewSale.Columns[2].DataPropertyName, startDate.ToString("MM/dd/yyyy"), endDate.ToString("MM/dd/yyyy"));

        (dataGridViewSale.DataSource as BindingSource).Filter = filterExpression;
    }
}
