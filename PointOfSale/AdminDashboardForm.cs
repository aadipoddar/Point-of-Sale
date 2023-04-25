using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PointOfSale.Brands;
using PointOfSale.Categories;
using PointOfSale.Products;
using PointOfSale.Purchase;

namespace PointOfSale
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
    }
}
