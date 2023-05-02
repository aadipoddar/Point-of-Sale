using System;
using System.Windows.Forms;

using WinForms.PointOfSale.Brands;
using WinForms.PointOfSale.Categories;
using WinForms.PointOfSale.Products;
using WinForms.PointOfSale.Purchase;
using WinForms.PointOfSale.Sale;

namespace WinForms.PointOfSale
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void manageProductsButton_Click(object sender, EventArgs e)
        {
            ProductsListForm productsListForm = new ProductsListForm();
            productsListForm.Show();
        }

        private void manageCategoriesButton_Click(object sender, EventArgs e)
        {
            CategoriesListForm categoriesListForm = new CategoriesListForm();
            categoriesListForm.Show();
        }

        private void manageBrandButton_Click(object sender, EventArgs e)
        {
            BrandsListForm brandsListForm = new BrandsListForm();
            brandsListForm.Show();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.Show();
        }

        private void purchaseHistoryButton_Click(object sender, EventArgs e)
        {
            PurchaseHistoryForm purchaseHistoryForm = new PurchaseHistoryForm();
            purchaseHistoryForm.Show();
        }

        private void cashierDashboardButton_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.Show();
        }

        private void saleHistoryButton_Click(object sender, EventArgs e)
        {
            SaleHistory saleHistory = new SaleHistory();
            saleHistory.Show();
        }
    }
}
