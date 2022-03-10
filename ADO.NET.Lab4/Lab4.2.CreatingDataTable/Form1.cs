using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._2.CreatingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private DataSet dataSet;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;

        private void MakeDataTables()
        {
            MakeParentTable();
            MakeChaildTable();
            MakeDataRelation();
            BindeToDataGrid();
        }



        private void MakeParentTable()
        {
            DataTable table = new DataTable("ParentTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ParentItem";
            column.AutoIncrement = false;
            column.Caption = "ParentItem";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            table.Columns.Add("Total", typeof(Double));

            table.Columns.Add("SalesTax", typeof(Double), "Total * 0.13");

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["ID"];
            table.PrimaryKey = PrimaryKeyColumns;

            dataSet = new DataSet();
            dataSet.Tables.Add(table);

            for (int i = 0; i <= 2; i++) 
            { 
                row = table.NewRow(); 
                row["id"] = i; 
                row["ParentItem"] = "ParentItem " + i; 
                row["Total"] = 2 * i + 0.5; table.Rows.Add(row); 
            }
        }

        private void MakeChaildTable()
        {
            DataTable table = new DataTable("ChildTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ChildId";
            column.AutoIncrement = true;
            column.Caption = "ID";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ChildItem";
            column.AutoIncrement = false;
            column.Caption = "ChildItem";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ParentID";
            column.AutoIncrement = false;
            column.Caption = "ParentID";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            dataSet.Tables.Add(table);

            for(int i = 0; i<=4; i++)
            {
                row = table.NewRow();
                row["ChildID"] = i;
                row["ChildItem"] ="Item" + i;
                row["ParentID"] = 0;
                table.Rows.Add(row);
            }

            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow();
                row["ChildID"] = i + 5;
                row["ChildItem"] = "Item" + i;
                row["ParentID"] = 1;
                table.Rows.Add(row);
            }

            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow();
                row["ChildID"] = i+10;
                row["ChildItem"] = "Item" + i;
                row["ParentID"] = 2;
                table.Rows.Add(row);
            }
        }

        private void MakeDataRelation()
        {
            DataColumn parentColumn = dataSet.Tables["ParentTable"].Columns["ID"];
            DataColumn childColumn = dataSet.Tables["ChildTable"].Columns["ParentID"];

            DataRelation relation = new DataRelation("parent2Child", parentColumn, childColumn);
            dataSet.Tables["ChildTable"].ParentRelations.Add(relation);
        }

        private void BindeToDataGrid()
        {
            bindingSource1 = new BindingSource();
            bindingSource2 = new BindingSource();

            bindingSource1.DataSource = dataSet.Tables["ParentTable"];
            bindingSource2.DataSource = dataSet.Tables["ChildTable"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bindingSource1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeDataTables();
        }
    }
}
