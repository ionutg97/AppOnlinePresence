using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie2
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            hidePanelsbuton();
        }

        private void textBox1_GotFocussign(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void textBox1_Leavesign(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_GotFocussign(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.DarkGray;

            }
        }

        private void textBox2_Leavesign(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
            }
        }
        public void hidePanelsbuton()
        {
            panel2.Visible = false;
        }

        private void radiobtn(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }
    }
}
