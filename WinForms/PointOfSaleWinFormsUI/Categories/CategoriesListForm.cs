﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinForms.PointOfSaleLibrary.Data;
using WinForms.PointOfSaleLibrary.Models;

namespace WinForms.PointOfSale.Categories
{
    public partial class CategoriesListForm : Form
    {
        CategoryData categoryData = new CategoryData();
        List<CategoryModel> categories = new List<CategoryModel>();

        public CategoriesListForm()
        {
            InitializeComponent();
        }

        private void CategoriesListForm_Load(object sender, EventArgs e)
        {
            DataGridRefresh();
        }

        public async Task DataGridRefresh()
        {
            categories = (await categoryData.GetCategories()).ToList();
            dataGridViewCategories.DataSource = new BindingSource(categories, null);

            dataGridViewCategories.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCategories.Columns[1].HeaderText = "Category Name";
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewCategories.DataSource as BindingSource).Filter = string.Format("{0} LIKE '%{1}%'", dataGridViewCategories.Columns[1].DataPropertyName, searchTextBox.Text);
        }

        private void addCategoriesButton_Click(object sender, EventArgs e)
        {
            CategoriesEditForm categoriesEditForm = new CategoriesEditForm(this);
            categoriesEditForm.Show();

            categoriesEditForm.Text = "Add Category";

            categoriesEditForm.saveButton.Enabled = true;
            categoriesEditForm.saveButton.Visible = true;

            categoriesEditForm.updateButton.Enabled = false;
            categoriesEditForm.updateButton.Visible = false;
        }

        private void dataGridViewCategories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridViewCategories.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewCategories.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewCategories.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        CategoriesEditForm categoriesEditForm = new CategoriesEditForm(this);
                        categoriesEditForm.Show();

                        categoriesEditForm.Text = "Edit Category";

                        categoriesEditForm.saveButton.Visible = false;
                        categoriesEditForm.saveButton.Enabled = false;

                        categoriesEditForm.updateButton.Visible = true;
                        categoriesEditForm.updateButton.Enabled = true;

                        categoriesEditForm.categoryId = Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells[0].Value);
                        categoriesEditForm.categoryTextBox.Text = dataGridViewCategories.Rows[rowIndex].Cells[1].Value.ToString();

                        categoriesEditForm.categoryTextBox.Select();
                    }
                }
            }

            else if (e.KeyCode == Keys.Delete)
            {
                int rowIndex = dataGridViewCategories.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridViewCategories.Rows.Count)
                {
                    DataGridViewCell cell = dataGridViewCategories.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            categoryData.DeleteCategory(Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells[0].Value.ToString()));

                            DataGridRefresh();

                            // Select the previous row
                            if (dataGridViewCategories.Rows.Count > 1)
                            {
                                int selectRowIndex = rowIndex - 1;
                                if (selectRowIndex >= 0 && selectRowIndex < dataGridViewCategories.Rows.Count)
                                {
                                    dataGridViewCategories.CurrentCell = dataGridViewCategories.Rows[selectRowIndex].Cells[0];
                                    dataGridViewCategories.Rows[selectRowIndex].Selected = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}