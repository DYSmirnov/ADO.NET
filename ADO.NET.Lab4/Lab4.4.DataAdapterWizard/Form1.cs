using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab4._4.DataAdapterWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindDataSet1.Customers;
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }


        //buttonSaveChange
        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(northwindDataSet1);
        }

        //sqlDataAdapter1_RowUpdating
        private void sqlDataAdapter1_RowUpdating_1(object sender, SqlRowUpdatingEventArgs e)
        {
            NorthwindDataSet.CustomersRow CustRow = (NorthwindDataSet.CustomersRow)e.Row;
            DialogResult response = MessageBox.Show
            ("Continue updating " + CustRow.CustomerID.ToString() + "?", "Continue Update?", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }


        //sqlDataAdapter1_RowUpdated
        private void sqlDataAdapter1_RowUpdated_1(object sender, SqlRowUpdatedEventArgs e)
        {
            NorthwindDataSet.CustomersRow CustRow = (NorthwindDataSet.CustomersRow)e.Row;
            MessageBox.Show(CustRow.CustomerID.ToString() + "has been updated");
            northwindDataSet1.Customers.Clear();
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }

        private void sqlDataAdapter1_FillError(object sender, FillErrorEventArgs e)
        {
            DialogResult response = MessageBox.Show
                ("The following error occurred while Filling the DataSet: " + e.Errors.Message.ToString() +
             " Continue attempting to fill?", "FillError Encountered", MessageBoxButtons.YesNo);
               if (response == DialogResult.Yes)
            {
                e.Continue = true;
            }
            else
            {
                e.Continue = false;
            }
        }
    }
}
