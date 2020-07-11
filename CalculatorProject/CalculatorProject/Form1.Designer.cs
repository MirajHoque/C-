namespace CalculatorProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_mod = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox3_output = new System.Windows.Forms.TextBox();
            this.textBox2_input = new System.Windows.Forms.TextBox();
            this.textBox1_input = new System.Windows.Forms.TextBox();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_sum = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.button_mod);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.textBox3_output);
            this.panel1.Controls.Add(this.textBox2_input);
            this.panel1.Controls.Add(this.textBox1_input);
            this.panel1.Controls.Add(this.button_div);
            this.panel1.Controls.Add(this.button_mul);
            this.panel1.Controls.Add(this.button_sub);
            this.panel1.Controls.Add(this.button_sum);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 476);
            this.panel1.TabIndex = 0;
            // 
            // button_mod
            // 
            this.button_mod.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mod.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_mod.Location = new System.Drawing.Point(34, 427);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(75, 31);
            this.button_mod.TabIndex = 8;
            this.button_mod.Text = "MOD";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_clear.Location = new System.Drawing.Point(193, 427);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 31);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox3_output
            // 
            this.textBox3_output.Location = new System.Drawing.Point(34, 190);
            this.textBox3_output.Name = "textBox3_output";
            this.textBox3_output.Size = new System.Drawing.Size(234, 20);
            this.textBox3_output.TabIndex = 6;
            // 
            // textBox2_input
            // 
            this.textBox2_input.Location = new System.Drawing.Point(34, 110);
            this.textBox2_input.Name = "textBox2_input";
            this.textBox2_input.Size = new System.Drawing.Size(234, 20);
            this.textBox2_input.TabIndex = 5;
            // 
            // textBox1_input
            // 
            this.textBox1_input.Location = new System.Drawing.Point(34, 27);
            this.textBox1_input.Name = "textBox1_input";
            this.textBox1_input.Size = new System.Drawing.Size(234, 20);
            this.textBox1_input.TabIndex = 4;
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_div.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_div.Location = new System.Drawing.Point(193, 352);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(75, 32);
            this.button_div.TabIndex = 3;
            this.button_div.Text = "DIV";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_mul
            // 
            this.button_mul.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mul.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_mul.Location = new System.Drawing.Point(34, 352);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(75, 32);
            this.button_mul.TabIndex = 2;
            this.button_mul.Text = "MUL";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sub.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_sub.Location = new System.Drawing.Point(193, 267);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(75, 30);
            this.button_sub.TabIndex = 1;
            this.button_sub.Text = "SUB";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_sum
            // 
            this.button_sum.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sum.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_sum.Location = new System.Drawing.Point(34, 267);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(75, 30);
            this.button_sum.TabIndex = 0;
            this.button_sum.Text = "SUM";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 500);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2_input;
        private System.Windows.Forms.TextBox textBox1_input;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.TextBox textBox3_output;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_mod;
    }
}

