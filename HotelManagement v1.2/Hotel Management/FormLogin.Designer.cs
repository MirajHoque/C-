namespace Hotel_Management
{
    partial class FormLogin
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtLoginPass = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginUserName = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelWelcome = new MetroFramework.Controls.MetroLabel();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.comboBoxLogin);
            this.metroPanel1.Controls.Add(this.txtLoginPass);
            this.metroPanel1.Controls.Add(this.txtLoginUserName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(78, 119);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(620, 384);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtLoginPass
            // 
            // 
            // 
            // 
            this.txtLoginPass.CustomButton.Image = null;
            this.txtLoginPass.CustomButton.Location = new System.Drawing.Point(314, 2);
            this.txtLoginPass.CustomButton.Name = "";
            this.txtLoginPass.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtLoginPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginPass.CustomButton.TabIndex = 1;
            this.txtLoginPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginPass.CustomButton.UseSelectable = true;
            this.txtLoginPass.CustomButton.Visible = false;
            this.txtLoginPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLoginPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtLoginPass.Lines = new string[0];
            this.txtLoginPass.Location = new System.Drawing.Point(212, 127);
            this.txtLoginPass.MaxLength = 32767;
            this.txtLoginPass.Multiline = true;
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.PasswordChar = '\0';
            this.txtLoginPass.PromptText = "Enter Password";
            this.txtLoginPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginPass.SelectedText = "";
            this.txtLoginPass.SelectionLength = 0;
            this.txtLoginPass.SelectionStart = 0;
            this.txtLoginPass.ShortcutsEnabled = true;
            this.txtLoginPass.Size = new System.Drawing.Size(348, 36);
            this.txtLoginPass.TabIndex = 3;
            this.txtLoginPass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginPass.UseSelectable = true;
            this.txtLoginPass.WaterMark = "Enter Password";
            this.txtLoginPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLoginUserName
            // 
            // 
            // 
            // 
            this.txtLoginUserName.CustomButton.Image = null;
            this.txtLoginUserName.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.txtLoginUserName.CustomButton.Name = "";
            this.txtLoginUserName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtLoginUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginUserName.CustomButton.TabIndex = 1;
            this.txtLoginUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginUserName.CustomButton.UseSelectable = true;
            this.txtLoginUserName.CustomButton.Visible = false;
            this.txtLoginUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLoginUserName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtLoginUserName.Lines = new string[0];
            this.txtLoginUserName.Location = new System.Drawing.Point(212, 25);
            this.txtLoginUserName.MaxLength = 32767;
            this.txtLoginUserName.Multiline = true;
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.PasswordChar = '\0';
            this.txtLoginUserName.PromptText = "Enter User Name";
            this.txtLoginUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginUserName.SelectedText = "";
            this.txtLoginUserName.SelectionLength = 0;
            this.txtLoginUserName.SelectionStart = 0;
            this.txtLoginUserName.ShortcutsEnabled = true;
            this.txtLoginUserName.Size = new System.Drawing.Size(348, 33);
            this.txtLoginUserName.TabIndex = 2;
            this.txtLoginUserName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginUserName.UseSelectable = true;
            this.txtLoginUserName.WaterMark = "Enter User Name";
            this.txtLoginUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClear.Location = new System.Drawing.Point(482, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 51);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.Location = new System.Drawing.Point(290, 354);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 51);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(135, 246);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 25);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Password:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(45, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "User Name:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelWelcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelWelcome.Location = new System.Drawing.Point(261, 531);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(247, 25);
            this.labelWelcome.TabIndex = 15;
            this.labelWelcome.Text = "Welcome to Hotel Radison";
            // 
            // timerLogin
            // 
            this.timerLogin.Tick += new System.EventHandler(this.timerLogin_Tick);
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Items.AddRange(new object[] {
            "Admin",
            "Receptionist"});
            this.comboBoxLogin.Location = new System.Drawing.Point(439, 81);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLogin.TabIndex = 10;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 593);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLoginPass;
        private MetroFramework.Controls.MetroTextBox txtLoginUserName;
        private MetroFramework.Controls.MetroLabel labelWelcome;
        private System.Windows.Forms.Timer timerLogin;
        private System.Windows.Forms.ComboBox comboBoxLogin;
    }
}

