using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class recruiter : Form
    {
        public recruiter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideNav.Height = button1.Height;
            sideNav.Top = button1.Top;
            firstControler1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sideNav.Height = button2.Height;
            sideNav.Top = button2.Top;
            secondControler1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sideNav.Height = button3.Height;
            sideNav.Top = button3.Top;
            thirdControler1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sideNav.Height = button4.Height;
            sideNav.Top = button4.Top;
            fourthControler1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sideNav.Height = button5.Height;
            sideNav.Top = button5.Top;
            fifthControler1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sideNav.Height = button6.Height;
            sideNav.Top = button6.Top;
            sixthControler1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sideNav.Height = button7.Height;
            sideNav.Top = button7.Top;
            seventhControler1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_form s2 = new Sign_in_form();
            s2.ShowDialog();
        }
    }
}
