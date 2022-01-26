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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideNav.Height = button1.Height;
            sideNav.Top = button1.Top;
            adminControlerOne1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sideNav.Height = button9.Height;
            sideNav.Top = button9.Top;
            adminControlerTwo1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sideNav.Height = button2.Height;
            sideNav.Top = button2.Top;
            adminControlerThree1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sideNav.Height = button4.Height;
            sideNav.Top = button4.Top;
            adminControlerFour1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sideNav.Height = button7.Height;
            sideNav.Top = button7.Top;
            adminControlerFive1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sideNav.Height = button6.Height;
            sideNav.Top = button6.Top;
            adminControlerSix1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sideNav.Height = button5.Height;
            sideNav.Top = button5.Top;
            adminControlerSeven1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sideNav.Height = button3.Height;
            sideNav.Top = button3.Top;
            adminControlerEight1.BringToFront();
        }
    }
}
