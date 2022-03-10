using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Lab9._2.CodeFirst;

namespace Lab9._2.CustMan
{
    public partial class CustView : Form
    {
        public CustView()
        {
            InitializeComponent();
            
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }


        SampleContext context = new SampleContext();
        byte[] ph;

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(diag.OpenFile());
                ImageConverter converter = new ImageConverter();
                ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {

                    FirstName = this.textBoxName.Text,
                    LastName = this.textBoxLastName.Text,
                    Email = this.textBoxMail.Text,
                    Age = Int32.Parse(this.textBoxAge.Text),
                    Photo = ph,
                    Orders = listBoxOrder.SelectedItems.OfType<Order>().ToList()
                };
                context.Customers.Add(customer);
               
                context.SaveChanges();

                Output();

                textBoxName.Text = String.Empty;
                textBoxLastName.Text = String.Empty;
                textBoxAge.Text = String.Empty;
                textBoxMail.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void Output()
        {
            if (this.radioButtonCustomers.Checked == true)
                dataGridView1.DataSource = context.Customers.ToList();

            else if (this.radioButtonOrders.Checked == true)
                dataGridView1.DataSource = context.Orders.ToList();

            else if (this.radioButtonVip.Checked == true)
                dataGridView1.DataSource = context.VipOrders.ToList();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Output();
            var query =
                from b in context.Customers
                orderby b.FirstName
                select b.FirstName;
            comboBoxCustList.DataSource = query.ToList();
        }

        private void CustView_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order
            {
                ProductName = "Аудио",
                Quantity = 12,
                PurchaseDate = DateTime.Parse("12.01.2016")
            });

            context.Orders.Add(new Order
            {
                ProductName = "Видео",
                Quantity = 22,
                PurchaseDate = DateTime.Parse("10.01.2016")
            });

            
            context.VipOrders.Add(new VipOrder
            {
                ProductName = "Авто",
                Quantity = 101,
                PurchaseDate = DateTime.Parse("10.01.2016"),
                status = "Высокий"
            });

            context.SaveChanges();
            listBoxOrder.DataSource = context.Orders.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var customer = dataGridView1.CurrentRow.DataBoundItem as Customer;
            if (customer == null) return;

            labelID.Text = Convert.ToString(customer.CustomerId);
            textBoxCustomer.Text = customer.ToString();

            textBoxName.Text = customer.FirstName;
            textBoxLastName.Text = customer.LastName;
            textBoxAge.Text = Convert.ToString(customer.Age);
            textBoxMail.Text = customer.Email;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelID.Text == String.Empty) return;

            var id = Convert.ToInt32(labelID.Text);
            var customer = context.Customers.Find(id);

            if (customer == null) return;

            customer.FirstName = this.textBoxName.Text;
            customer.LastName = this.textBoxLastName.Text;
            customer.Email = this.textBoxMail.Text;
            customer.Age = Int32.Parse(this.textBoxAge.Text);

            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
            Output();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (labelID.Text == String.Empty) return;

            var id = Convert.ToInt32(labelID.Text);
            var customer = context.Customers.Find(id);

            context.Entry(customer).State = EntityState.Deleted;
            context.SaveChanges();
            Output();
        }
    }
}
