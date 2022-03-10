
namespace ADO.NET.Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.buttonDataQuery = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.buttonPacketQuery = new System.Windows.Forms.Button();
            this.buttonStoredProcedure = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.buttonCreateTabel = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.buttonParamQuery = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.buttonParamProc = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.textBoxOrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
    "True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        CustomerID, CompanyName\r\nFROM            Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // buttonDataQuery
            // 
            this.buttonDataQuery.Location = new System.Drawing.Point(27, 31);
            this.buttonDataQuery.Name = "buttonDataQuery";
            this.buttonDataQuery.Size = new System.Drawing.Size(83, 31);
            this.buttonDataQuery.TabIndex = 0;
            this.buttonDataQuery.Text = "Data Query";
            this.buttonDataQuery.UseVisualStyleBackColor = true;
            this.buttonDataQuery.Click += new System.EventHandler(this.buttonDataQuery_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(152, 12);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(350, 196);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // buttonPacketQuery
            // 
            this.buttonPacketQuery.Location = new System.Drawing.Point(27, 77);
            this.buttonPacketQuery.Name = "buttonPacketQuery";
            this.buttonPacketQuery.Size = new System.Drawing.Size(83, 31);
            this.buttonPacketQuery.TabIndex = 2;
            this.buttonPacketQuery.Text = "Packet Query";
            this.buttonPacketQuery.UseVisualStyleBackColor = true;
            this.buttonPacketQuery.Click += new System.EventHandler(this.buttonPacketQuery_Click);
            // 
            // buttonStoredProcedure
            // 
            this.buttonStoredProcedure.Location = new System.Drawing.Point(27, 124);
            this.buttonStoredProcedure.Name = "buttonStoredProcedure";
            this.buttonStoredProcedure.Size = new System.Drawing.Size(83, 38);
            this.buttonStoredProcedure.TabIndex = 3;
            this.buttonStoredProcedure.Text = "Stored Procedure";
            this.buttonStoredProcedure.UseVisualStyleBackColor = true;
            this.buttonStoredProcedure.Click += new System.EventHandler(this.buttonStoredProcedure_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "Ten Most Expensive Products";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // buttonCreateTabel
            // 
            this.buttonCreateTabel.Location = new System.Drawing.Point(27, 177);
            this.buttonCreateTabel.Name = "buttonCreateTabel";
            this.buttonCreateTabel.Size = new System.Drawing.Size(83, 31);
            this.buttonCreateTabel.TabIndex = 4;
            this.buttonCreateTabel.Text = "Create Tabel";
            this.buttonCreateTabel.UseVisualStyleBackColor = true;
            this.buttonCreateTabel.Click += new System.EventHandler(this.buttonCreateTabel_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // buttonParamQuery
            // 
            this.buttonParamQuery.Location = new System.Drawing.Point(27, 225);
            this.buttonParamQuery.Name = "buttonParamQuery";
            this.buttonParamQuery.Size = new System.Drawing.Size(83, 31);
            this.buttonParamQuery.TabIndex = 5;
            this.buttonParamQuery.Text = "Param Query";
            this.buttonParamQuery.UseVisualStyleBackColor = true;
            this.buttonParamQuery.Click += new System.EventHandler(this.buttonParamQuery_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(138, 231);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(111, 22);
            this.CityTextBox.TabIndex = 6;
            this.CityTextBox.Text = "London";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT        CustomerID, CompanyName, City\r\nFROM            Customers\r\nWHERE    " +
    "    (City = @City)";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // buttonParamProc
            // 
            this.buttonParamProc.Location = new System.Drawing.Point(27, 277);
            this.buttonParamProc.Name = "buttonParamProc";
            this.buttonParamProc.Size = new System.Drawing.Size(83, 31);
            this.buttonParamProc.TabIndex = 7;
            this.buttonParamProc.Text = "Param Proc";
            this.buttonParamProc.UseVisualStyleBackColor = true;
            this.buttonParamProc.Click += new System.EventHandler(this.buttonParamProc_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(138, 283);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.CategoryNameTextBox.TabIndex = 8;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // textBoxOrdYearTextBox
            // 
            this.textBoxOrdYearTextBox.Location = new System.Drawing.Point(270, 283);
            this.textBoxOrdYearTextBox.Name = "textBoxOrdYearTextBox";
            this.textBoxOrdYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrdYearTextBox.TabIndex = 9;
            this.textBoxOrdYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 352);
            this.Controls.Add(this.textBoxOrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.buttonParamProc);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.buttonParamQuery);
            this.Controls.Add(this.buttonCreateTabel);
            this.Controls.Add(this.buttonStoredProcedure);
            this.Controls.Add(this.buttonPacketQuery);
            this.Controls.Add(this.buttonDataQuery);
            this.Controls.Add(this.ResultsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button buttonDataQuery;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button buttonPacketQuery;
        private System.Windows.Forms.Button buttonStoredProcedure;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button buttonCreateTabel;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button buttonParamQuery;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button buttonParamProc;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox textBoxOrdYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

