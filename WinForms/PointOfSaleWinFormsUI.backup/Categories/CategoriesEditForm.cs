using System;
using System.Windows.Forms;

using WinForms.PointOfSaleLibrary.Data;
using WinForms.PointOfSaleLibrary.Models;

namespace WinForms.PointOfSale.Categories
{
    public partial class CategoriesEditForm : Form
    {
        CategoryData categoryData = new CategoryData();
        CategoryModel categoryModel = new CategoryModel();

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
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoryModel.Category = categoryTextBox.Text;

                    categoryData.InsertCategory(categoryModel);

                    TextBoxClear();

                    _ = categoriesListForm.DataGridRefresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Category name", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoryModel.Id = categoryId;
                    categoryModel.Category = categoryTextBox.Text;

                    categoryData.UpdateCategory(categoryModel);

                    cancelButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            _ = categoriesListForm.DataGridRefresh();
        }
    }
}
