using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;

namespace Lab8._1.LINQsql_1
{
    public partial class Form1 : Form
    {
        DataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            var result = from c in db.GetTable<Customer>()
                         where c.City == "London"
                         select c;
            foreach (var c in result)
            {
                listBox1.Items.Add(c.ToString());
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonAddObj_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.CustomerID = "WINGT";
            cust.City = "London";
            cust.CompanyName = "Steave Lask";

            db.GetTable<Customer>().InsertOnSubmit(cust);
            db.SubmitChanges();
        }

        private void buttonRemoveObj_Click(object sender, EventArgs e)
        {
            var deleteObj =
                from cust in db.GetTable<Customer>()
                where cust.CustomerID == "WINGT"
                select cust;
            if (deleteObj.Count() > 0)
            {
                db.GetTable<Customer>().DeleteOnSubmit(deleteObj.First());
                db.SubmitChanges();
            }

        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            var custQuery =
                from cust in db.GetTable<Customer>()
                where cust.Orders.Any()
                select cust;

            foreach (var custObj in custQuery)
            {
                ListViewItem item =
                    listView1.Items.Add(custObj.CustomerID.ToString());
                item.SubItems.Add(custObj.City.ToString());
                item.SubItems.Add(custObj.Orders.Count.ToString());
            }
        }
    }
}
