﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SRePS
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            //retrieve current date
            DateTime s_date = DateTime.Today;

            Boolean added = false;

            try
            {
                conn.Open();

                if (Convert.ToInt32(txtChange.Text) < 0 || string.IsNullOrEmpty(txtPaid.Text))
                {
                    MessageBox.Show("The payment must not be lower than total!");
                    txtPaid.Focus();
                    txtPaid.SelectAll();
                }
                else
                {
                    //the Order table needs the Inv_No, therefore execute the INSERT of Sales first
                    string my_query = "INSERT INTO `Sales` (`S_Date`,`E_ID`) VALUES (?,?)";
                    OleDbCommand cmd = new OleDbCommand(my_query, conn);
                    cmd.Parameters.AddWithValue("@S_Date", s_date);
                    cmd.Parameters.AddWithValue("@E_ID", Program.curUserName);
                    cmd.ExecuteNonQuery();

                    //Execute the INSERT for Order
                    for (int i = 0; i < Program.frmAddS.itemGrid.Rows.Count - 1; i++)
                    {
                        string my_query2 = "INSERT INTO `Order` (`Inv_No`,`P_ID`, `S_Quantity`) VALUES (?,?,?)";
                        OleDbCommand cmd2 = new OleDbCommand(my_query2, conn);

                        cmd2.Parameters.AddWithValue("@Inv_No", Convert.ToDouble(Program.frmAddS.lblInv_No.Text));


                        cmd2.Parameters.AddWithValue("@P_ID", Convert.ToDouble(Program.frmAddS.itemGrid.Rows[i].Cells[0].Value));
                        cmd2.Parameters.AddWithValue("@S_Quantity", Convert.ToDouble(Program.frmAddS.itemGrid.Rows[i].Cells[3].Value));

                        cmd2.ExecuteNonQuery();

                        //update the P_Quantity
                        string reduce = "update Product set [P_Quantity]=[P_Quantity]-@Quantity where [P_ID] = @ID";
                        OleDbCommand cmdr = new OleDbCommand(reduce, conn);

                        cmdr.Parameters.AddWithValue("@Quantity", Convert.ToDouble(Program.frmAddS.itemGrid.Rows[i].Cells[3].Value));
                        cmdr.Parameters.AddWithValue("@ID", Convert.ToDouble(Program.frmAddS.itemGrid.Rows[i].Cells[0].Value));
                        cmdr.ExecuteNonQuery();

                    }

                    

                    if(Convert.ToDouble(txtPaid.Text) >= Convert.ToDouble(txtTotal.Text))
                    {
                        MessageBox.Show("Committed!");
                        Program.frmSales.salesTableAdapter.Fill(Program.frmSales.sRePS_DatabaseDataSet.Sales);

                        //Clear the datagrid
                        if (Program.frmAddS.sRePS_DatabaseDataSet.Tables["AddItem"] != null)
                        {
                            Program.frmAddS.sRePS_DatabaseDataSet.Tables["AddItem"].Clear();
                        }

                        if (Program.isOpened(Program.frmProduct) == true)
                        {
                            Program.frmProduct.productTableAdapter.Fill(Program.frmProduct.sRePS_DatabaseDataSet.Product);
                        }
                        added = true;
                        Program.frmP.Close();
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add sales due to " + ex.Message);
            }
            finally
            {
                conn.Close();
                //increase the Inv_No after the user successfully committed the sales
                if (added == true)
                {
                    Program.frmAddS.lblInv_No.Text = Convert.ToString(Convert.ToInt32(Program.frmAddS.lblInv_No.Text) + 1);
                }
               
                
            }
        }

        private void lblTotalToPay_Click(object sender, EventArgs e)
        {
            //code written in AddSale page
        }


        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The payment has not been committed! Are you sure you want to cancel?)", "Warning", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Program.frmP.Close();
                Program.frmAddS.Show();
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < Program.frmAddS.itemGrid.Rows.Count - 1; i++)
            {
                sum += Convert.ToDouble(Program.frmAddS.itemGrid.Rows[i].Cells["Total"].Value.ToString());   //NOTE: changed to "Total"
            }
            
            txtTotal.Text = Convert.ToString(sum);
            txtChange.Text = "0";
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaid.Text))
            {
                
                txtChange.Text = txtTotal.Text;
            }
            else
            {
                txtChange.Text = Convert.ToString(Convert.ToDouble(txtPaid.Text) - Convert.ToDouble(txtTotal.Text));
            }

        }
    }
}