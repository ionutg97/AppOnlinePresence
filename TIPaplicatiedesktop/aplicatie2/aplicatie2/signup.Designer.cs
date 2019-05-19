namespace aplicatie2
{
    partial class signup
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(523, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "SIGN-UP";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.Location = new System.Drawing.Point(450, 344);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 31);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Password";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_GotFocussign);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leavesign);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Location = new System.Drawing.Point(450, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 31);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Username";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_GotFocussign);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leavesign);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(464, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 66);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sign-up";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(450, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 26);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "User Account";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_Changed);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(595, 187);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(168, 26);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Teacher Account";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_Changed);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(415, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 63);
            this.panel1.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox3.Location = new System.Drawing.Point(34, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(276, 31);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Confirm Password";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(436, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 141);
            this.panel2.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox5.Location = new System.Drawing.Point(14, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 31);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "Full Name";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox4.Location = new System.Drawing.Point(14, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 31);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "Confirm Password";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "signup";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}