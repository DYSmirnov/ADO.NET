
namespace Lab8._1.LINQsql_1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddObj = new System.Windows.Forms.Button();
            this.buttonRemoveObj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(536, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 225);
            this.listBox1.TabIndex = 0;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(24, 30);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(116, 47);
            this.buttonLoadData.TabIndex = 1;
            this.buttonLoadData.Text = "LoadData";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(24, 105);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 47);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddObj
            // 
            this.buttonAddObj.Location = new System.Drawing.Point(24, 194);
            this.buttonAddObj.Name = "buttonAddObj";
            this.buttonAddObj.Size = new System.Drawing.Size(116, 47);
            this.buttonAddObj.TabIndex = 3;
            this.buttonAddObj.Text = "Add Object";
            this.buttonAddObj.UseVisualStyleBackColor = true;
            this.buttonAddObj.Click += new System.EventHandler(this.buttonAddObj_Click);
            // 
            // buttonRemoveObj
            // 
            this.buttonRemoveObj.Location = new System.Drawing.Point(24, 273);
            this.buttonRemoveObj.Name = "buttonRemoveObj";
            this.buttonRemoveObj.Size = new System.Drawing.Size(116, 47);
            this.buttonRemoveObj.TabIndex = 4;
            this.buttonRemoveObj.Text = "Remove Object";
            this.buttonRemoveObj.UseVisualStyleBackColor = true;
            this.buttonRemoveObj.Click += new System.EventHandler(this.buttonRemoveObj_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.City,
            this.OrdersCount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(213, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 225);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Width = 91;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 83;
            // 
            // OrdersCount
            // 
            this.OrdersCount.Text = "OrdersCount";
            this.OrdersCount.Width = 113;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(294, 261);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(116, 47);
            this.buttonFill.TabIndex = 6;
            this.buttonFill.Text = "Fill";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonRemoveObj);
            this.Controls.Add(this.buttonAddObj);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddObj;
        private System.Windows.Forms.Button buttonRemoveObj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader OrdersCount;
        private System.Windows.Forms.Button buttonFill;
    }
}

