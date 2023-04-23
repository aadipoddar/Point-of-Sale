using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointOfSaleDataSet.vwShowProducts' table. You can move, or remove it, as needed.
            this.vwShowProductsTableAdapter.Fill(this.pointOfSaleDataSet.vwShowProducts);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", dataGridView1.Columns[1].Name, textBox1.Text);
            (dataGridView1.DataSource as BindingSource).Filter = string.Format("{0} LIKE '%{1}%'", dataGridView1.Columns[1].DataPropertyName, textBox1.Text);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vwShowProductsTableAdapter.FillBy(this.pointOfSaleDataSet.vwShowProducts, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vwShowProductsTableAdapter.FillBy1(this.pointOfSaleDataSet.vwShowProducts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vwShowProductsTableAdapter.FillBy2(this.pointOfSaleDataSet.vwShowProducts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewCell cell = dataGridView1.Rows[rowIndex].Cells[1];
                    if (cell != null && cell.Value != null)
                    {
                        MessageBox.Show(cell.Value.ToString());
                    }
                }
            }
        }
    }
}
