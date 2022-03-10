
namespace Lab4._6.DataViewExample
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
            this.CustDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonSetDataViewProporties = new System.Windows.Forms.Button();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.northwindDataSet1 = new Lab4._6.DataViewExample.NorthwindDataSet();
            this.customersTableAdapter1 = new Lab4._6.DataViewExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new Lab4._6.DataViewExample.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.buttonGetOrders = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustDataGridView
            // 
            this.CustDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustDataGridView.Location = new System.Drawing.Point(302, 12);
            this.CustDataGridView.Name = "CustDataGridView";
            this.CustDataGridView.Size = new System.Drawing.Size(229, 379);
            this.CustDataGridView.TabIndex = 0;
            // 
            // textBoxSort
            // 
            this.textBoxSort.Location = new System.Drawing.Point(12, 28);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(100, 22);
            this.textBoxSort.TabIndex = 1;
            this.textBoxSort.Text = "CustomerID";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(176, 27);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 22);
            this.textBoxFilter.TabIndex = 2;
            this.textBoxFilter.Text = "City = \'London\'";
            // 
            // buttonSetDataViewProporties
            // 
            this.buttonSetDataViewProporties.Location = new System.Drawing.Point(12, 86);
            this.buttonSetDataViewProporties.Name = "buttonSetDataViewProporties";
            this.buttonSetDataViewProporties.Size = new System.Drawing.Size(100, 37);
            this.buttonSetDataViewProporties.TabIndex = 3;
            this.buttonSetDataViewProporties.Text = "Set Data View Proporties";
            this.buttonSetDataViewProporties.UseVisualStyleBackColor = true;
            this.buttonSetDataViewProporties.Click += new System.EventHandler(this.buttonSetDataViewProporties_Click);
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Location = new System.Drawing.Point(176, 86);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(100, 37);
            this.buttonAddRow.TabIndex = 4;
            this.buttonAddRow.Text = "Add Row";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonGetOrders
            // 
            this.buttonGetOrders.Location = new System.Drawing.Point(12, 160);
            this.buttonGetOrders.Name = "buttonGetOrders";
            this.buttonGetOrders.Size = new System.Drawing.Size(100, 37);
            this.buttonGetOrders.TabIndex = 5;
            this.buttonGetOrders.Text = "GetOrders";
            this.buttonGetOrders.UseVisualStyleBackColor = true;
            this.buttonGetOrders.Click += new System.EventHandler(this.buttonGetOrders_Click);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(538, 12);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowTemplate.Height = 24;
            this.OrdersGridView.Size = new System.Drawing.Size(240, 379);
            this.OrdersGridView.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdersGridView);
            this.Controls.Add(this.buttonGetOrders);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.buttonSetDataViewProporties);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.textBoxSort);
            this.Controls.Add(this.CustDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustDataGridView;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonSetDataViewProporties;
        private System.Windows.Forms.Button buttonAddRow;
        private NorthwindDataSet northwindDataSet1;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.Button buttonGetOrders;
        private System.Windows.Forms.DataGridView OrdersGridView;
    }
}

