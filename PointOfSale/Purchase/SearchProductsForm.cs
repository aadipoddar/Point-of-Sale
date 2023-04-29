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
                    }

                    else // For Purchase Form
                    {
                        AddNewProductToPurchase(rowIndex);
                    }
                }
            }
        }

        private void UpdateQuantityOfExistingProductInSale(int rowIndex, int i)
        {
            // Check if the quantity is available
            if ((Convert.ToInt32(saleForm.dataGridViewCart.Rows[i].Cells[2].Value) + Convert.ToInt32(quantityNumericUpDown.Value)) <= Convert.ToInt32(dataGridViewProducts.Rows[rowIndex].Cells[5].Value))
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
                saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[6].Value = 0;
                saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[7].Value = 0;
                saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[8].Value = dataGridViewProducts.Rows[rowIndex].Cells[5].Value;
                saleForm.dataGridViewCart.Rows[saleRowIndex].Cells[9].Value = Convert.ToDecimal(dataGridViewProducts.Rows[rowIndex].Cells[4].Value);

                saleForm.UpdateTotal();
            }

            else
            {
                MessageBox.Show("Product No more available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddNewProductToPurchase(int rowIndex)
        {
            purchaseForm.dataGridViewPurchase.Rows.Add();
            int purchaseRowIndex = purchaseForm.dataGridViewPurchase.RowCount - 1;
            purchaseForm.dataGridViewPurchase.Rows[purchaseRowIndex].Cells[0].Value = dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString();
            purchaseForm.dataGridViewPurchase.Rows[purchaseRowIndex].Cells[1].Value = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
            purchaseForm.dataGridViewPurchase.Rows[purchaseRowIndex].Cells[2].Value = quantityNumericUpDown.Value;
        }
    }
}
