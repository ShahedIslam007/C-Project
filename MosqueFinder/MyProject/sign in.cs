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
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
               Login l= new Login();
                this.Hide();
                l.ShowDialog();
                Application.Exit();


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Login l = new Login();
                this.Hide();
                l.ShowDialog();
                Application.Exit();


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_form s2 = new Sign_in_form();
            s2.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_form2 s3 = new Sign_in_form2();
            s3.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_form3 s4 = new Sign_in_form3();
            s4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_form4 s5 = new Sign_in_form4();
            s5.ShowDialog();
        }
    }
}
