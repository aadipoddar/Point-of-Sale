using System;
using System.Windows.Forms;

namespace WinForms.PointOfSale.Purchase
{
    public partial class PurchaseHistoryForm : Form
    {
        public PurchaseHistoryForm()
        {
            InitializeComponent();
        }

        private void PurchaseHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointOfSaleDataSet.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.pointOfSaleDataSet.Purchase);
        }

        private void loadRecordsButton_Click(object sender, EventArgs e)
        {
            var startDate = startDateTimePicker.Value.Date;
            var endDate = endDateTimePicker.Value.Date.AddDays(1);

            string filterExpression = string.Format("{0} >= #{1}# AND {0} <= #{2}#", dataGridViewPurchase.Columns[3].DataPropertyName, startDate.ToString("MM/dd/yyyy"), endDate.ToString("MM/dd/yyyy"));

            (dataGridViewPurchase.DataSource as BindingSource).Filter = filterExpression;
        }

        private void dataGridViewPurchase_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
