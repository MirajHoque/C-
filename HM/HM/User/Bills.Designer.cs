namespace HM.User
{
    partial class Bills
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
            this.lblFoodBills = new System.Windows.Forms.Label();
            this.lblBills = new System.Windows.Forms.Label();
            this.lblGetQty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFoodBills
            // 
            this.lblFoodBills.AutoSize = true;
            this.lblFoodBills.Location = new System.Drawing.Point(45, 162);
            this.lblFoodBills.Name = "lblFoodBills";
            this.lblFoodBills.Size = new System.Drawing.Size(52, 13);
            this.lblFoodBills.TabIndex = 0;
            this.lblFoodBills.Text = "Food Bills";
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.Location = new System.Drawing.Point(187, 162);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(34, 13);
            this.lblBills.TabIndex = 1;
            this.lblBills.Text = "00.00";
            // 
            // lblGetQty
            // 
            this.lblGetQty.AutoSize = true;
            this.lblGetQty.Location = new System.Drawing.Point(187, 111);
            this.lblGetQty.Name = "lblGetQty";
            this.lblGetQty.Size = new System.Drawing.Size(38, 13);
            this.lblGetQty.TabIndex = 3;
            this.lblGetQty.Text = "getQty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(187, 57);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "price";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(45, 57);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "Item Name";
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblGetQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBills);
            this.Controls.Add(this.lblFoodBills);
            this.Name = "Bills";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodBills;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Label lblGetQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemName;
    }
}