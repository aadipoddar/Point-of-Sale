﻿using System.Windows.Forms;

using Microsoft.Data.SqlClient;

namespace PointOfSale.Categories;

public partial class CategoriesListForm : Form
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;

    DBConnection dbcon = new DBConnection();

    public CategoriesListForm()
    {
        InitializeComponent();

        cn = new SqlConnection(dbcon.MyConnection());
        LoadRecords();
    }

    #region Key Events

    private void KeyEvents(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.A)
        {
            addCategoryButton_Click(sender, e);
        }

        if (e.KeyCode == Keys.S)
        {
            searchTextBox.Focus();
        }

        if (e.KeyCode == Keys.Escape)
        {
            Close();
        }

        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.E)
        {
            dataGridViewCategories_CellContentClick(sender, new DataGridViewCellEventArgs(3, dataGridViewCategories.CurrentRow.Index));
        }

        if (e.KeyCode == Keys.Delete)
        {
            dataGridViewCategories_CellContentClick(sender, new DataGridViewCellEventArgs(4, dataGridViewCategories.CurrentRow.Index));
        }
    }

    private void CategoriesListForm_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void dataGridViewCategories_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    private void addCategoryButton_KeyDown(object sender, KeyEventArgs e)
    {
        KeyEvents(sender, e);
    }

    #endregion

    public void LoadRecords()
    {
        int i = 0;

        dataGridViewCategories.Rows.Clear();
        cn.Open();
        cm = new SqlCommand("select * from Category order by category", cn);
        dr = cm.ExecuteReader();

        while (dr.Read())
        {
            i += 1;
            dataGridViewCategories.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
        }

        dr.Close();
        cn.Close();
    }

    private void addCategoryButton_Click(object sender, EventArgs e)
    {
        CategoriesEditForm frm = new CategoriesEditForm(this);
        frm.Show();
        frm.updateButton.Visible = false;
        frm.updateButton.Enabled = false;
        frm.Text = "Add New Category";
    }

    private void dataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        string colName = dataGridViewCategories.Columns[e.ColumnIndex].Name;

        if (colName == "editColumn")
        {

            CategoriesEditForm frm = new CategoriesEditForm(this);
            frm.originalCategoryId.Text = dataGridViewCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.categoryNameTextBox.Text = dataGridViewCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.saveButton.Visible = false;
            frm.saveButton.Enabled = false;
            frm.Text = "Edit Category";
            frm.Show();
        }

        else if (colName == "deleteColumn")
        {
            if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("delete from Category where id like '" + dataGridViewCategories.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Record has been successfully deleted");
                LoadRecords();
            }
        }
    }

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        dataGridViewCategories.Rows.Clear();

        cn.Open();
        cm = new SqlCommand("select * from Category where category like '%" + searchTextBox.Text + "%' order by category", cn);
        dr = cm.ExecuteReader();

        int i = 0;
        while (dr.Read())
        {
            i += 1;
            dataGridViewCategories.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
        }

        dr.Close();
        cn.Close();
    }
}
