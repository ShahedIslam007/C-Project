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
    public partial class Sign_up_form : Form
    {
        public Sign_up_form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            create_account c = new create_account();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            create_account2 c2 = new create_account2();
            c2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            create_account3 c3 = new create_account3();
            c3.ShowDialog();
        }
    }
    }

