﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Cashier
{
    public partial class CashierDashboardForm : Form
    {
        public CashierDashboardForm()
        {
            InitializeComponent();
        }

        private void newTransactionButton_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.Show();
        }
    }
}
