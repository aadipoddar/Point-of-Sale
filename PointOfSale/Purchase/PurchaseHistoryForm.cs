using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Purchase
{
    public partial class PurchaseHistoryForm : Form
    {
        public PurchaseHistoryForm()
        {
            InitializeComponent();
        }

        private void PurchaseHistoryForm_Load(object sender, EventArgs e)
        {
            this.vwPurchaseTableAdapter.Fill(this.pointOfSaleDataSet.vwPurchase);
        }

        private void loadRecordsButton_Click(object sender, EventArgs e)
        {
            var startDate = startDateTimePicker.Value.Date;
            var endDate = endDateTimePicker.Value.Date.AddDays(1);

            string filterExpression = string.Format("{0} >= #{1}# AND {0} <= #{2}#", dataGridViewPurchase.Columns[4].DataPropertyName, startDate.ToString("MM/dd/yyyy"), endDate.ToString("MM/dd/yyyy"));

            (dataGridViewPurchase.DataSource as BindingSource).Filter = filterExpression;
        }

        private void dataGridViewPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }

            if (e.KeyCode == Keys.Delete)
            {

            }
        }
    }
}
