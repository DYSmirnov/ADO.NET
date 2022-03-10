
namespace Lab8._4.LINQsql_m
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
            this.buttonBest = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TenMost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonBest
            // 
            this.buttonBest.Location = new System.Drawing.Point(12, 12);
            this.buttonBest.Name = "buttonBest";
            this.buttonBest.Size = new System.Drawing.Size(110, 40);
            this.buttonBest.TabIndex = 0;
            this.buttonBest.Text = "Best 10";
            this.buttonBest.UseVisualStyleBackColor = true;
            this.buttonBest.Click += new System.EventHandler(this.buttonBest_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenMost,
            this.UnitPrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(199, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(319, 172);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TenMost
            // 
            this.TenMost.Text = "Ten Most";
            this.TenMost.Width = 115;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price";
            this.UnitPrice.Width = 88;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonBest);
            this.Name = "Form1";
            this.Text = "Lab8.4.LINQsql_m";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBest;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TenMost;
        private System.Windows.Forms.ColumnHeader UnitPrice;
    }
}

