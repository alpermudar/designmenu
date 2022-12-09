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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
