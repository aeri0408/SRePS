﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRePS
{
    public partial class frmSalesManagement : Form
    {
        public frmSalesManagement()
        {
            InitializeComponent();
        }

        private void frmSalesManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Sales);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
