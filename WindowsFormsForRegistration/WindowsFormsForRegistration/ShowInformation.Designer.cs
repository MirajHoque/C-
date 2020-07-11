namespace WindowsFormsForRegistration
{
    partial class ShowInformation
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
            this.pnlShow = new System.Windows.Forms.Panel();
            this.lblSGender = new System.Windows.Forms.Label();
            this.lblSBloodGroup = new System.Windows.Forms.Label();
            this.lblSSalary = new System.Windows.Forms.Label();
            this.lblSDOB = new System.Windows.Forms.Label();
            this.lBLSName = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShow
            // 
            this.pnlShow.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlShow.Controls.Add(this.lblAge);
            this.pnlShow.Controls.Add(this.lblTax);
            this.pnlShow.Controls.Add(this.btnBack);
            this.pnlShow.Controls.Add(this.lblSGender);
            this.pnlShow.Controls.Add(this.lblSBloodGroup);
            this.pnlShow.Controls.Add(this.lblSSalary);
            this.pnlShow.Controls.Add(this.lblSDOB);
            this.pnlShow.Controls.Add(this.lBLSName);
            this.pnlShow.Controls.Add(this.lblSID);
            this.pnlShow.Location = new System.Drawing.Point(45, 22);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(357, 365);
            this.pnlShow.TabIndex = 0;
            // 
            // lblSGender
            // 
            this.lblSGender.AutoSize = true;
            this.lblSGender.Location = new System.Drawing.Point(16, 206);
            this.lblSGender.Name = "lblSGender";
            this.lblSGender.Size = new System.Drawing.Size(42, 13);
            this.lblSGender.TabIndex = 13;
            this.lblSGender.Text = "Gender";
            // 
            // lblSBloodGroup
            // 
            this.lblSBloodGroup.AutoSize = true;
            this.lblSBloodGroup.Location = new System.Drawing.Point(16, 168);
            this.lblSBloodGroup.Name = "lblSBloodGroup";
            this.lblSBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lblSBloodGroup.TabIndex = 12;
            this.lblSBloodGroup.Text = "Blood Group";
            // 
            // lblSSalary
            // 
            this.lblSSalary.AutoSize = true;
            this.lblSSalary.Location = new System.Drawing.Point(16, 132);
            this.lblSSalary.Name = "lblSSalary";
            this.lblSSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSSalary.TabIndex = 11;
            this.lblSSalary.Text = "Salary";
            // 
            // lblSDOB
            // 
            this.lblSDOB.AutoSize = true;
            this.lblSDOB.Location = new System.Drawing.Point(16, 90);
            this.lblSDOB.Name = "lblSDOB";
            this.lblSDOB.Size = new System.Drawing.Size(68, 13);
            this.lblSDOB.TabIndex = 10;
            this.lblSDOB.Text = "Date Of Birth";
            // 
            // lBLSName
            // 
            this.lBLSName.AutoSize = true;
            this.lBLSName.Location = new System.Drawing.Point(16, 47);
            this.lBLSName.Name = "lBLSName";
            this.lBLSName.Size = new System.Drawing.Size(35, 13);
            this.lBLSName.TabIndex = 9;
            this.lBLSName.Text = "Name";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(16, 14);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(18, 13);
            this.lblSID.TabIndex = 8;
            this.lblSID.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(19, 319);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(19, 246);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 15;
            this.lblTax.Text = "Tax";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(19, 280);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "Age";
            // 
            // ShowInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 413);
            this.Controls.Add(this.pnlShow);
            this.Name = "ShowInformation";
            this.Text = "ShowInformation";
            this.pnlShow.ResumeLayout(false);
            this.pnlShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSGender;
        private System.Windows.Forms.Label lblSBloodGroup;
        private System.Windows.Forms.Label lblSSalary;
        private System.Windows.Forms.Label lblSDOB;
        private System.Windows.Forms.Label lBLSName;
        private System.Windows.Forms.Label lblSID;
    }
}