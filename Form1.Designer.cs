namespace dbInformation
{
    partial class Information
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
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lvlCountry = new System.Windows.Forms.Label();
            this.lvlCity = new System.Windows.Forms.Label();
            this.lvlName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnldgv = new System.Windows.Forms.Panel();
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.panelUserInfo.SuspendLayout();
            this.pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.btnUpdate);
            this.panelUserInfo.Controls.Add(this.btnDelete);
            this.panelUserInfo.Controls.Add(this.btnDisplay);
            this.panelUserInfo.Controls.Add(this.button2);
            this.panelUserInfo.Controls.Add(this.btnInsert);
            this.panelUserInfo.Controls.Add(this.txtCity);
            this.panelUserInfo.Controls.Add(this.txtCountry);
            this.panelUserInfo.Controls.Add(this.txtName);
            this.panelUserInfo.Controls.Add(this.lvlCountry);
            this.panelUserInfo.Controls.Add(this.lvlCity);
            this.panelUserInfo.Controls.Add(this.lvlName);
            this.panelUserInfo.Location = new System.Drawing.Point(12, 27);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(369, 293);
            this.panelUserInfo.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(84, 192);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(161, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(231, 192);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(49, 23);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(18, 192);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(49, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(149, 67);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(149, 120);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lvlCountry
            // 
            this.lvlCountry.AutoSize = true;
            this.lvlCountry.Location = new System.Drawing.Point(71, 120);
            this.lvlCountry.Name = "lvlCountry";
            this.lvlCountry.Size = new System.Drawing.Size(43, 13);
            this.lvlCountry.TabIndex = 2;
            this.lvlCountry.Text = "Country";
            // 
            // lvlCity
            // 
            this.lvlCity.AutoSize = true;
            this.lvlCity.Location = new System.Drawing.Point(71, 74);
            this.lvlCity.Name = "lvlCity";
            this.lvlCity.Size = new System.Drawing.Size(24, 13);
            this.lvlCity.TabIndex = 1;
            this.lvlCity.Text = "City";
            // 
            // lvlName
            // 
            this.lvlName.AutoSize = true;
            this.lvlName.Location = new System.Drawing.Point(71, 22);
            this.lvlName.Name = "lvlName";
            this.lvlName.Size = new System.Drawing.Size(35, 13);
            this.lvlName.TabIndex = 0;
            this.lvlName.Text = "Name";
            // 
            // pnldgv
            // 
            this.pnldgv.Controls.Add(this.dgvinfo);
            this.pnldgv.Location = new System.Drawing.Point(399, 27);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(430, 293);
            this.pnldgv.TabIndex = 1;
            // 
            // dgvinfo
            // 
            this.dgvinfo.AllowUserToAddRows = false;
            this.dgvinfo.AllowUserToDeleteRows = false;
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Location = new System.Drawing.Point(17, 3);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.ReadOnly = true;
            this.dgvinfo.Size = new System.Drawing.Size(410, 275);
            this.dgvinfo.TabIndex = 0;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 511);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.panelUserInfo);
            this.Name = "Information";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Information_Load);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnldgv;
        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lvlCountry;
        private System.Windows.Forms.Label lvlCity;
        private System.Windows.Forms.Label lvlName;
    }
}

