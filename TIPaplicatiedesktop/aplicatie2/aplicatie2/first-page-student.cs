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
        private bool isCollapsed;
        int t1 = 41;
        public first_page_student()
        {
            InitializeComponent();
        }

        private void hover1(object sender, EventArgs e)
        {
        }

        private void first_page_student_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panel11.Height += 43;
                if(panel11.Size==panel11.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
                else
                {
                    panel11.Height -= 43;
                    if (panel11.Size == panel11.MinimumSize)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
