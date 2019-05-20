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
    public partial class first_page_student : Form
    {
        int t1 = 40;
        int t2 = 40;
        int t4 = 40;
        public first_page_student()
        {
            InitializeComponent();
           hidePanelsbuton();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.panel11.Size = new Size(this.panel11.Size.Width, t4);
            timer1.Start();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            t1 = 40;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(t1>255)
            {
                timer1.Stop();
            }
            else
            {
                this.panel11.Size = new Size(this.panel11.Size.Width, t1);
                t1 += 5;
            }
        }
        public void hidePanelsbuton()
        {
            panel4.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }
    }
}
