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
    public partial class Reset_Password4 : Form
    {
        public Reset_Password4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_form4 ss4 = new Sign_in_form4();
            ss4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Sign_in_form4 ss4 = new Sign_in_form4();
                this.Hide();
                ss4.ShowDialog();
                Application.Exit();


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
