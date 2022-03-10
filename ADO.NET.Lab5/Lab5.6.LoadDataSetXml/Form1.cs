using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5._6.LoadDataSetXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet NorthwindDataSet = new DataSet();

        private void buttonLoadSchema_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.ReadXmlSchema("Northwind.xsd");
            dataGridViewCustomers.DataSource = NorthwindDataSet.Tables["Customers"];
            dataGridViewOrders.DataSource = NorthwindDataSet.Tables["Orders"];
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.ReadXml("Northwind.xml");
        }
    }
}
