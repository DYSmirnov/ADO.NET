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

namespace Lab4._5.WorkingdataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NorthwindDataSet45.CustomersRow GetSelectedRow()
        {
            String SelectedCustomerID = CustomersDataGridView.CurrentRow.Cells["CustomerID"].Value.ToString();
            NorthwindDataSet45.CustomersRow SelectedRow = northwindDataSet45.Customers.FindByCustomerID(SelectedCustomerID);
            return SelectedRow;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CustomersDataGridView.DataSource = northwindDataSet45.Customers;
            CustomersDataGridView.MultiSelect = false;
            CustomersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            CustomersDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        //buttonFillTable_Click
        private void buttonFillTable_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(northwindDataSet45.Customers);
        }


        //buttonAddRow_Click
        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            NorthwindDataSet45.CustomersRow NewRow = (NorthwindDataSet45.CustomersRow)northwindDataSet45.Customers.NewRow();

            NewRow.CustomerID = "WINGT";
            NewRow.CompanyName = "Wing Toys";
            NewRow.ContactName = "Steave Lask";
            NewRow.ContactTitle = "CEO";
            NewRow.Address = "12 street";
            NewRow.City = "Buffalo";
            NewRow.Region = "NY";
            NewRow.PostalCode = "235";
            NewRow.Country = "USA";
            NewRow.Phone = "206";
            NewRow.Fax = "26";

            try
            {
                northwindDataSet45.Customers.Rows.Add(NewRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("Add Row Failed"));
            }

        }


        //buttonDeleteRow_Click
        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }
        private void UpdateRowVersionDisplay()
        {
            try
            {
                textBoxCurrentDRV.Text = GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
            }

            catch(Exception ex)
            {
                textBoxCurrentDRV.Text = ex.Message;
            }
            try
            {
                textBoxOriginalDRV.Text = GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
            }

            catch (Exception ex)
            {
                textBoxOriginalDRV.Text = ex.Message;
            }

            textBoxRowState.Text = GetSelectedRow().RowState.ToString();


        }

        private void buttonUpdateValue_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name] = textBoxCellValue.Text;
            UpdateRowVersionDisplay();
        }

        private void CustomersDataGridView_Click(object sender, EventArgs e)
        {
            textBoxCellValue.Text = CustomersDataGridView.CurrentCell.ToString();
            UpdateRowVersionDisplay();
        }

        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();
        }

        private void buttonRejectChanges_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();
        }
    }
}
