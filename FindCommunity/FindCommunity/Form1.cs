using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindCommunity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.95;

        }

        private void siticoneCirclePictureBox4_Click(object sender, EventArgs e)
        {
            siticonePanel3.Visible = true;
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {

            siticonePanel1.Visible = true;
        }

        private void siticoneCirclePictureBox3_Click(object sender, EventArgs e)
        {

            siticonePanel2.Visible = true;
        }

        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {

            siticonePanel4.Visible = true;
        }

        private void siticoneHtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCircleButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneCircleButton2_DoubleClick(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Normal;
        }
    }
}
