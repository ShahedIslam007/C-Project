using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MyProject
{
    public partial class Sign_in_form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Sign_in_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                sign_in ss1 = new sign_in();
                this.Hide();
                ss1.ShowDialog();
                Application.Exit();


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset_Password r = new Reset_Password();
            r.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;

                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Recruiter_SignUp where Username=@name and Password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows == true)
            {
                MessageBox.Show("Login Successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                recruiter r = new recruiter();
                r.ShowDialog();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password","Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            con.Close();
            
        }

    }
}
