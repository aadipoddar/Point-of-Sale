using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PointOfSale.Categories;
using PointOfSale.Products;

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
    }
}
