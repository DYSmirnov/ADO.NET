
namespace lab9.CM
{
    partial class CV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxCustomerList = new System.Windows.Forms.ComboBox();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.buttonSelectPhoto = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.groupBoxSelectData = new System.Windows.Forms.GroupBox();
            this.radioButtonOrders = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomers = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSelectData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxCustomerList
            // 
            this.comboBoxCustomerList.FormattingEnabled = true;
            this.comboBoxCustomerList.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCustomerList.Name = "comboBoxCustomerList";
            this.comboBoxCustomerList.Size = new System.Drawing.Size(157, 21);
            this.comboBoxCustomerList.TabIndex = 1;
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(12, 74);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.orderListBox.Size = new System.Drawing.Size(157, 121);
            this.orderListBox.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(201, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(201, 54);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(57, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "LastName";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(201, 91);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(41, 13);
            this.labelAdress.TabIndex = 5;
            this.labelAdress.Text = "Adress";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(201, 126);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(27, 13);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(201, 169);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(37, 13);
            this.labelPhoto.TabIndex = 7;
            this.labelPhoto.Text = "Photo";
            // 
            // buttonSelectPhoto
            // 
            this.buttonSelectPhoto.Location = new System.Drawing.Point(275, 161);
            this.buttonSelectPhoto.Name = "buttonSelectPhoto";
            this.buttonSelectPhoto.Size = new System.Drawing.Size(100, 34);
            this.buttonSelectPhoto.TabIndex = 8;
            this.buttonSelectPhoto.Text = "Select Photo";
            this.buttonSelectPhoto.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(275, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(275, 51);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(275, 88);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdress.TabIndex = 11;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(275, 123);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 12;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(628, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 23);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(628, 55);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(519, 19);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(87, 59);
            this.buttonShowData.TabIndex = 15;
            this.buttonShowData.Text = "Show Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(410, 19);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(87, 59);
            this.buttonAddData.TabIndex = 16;
            this.buttonAddData.Text = "Add Data";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // groupBoxSelectData
            // 
            this.groupBoxSelectData.Controls.Add(this.radioButtonOrders);
            this.groupBoxSelectData.Controls.Add(this.radioButtonCustomers);
            this.groupBoxSelectData.Location = new System.Drawing.Point(410, 91);
            this.groupBoxSelectData.Name = "groupBoxSelectData";
            this.groupBoxSelectData.Size = new System.Drawing.Size(328, 54);
            this.groupBoxSelectData.TabIndex = 17;
            this.groupBoxSelectData.TabStop = false;
            this.groupBoxSelectData.Text = "Select Data";
            // 
            // radioButtonOrders
            // 
            this.radioButtonOrders.AutoSize = true;
            this.radioButtonOrders.Location = new System.Drawing.Point(171, 21);
            this.radioButtonOrders.Name = "radioButtonOrders";
            this.radioButtonOrders.Size = new System.Drawing.Size(59, 17);
            this.radioButtonOrders.TabIndex = 1;
            this.radioButtonOrders.TabStop = true;
            this.radioButtonOrders.Text = "Orders";
            this.radioButtonOrders.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomers
            // 
            this.radioButtonCustomers.AutoSize = true;
            this.radioButtonCustomers.Location = new System.Drawing.Point(28, 22);
            this.radioButtonCustomers.Name = "radioButtonCustomers";
            this.radioButtonCustomers.Size = new System.Drawing.Size(79, 17);
            this.radioButtonCustomers.TabIndex = 0;
            this.radioButtonCustomers.TabStop = true;
            this.radioButtonCustomers.Text = "Customers";
            this.radioButtonCustomers.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(410, 178);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(506, 175);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(232, 22);
            this.textBoxID.TabIndex = 19;
            // 
            // CustomerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 447);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.groupBoxSelectData);
            this.Controls.Add(this.buttonAddData);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSelectPhoto);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.comboBoxCustomerList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerViewer";
            this.Text = "CustomerViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSelectData.ResumeLayout(false);
            this.groupBoxSelectData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxCustomerList;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Button buttonSelectPhoto;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.GroupBox groupBoxSelectData;
        private System.Windows.Forms.RadioButton radioButtonOrders;
        private System.Windows.Forms.RadioButton radioButtonCustomers;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
    }
}

