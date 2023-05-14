﻿using WinForms.PointOfSaleLibrary.Data;
using WinForms.PointOfSaleLibrary.Models;

namespace WinForms.PointOfSale.Categories;

public partial class CategoriesEditForm : Form
{
    CategoryData categoryData = new();
    CategoryModel categoryModel = new();

    CategoriesListForm categoriesListForm;

    public int categoryId;

    public CategoriesEditForm(CategoriesListForm categoriesListForm)
    {
        InitializeComponent();

        this.categoriesListForm = categoriesListForm;
    }

    private void TextBoxClear()
    {
        saveButton.Enabled = true;
        saveButton.Visible = true;

        updateButton.Enabled = false;
        updateButton.Visible = false;

        categoryTextBox.Clear();
        categoryTextBox.Focus();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to save this Category", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            categoryModel.CategoryName = categoryTextBox.Text;

            categoryData.InsertCategory(categoryModel);

            TextBoxClear();

            _ = categoriesListForm.DataGridRefresh();
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to update this Category name", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            categoryModel.CategoryId = categoryId;
            categoryModel.CategoryName = categoryTextBox.Text;

            categoryData.UpdateCategory(categoryModel);

            cancelButton_Click(sender, e);
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
        _ = categoriesListForm.DataGridRefresh();
    }
}
