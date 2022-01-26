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
    public partial class applicant : Form
    {
        public applicant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideNav.Height = button1.Height;
            sideNav.Top = button1.Top;
            applicantUserControlerOne1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sideNav.Height = button9.Height;
            sideNav.Top = button9.Top;
            applicantControlerTwo1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sideNav.Height = button2.Height;
            sideNav.Top = button2.Top;
            applicantControlerThree1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sideNav.Height = button3.Height;
            sideNav.Top = button3.Top;
            applicantControlerFour1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sideNav.Height = button4.Height;
            sideNav.Top = button4.Top;
            applicantControlerFive1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sideNav.Height = button5.Height;
            sideNav.Top = button5.Top;
            applicantControlerSix1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sideNav.Height = button6.Height;
            sideNav.Top = button6.Top;
            applicantControlerSeven1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sideNav.Height = button7.Height;
            sideNav.Top = button7.Top;
            applicantControlerEight1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_form2 s3 = new Sign_in_form2();
            s3.ShowDialog();
        }
    }
}
