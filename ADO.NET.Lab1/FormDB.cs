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
using System.Configuration;


namespace ADO.NET.Lab1
{
    public partial class FormDB : Form
    {        

       
        public FormDB()
        {
            InitializeComponent();
            this.connection.StateChange += new StateChangeEventHandler(this.Connection_StateChange);
        }

        SqlConnection connection = new SqlConnection();
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = Northwind; Integrated Security = True";

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
            { returnValue = settings.ConnectionString; }
            return returnValue;
        }
        string connectionString = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        //Кнопка подключения к БД
        private void connectToDBToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    try 
                    { 
                        if (connection.State != ConnectionState.Open) 
                        { connection.ConnectionString = connectionString; 
                            connection.Open(); 
                            MessageBox.Show("Соединение с базой данных " + connection.Database + " выполнено успешно " + "\nСервер: " + connection.DataSource); } 
                        else MessageBox.Show("Соединение с базой данных уже установлено"); }
                    catch (SqlException XcpSQL)
                        {
                            foreach (SqlError se in XcpSQL.Errors)
                                {
                    MessageBox.Show(se.Message, "" + se.Source,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                        }
                    catch ( Exception Xcp)
                        {
                            MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
        }
        
        //Кнопка отключения от БД
        private void disconnectFromDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        //Кнопка асинхронного подключения к БД
        private async void 
            asyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show
                        ("Соединение с базой данных " + connection.Database +
                        " выполнено успешно " + "\nСервер: " + connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
            }

        //Делает пункты меню недоступными
        private void Connection_StateChange(object sender, StateChangeEventArgs e)
        {
            connectToDBToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            asyncToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectFromDBToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void connectionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = string.Format("Name={0}\n" +
                        "ProviderName={1}\n" +
                        "ConnectionString={2}",
                        cs.Name, cs.ProviderName, cs.ConnectionString);
                    MessageBox.Show(str, "Параметры подключений");
                }
            }
        }
    }
    }

