namespace LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.lblPasswordShow = new System.Windows.Forms.Label();
            this.lblUsernameShow = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.pnlShow);
            this.panelLogin.Controls.Add(this.btnClear);
            this.panelLogin.Controls.Add(this.btnLogIn);
            this.panelLogin.Controls.Add(this.txPassword);
            this.panelLogin.Controls.Add(this.txName);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.lblName);
            this.panelLogin.Location = new System.Drawing.Point(201, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(446, 334);
            this.panelLogin.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(66, 81);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(167, 37);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(153, 20);
            this.txName.TabIndex = 2;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(167, 81);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(153, 20);
            this.txPassword.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(167, 138);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(257, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.Controls.Add(this.lblUsernameShow);
            this.pnlShow.Controls.Add(this.lblPasswordShow);
            this.pnlShow.Location = new System.Drawing.Point(167, 200);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(165, 113);
            this.pnlShow.TabIndex = 7;
            this.pnlShow.Visible = false;
            // 
            // lblPasswordShow
            // 
            this.lblPasswordShow.AutoSize = true;
            this.lblPasswordShow.Location = new System.Drawing.Point(18, 48);
            this.lblPasswordShow.Name = "lblPasswordShow";
            this.lblPasswordShow.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordShow.TabIndex = 1;
            this.lblPasswordShow.Text = "Password";
            // 
            // lblUsernameShow
            // 
            this.lblUsernameShow.AutoSize = true;
            this.lblUsernameShow.Location = new System.Drawing.Point(18, 19);
            this.lblUsernameShow.Name = "lblUsernameShow";
            this.lblUsernameShow.Size = new System.Drawing.Size(57, 13);
            this.lblUsernameShow.TabIndex = 2;
            this.lblUsernameShow.Text = "UserName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 416);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LOGINFROM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.pnlShow.ResumeLayout(false);
            this.pnlShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Label lblUsernameShow;
        private System.Windows.Forms.Label lblPasswordShow;
    }
}

