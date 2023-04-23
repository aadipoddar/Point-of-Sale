﻿using PointOfSale.Cashier;
using PointOfSale.Categories;
using PointOfSale.Products;
using PointOfSale.StockIn;

namespace PointOfSale;

public partial class AdminDashboardForm : Form
{
    public AdminDashboardForm()
    {
        InitializeComponent();
    }

    #region Key Events

    private void KeyEvents(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.I)
        {
            manageStockInButton_Click(sender, e);
        }

        if (e.KeyCode == Keys.S)
        {
            manageSalesButton_Click(sender, e);
        }

        if (e.KeyCode == Keys.C)
        {
            manageCategoryButton_Click(sender, e);
        }

        if (e.KeyCode == Keys.B)
        {
            manageBrandButton_Click(sender, e);
        }

        if (e.KeyCode == Keys.P)
        {
            manageProductButton_Click(sender, e);
        }

        if (e.KeyCode == Keys.Escape)
        {
            Application.Exit();
        }
    }

    private void AdminDashboardForm_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void dashboardButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void stockInButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void manageSalesButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void manageProductButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void manageCategoryButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void manageBrandButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void recordsButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void systemSettingsButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void userSettingsButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void logoutButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    #endregion


    #region Button Click Events

    private void manageStockInButton_Click(object sender, EventArgs e)
    {
        StockInForm frm = new StockInForm();
        frm.Show();
    }
    private void manageProductButton_Click(object sender, EventArgs e)
    {
        ProductsListForm frm = new ProductsListForm();
        frm.Show();
    }

    private void manageCategoryButton_Click(object sender, EventArgs e)
    {
        CategoriesListForm frm = new CategoriesListForm();
        frm.Show();
    }

    private void manageBrandButton_Click(object sender, EventArgs e)
    {
        BrandsListForm frm = new BrandsListForm();
        frm.Show();
    }

    #endregion

    private void manageSalesButton_Click(object sender, EventArgs e)
    {
        BaseCashierModuleForm frm = new BaseCashierModuleForm();
        frm.Show();
    }
}