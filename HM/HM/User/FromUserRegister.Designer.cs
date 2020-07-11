namespace HM.User
{
    partial class FromUserRegister
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.lvlRoomNo = new System.Windows.Forms.Label();
            this.btntotalprice = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxUserRegRole = new System.Windows.Forms.ComboBox();
            this.dateTimePickerUserReg = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserRegEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserRegAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserRegPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserRegUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserRegName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUserRegister = new System.Windows.Forms.DataGridView();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderUserReg = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserReg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxRoom);
            this.panel1.Controls.Add(this.lvlRoomNo);
            this.panel1.Controls.Add(this.btntotalprice);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtItem);
            this.panel1.Controls.Add(this.btnPrice);
            this.panel1.Controls.Add(this.btnQuantity);
            this.panel1.Controls.Add(this.btnItem);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.comboBoxUserRegRole);
            this.panel1.Controls.Add(this.dateTimePickerUserReg);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUserRegEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUserRegAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUserRegPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUserRegUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserRegName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 413);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "101",
            "102",
            "103"});
            this.comboBoxRoom.Location = new System.Drawing.Point(240, 304);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoom.TabIndex = 27;
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            // 
            // lvlRoomNo
            // 
            this.lvlRoomNo.AutoSize = true;
            this.lvlRoomNo.Location = new System.Drawing.Point(174, 304);
            this.lvlRoomNo.Name = "lvlRoomNo";
            this.lvlRoomNo.Size = new System.Drawing.Size(52, 13);
            this.lvlRoomNo.TabIndex = 26;
            this.lvlRoomNo.Text = "Room No";
            // 
            // btntotalprice
            // 
            this.btntotalprice.Location = new System.Drawing.Point(14, 288);
            this.btntotalprice.Margin = new System.Windows.Forms.Padding(2);
            this.btntotalprice.Name = "btntotalprice";
            this.btntotalprice.Size = new System.Drawing.Size(103, 30);
            this.btntotalprice.TabIndex = 21;
            this.btntotalprice.Text = "Total Price";
            this.btntotalprice.UseVisualStyleBackColor = true;
            this.btntotalprice.Click += new System.EventHandler(this.btntotalprice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(666, 247);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(103, 20);
            this.txtPrice.TabIndex = 25;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(403, 249);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(103, 20);
            this.txtQuantity.TabIndex = 24;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(146, 247);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(103, 20);
            this.txtItem.TabIndex = 23;
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(541, 241);
            this.btnPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(103, 30);
            this.btnPrice.TabIndex = 22;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            // 
            // btnQuantity
            // 
            this.btnQuantity.Location = new System.Drawing.Point(278, 243);
            this.btnQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(103, 30);
            this.btnQuantity.TabIndex = 21;
            this.btnQuantity.Text = "Quantity";
            this.btnQuantity.UseVisualStyleBackColor = true;
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(14, 243);
            this.btnItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(103, 30);
            this.btnItem.TabIndex = 20;
            this.btnItem.Text = "Item";
            this.btnItem.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(609, 194);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 188);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 30);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(357, 188);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(231, 188);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 30);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 188);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 30);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxUserRegRole
            // 
            this.comboBoxUserRegRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserRegRole.FormattingEnabled = true;
            this.comboBoxUserRegRole.Items.AddRange(new object[] {
            "Admin",
            "Super Admin",
            "User"});
            this.comboBoxUserRegRole.Location = new System.Drawing.Point(491, 92);
            this.comboBoxUserRegRole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUserRegRole.Name = "comboBoxUserRegRole";
            this.comboBoxUserRegRole.Size = new System.Drawing.Size(218, 21);
            this.comboBoxUserRegRole.TabIndex = 14;
            // 
            // dateTimePickerUserReg
            // 
            this.dateTimePickerUserReg.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerUserReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerUserReg.Location = new System.Drawing.Point(491, 60);
            this.dateTimePickerUserReg.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerUserReg.Name = "dateTimePickerUserReg";
            this.dateTimePickerUserReg.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerUserReg.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth";
            // 
            // txtUserRegEmail
            // 
            this.txtUserRegEmail.Location = new System.Drawing.Point(491, 22);
            this.txtUserRegEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserRegEmail.Name = "txtUserRegEmail";
            this.txtUserRegEmail.Size = new System.Drawing.Size(218, 20);
            this.txtUserRegEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // txtUserRegAddress
            // 
            this.txtUserRegAddress.Location = new System.Drawing.Point(107, 122);
            this.txtUserRegAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserRegAddress.Multiline = true;
            this.txtUserRegAddress.Name = "txtUserRegAddress";
            this.txtUserRegAddress.Size = new System.Drawing.Size(602, 54);
            this.txtUserRegAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // txtUserRegPass
            // 
            this.txtUserRegPass.Location = new System.Drawing.Point(107, 89);
            this.txtUserRegPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserRegPass.Name = "txtUserRegPass";
            this.txtUserRegPass.Size = new System.Drawing.Size(218, 20);
            this.txtUserRegPass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtUserRegUserName
            // 
            this.txtUserRegUserName.Location = new System.Drawing.Point(107, 55);
            this.txtUserRegUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserRegUserName.Name = "txtUserRegUserName";
            this.txtUserRegUserName.Size = new System.Drawing.Size(218, 20);
            this.txtUserRegUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // txtUserRegName
            // 
            this.txtUserRegName.Location = new System.Drawing.Point(107, 22);
            this.txtUserRegName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserRegName.Name = "txtUserRegName";
            this.txtUserRegName.Size = new System.Drawing.Size(218, 20);
            this.txtUserRegName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dataGridViewUserRegister
            // 
            this.dataGridViewUserRegister.AllowUserToAddRows = false;
            this.dataGridViewUserRegister.AllowUserToDeleteRows = false;
            this.dataGridViewUserRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgName,
            this.dgDOB,
            this.dgEmail,
            this.dgUserName,
            this.dgRole,
            this.dgAddress});
            this.dataGridViewUserRegister.Location = new System.Drawing.Point(40, 481);
            this.dataGridViewUserRegister.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUserRegister.Name = "dataGridViewUserRegister";
            this.dataGridViewUserRegister.ReadOnly = true;
            this.dataGridViewUserRegister.RowTemplate.Height = 24;
            this.dataGridViewUserRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserRegister.Size = new System.Drawing.Size(790, 170);
            this.dataGridViewUserRegister.TabIndex = 1;
            this.dataGridViewUserRegister.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUserRegister_MouseDoubleClick);
            // 
            // dgSno
            // 
            this.dgSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgSno.HeaderText = "SNo";
            this.dgSno.Name = "dgSno";
            this.dgSno.ReadOnly = true;
            // 
            // dgName
            // 
            this.dgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgDOB
            // 
            this.dgDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDOB.HeaderText = "DOB";
            this.dgDOB.Name = "dgDOB";
            this.dgDOB.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // dgUserName
            // 
            this.dgUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgUserName.HeaderText = "UserName";
            this.dgUserName.Name = "dgUserName";
            this.dgUserName.ReadOnly = true;
            // 
            // dgRole
            // 
            this.dgRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgRole.HeaderText = "Role";
            this.dgRole.Name = "dgRole";
            this.dgRole.ReadOnly = true;
            // 
            // dgAddress
            // 
            this.dgAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            // 
            // errorProviderUserReg
            // 
            this.errorProviderUserReg.ContainerControl = this;
            // 
            // FromUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 628);
            this.Controls.Add(this.dataGridViewUserRegister);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FromUserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Register";
            this.Load += new System.EventHandler(this.FromUserRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxUserRegRole;
        private System.Windows.Forms.DateTimePicker dateTimePickerUserReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserRegEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserRegAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserRegPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserRegUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserRegName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewUserRegister;
        private System.Windows.Forms.ErrorProvider errorProviderUserReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btntotalprice;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label lvlRoomNo;
    }
}