
namespace ADO.NET.Lab1
{
    partial class FormDB
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonProductCount = new System.Windows.Forms.Button();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.buttonProductCountClass = new System.Windows.Forms.Button();
            this.labelProductCountClass = new System.Windows.Forms.Label();
            this.listViewProductsList = new System.Windows.Forms.ListView();
            this.buttonPruductsList = new System.Windows.Forms.Button();
            this.ProductTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Packing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDBToolStripMenuItem,
            this.disconnectFromDBToolStripMenuItem,
            this.asyncToolStripMenuItem,
            this.connectionListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToDBToolStripMenuItem
            // 
            this.connectToDBToolStripMenuItem.Name = "connectToDBToolStripMenuItem";
            this.connectToDBToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.connectToDBToolStripMenuItem.Text = "Connect to DB";
            this.connectToDBToolStripMenuItem.Click += new System.EventHandler(this.connectToDBToolStripMenuItem_Click);
            // 
            // disconnectFromDBToolStripMenuItem
            // 
            this.disconnectFromDBToolStripMenuItem.Name = "disconnectFromDBToolStripMenuItem";
            this.disconnectFromDBToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.disconnectFromDBToolStripMenuItem.Text = "Disconnect from DB";
            this.disconnectFromDBToolStripMenuItem.Click += new System.EventHandler(this.disconnectFromDBToolStripMenuItem_Click);
            // 
            // asyncToolStripMenuItem
            // 
            this.asyncToolStripMenuItem.Name = "asyncToolStripMenuItem";
            this.asyncToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.asyncToolStripMenuItem.Text = "Acync connect to DB";
            this.asyncToolStripMenuItem.Click += new System.EventHandler(this.asyncToolStripMenuItem_Click);
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            this.connectionListToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.connectionListToolStripMenuItem.Text = "Connection list";
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // buttonProductCount
            // 
            this.buttonProductCount.Location = new System.Drawing.Point(35, 47);
            this.buttonProductCount.Name = "buttonProductCount";
            this.buttonProductCount.Size = new System.Drawing.Size(97, 34);
            this.buttonProductCount.TabIndex = 1;
            this.buttonProductCount.Text = "Product Count Form";
            this.buttonProductCount.UseVisualStyleBackColor = true;
            this.buttonProductCount.Click += new System.EventHandler(this.buttonProductCount_Click);
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Location = new System.Drawing.Point(181, 58);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(0, 13);
            this.labelProductCount.TabIndex = 2;
            // 
            // buttonProductCountClass
            // 
            this.buttonProductCountClass.Location = new System.Drawing.Point(35, 111);
            this.buttonProductCountClass.Name = "buttonProductCountClass";
            this.buttonProductCountClass.Size = new System.Drawing.Size(97, 34);
            this.buttonProductCountClass.TabIndex = 3;
            this.buttonProductCountClass.Text = "Product Count Class";
            this.buttonProductCountClass.UseVisualStyleBackColor = true;
            this.buttonProductCountClass.Click += new System.EventHandler(this.buttonProductCountClass_Click);
            // 
            // labelProductCountClass
            // 
            this.labelProductCountClass.AutoSize = true;
            this.labelProductCountClass.Location = new System.Drawing.Point(179, 121);
            this.labelProductCountClass.Name = "labelProductCountClass";
            this.labelProductCountClass.Size = new System.Drawing.Size(0, 13);
            this.labelProductCountClass.TabIndex = 4;
            // 
            // listViewProductsList
            // 
            this.listViewProductsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductTitle,
            this.Price,
            this.Packing});
            this.listViewProductsList.HideSelection = false;
            this.listViewProductsList.Location = new System.Drawing.Point(45, 220);
            this.listViewProductsList.Name = "listViewProductsList";
            this.listViewProductsList.Size = new System.Drawing.Size(308, 97);
            this.listViewProductsList.TabIndex = 5;
            this.listViewProductsList.UseCompatibleStateImageBehavior = false;
            this.listViewProductsList.View = System.Windows.Forms.View.Details;
            // 
            // buttonPruductsList
            // 
            this.buttonPruductsList.Location = new System.Drawing.Point(35, 162);
            this.buttonPruductsList.Name = "buttonPruductsList";
            this.buttonPruductsList.Size = new System.Drawing.Size(97, 36);
            this.buttonPruductsList.TabIndex = 6;
            this.buttonPruductsList.Text = "Pruducts List";
            this.buttonPruductsList.UseVisualStyleBackColor = true;
            this.buttonPruductsList.Click += new System.EventHandler(this.buttonPruductsList_Click);
            // 
            // ProductTitle
            // 
            this.ProductTitle.Text = "Product Title";
            this.ProductTitle.Width = 130;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 86;
            // 
            // Packing
            // 
            this.Packing.Text = "Packing";
            this.Packing.Width = 147;
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.Location = new System.Drawing.Point(35, 353);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(97, 36);
            this.buttonTransaction.TabIndex = 7;
            this.buttonTransaction.Text = "Transaction";
            this.buttonTransaction.UseVisualStyleBackColor = true;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.buttonTransaction);
            this.Controls.Add(this.buttonPruductsList);
            this.Controls.Add(this.listViewProductsList);
            this.Controls.Add(this.labelProductCountClass);
            this.Controls.Add(this.buttonProductCountClass);
            this.Controls.Add(this.labelProductCount);
            this.Controls.Add(this.buttonProductCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDB";
            this.Text = "FormDBConnect";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionListToolStripMenuItem;
        private System.Windows.Forms.Button buttonProductCount;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.Button buttonProductCountClass;
        private System.Windows.Forms.Label labelProductCountClass;
        private System.Windows.Forms.ListView listViewProductsList;
        private System.Windows.Forms.ColumnHeader ProductTitle;
        private System.Windows.Forms.Button buttonPruductsList;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Packing;
        private System.Windows.Forms.Button buttonTransaction;
    }
}

