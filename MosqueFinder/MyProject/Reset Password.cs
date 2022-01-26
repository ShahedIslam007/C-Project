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
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Sign_in_form s1 = new Sign_in_form();
                this.Hide();
                s1.ShowDialog();
                Application.Exit();


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_form ss = new Sign_in_form();
            ss.ShowDialog(); 
        }
    }
}
