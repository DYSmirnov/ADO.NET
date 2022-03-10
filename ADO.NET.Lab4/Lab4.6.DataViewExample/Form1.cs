using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._6.DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataView customersDataView;
        DataView ordersDataView;

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);

            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);

            customersDataView.Sort = "CustomerID";

            CustDataGridView.DataSource = customersDataView;
        }

        private void buttonSetDataViewProporties_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = textBoxSort.Text;
            customersDataView.RowFilter = textBoxFilter.Text;
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            DataRowView NewRow = customersDataView.AddNew();
            NewRow["CustomerID"] = "WGT";
            NewRow["CompanyName"] = "Wng Toys";
            NewRow["ContactName"] = "Lteave Lask";
            NewRow["ContactTitle"] = "EO";
            NewRow["Address"] = "12 sreet";
            NewRow["City"] = "Buffal";
            NewRow["Region"] = "NY";
            NewRow["PostalCode"] = "235";
            NewRow["Country"] = "USA";
            NewRow["Phone"] = "2006";
            NewRow["Fax"] = "20060";

            NewRow.EndEdit();
        }

        private void buttonGetOrders_Click(object sender, EventArgs e)
        {
            string selectedCustomerID = (string)CustDataGridView.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            DataRowView selectedRow = customersDataView[customersDataView.Find(selectedCustomerID)];
            ordersDataView = selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
            OrdersGridView.DataSource = ordersDataView;
        }
    }
}
