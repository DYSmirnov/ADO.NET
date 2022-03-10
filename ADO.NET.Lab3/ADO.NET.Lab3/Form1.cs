﻿using System;
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

namespace ADO.NET.Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //запрос на получение таблицы
        private void buttonDataQuery_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
           
            {
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand1.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++) 
                            {
                            results.Append(reader[i].ToString() + "\t");
                            }
                        results.Append(Environment.NewLine);
                    }
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection1.Close();
                }
            }
        }
        //пакетный запрос
        private void buttonPacketQuery_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
           
            {
                sqlCommand1.CommandText = "SELECT CustomerID, CompanyName FROM Customers;" +
                    " SELECT ProductName, UnitPrice, QuantityPerUnit FROM Products;";
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand1.ExecuteReader();
                    bool MoreResults = false;
                    do
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                results.Append(reader[i].ToString() + "\t");
                            }
                            results.Append(Environment.NewLine);
                        }
                        MoreResults = reader.NextResult();
                    } while (MoreResults);
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection1.Close();
                }
            }
        }

        //запрос спомощью хранимой процедуры
        private void buttonStoredProcedure_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
           
            {
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand2.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection1.Close();
                }
            }
        }

        //Создание таблицы
        private void buttonCreateTabel_Click(object sender, EventArgs e)
        {
            using (sqlConnection1)
            {
                sqlCommand3.CommandText = "CREATE TABLE SalesPerson (" +
                    "[SalesPersonID] [INT] IDENTITY(1,1) NOT NULL," +
                    "[FirstName] [nvarchar](50) NULL," +
                    "[LastName] [nvarchar](50) NULL)";
                try
                {
                    sqlConnection1.Open();
                    sqlCommand3.ExecuteNonQuery();
                    MessageBox.Show("Таблица SalesPersons создана");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Запрос с параметром
        private void buttonParamQuery_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            try
            {
                sqlCommand4.Parameters["@City"].Value = CityTextBox.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand4.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                ResultsTextBox.Text = results.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        //процедура с параметром
        private void buttonParamProc_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            try
            {
                sqlCommand5.Parameters["@CategoryName"].Value = CategoryNameTextBox.Text;
                sqlCommand5.Parameters["@OrdYear"].Value = textBoxOrdYearTextBox.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand5.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                ResultsTextBox.Text = results.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
    }
}
