namespace logInMetroUI
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
            this.lvlId = new System.Windows.Forms.Label();
            this.lvlPassword = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvlId
            // 
            this.lvlId.AutoSize = true;
            this.lvlId.Location = new System.Drawing.Point(63, 87);
            this.lvlId.Name = "lvlId";
            this.lvlId.Size = new System.Drawing.Size(18, 13);
            this.lvlId.TabIndex = 0;
            this.lvlId.Text = "ID";
            // 
            // lvlPassword
            // 
            this.lvlPassword.AutoSize = true;
            this.lvlPassword.Location = new System.Drawing.Point(63, 114);
            this.lvlPassword.Name = "lvlPassword";
            this.lvlPassword.Size = new System.Drawing.Size(53, 13);
            this.lvlPassword.TabIndex = 1;
            this.lvlPassword.Text = "Password";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(158, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(183, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(158, 156);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(83, 36);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 288);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lvlPassword);
            this.Controls.Add(this.lvlId);
            this.Name = "Form1";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlId;
        private System.Windows.Forms.Label lvlPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnLogIn;
    }
}

