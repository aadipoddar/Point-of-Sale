using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PointOfSale.Cashier;

namespace PointOfSale.Purchase
{
    public partial class SearchProductsForm : Form
    {
        PurchaseForm purchaseForm;
        SaleForm saleForm;
        bool isSaleForm = false;

        public SearchProductsForm(PurchaseForm purchaseForm)
        {
            InitializeComponent();

            this.purchaseForm = purchaseForm;

            isSaleForm = false;
        }

        public SearchProductsForm(SaleForm saleForm)
        {
            InitializeComponent();

            this.saleForm = saleForm;

            isSaleForm = true;
        }

        private void SearchProductsForm_Load(object sender, EventArgs e)
        {
            this.vwShowProductsTableAdapter.Fill(this.pointOfSaleDataSet.vwShowProducts);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewProducts.DataSource as BindingSource).Filter = string.Format("{0} LIKE '%{1}%'", dataGridViewProducts.Columns[1].DataPropertyName, searchTextBox.Text);
        }

        private void dataGridViewProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridViewProducts.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewProducts.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewProducts.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        if (isSaleForm)
                        {
                            saleForm.dataGridViewCart.Rows.Add();
                            int saleRowIndex = saleForm.dataGridViewCart.Rows.Count - 1;
                            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[0].Value = dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString();
                            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[1].Value = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
                            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[2].Value = quantityNumericUpDown.Value;
                            saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[3].Value = 0;
                        }

                        else
                        {
                            purchaseForm.dataGridViewPurchase.Rows.Add();
                            int purchaseRowIndex = purchaseForm.dataGridViewPurchase.Rows.Count - 1;
                            purchaseForm.dataGridViewPurchase.Rows[purchaseRowIndex].Cells[0].Value = dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString();
                            purchaseForm.dataGridViewPurchase.Rows[purchaseRowIndex].Cells[1].Value = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
                            purchaseForm.dataGridViewPurchase.Rows[purchaseRowIndex].Cells[2].Value = quantityNumericUpDown.Value;
                        }
                    }
                }
            }
        }
    }
}
