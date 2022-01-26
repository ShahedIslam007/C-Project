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
    public partial class Sign_in_form3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Sign_in_form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                sign_in l = new sign_in();
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
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from General_SignUp where Username=@name and Password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                general g = new general();
                g.ShowDialog();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset_Password3 r3 = new Reset_Password3();
            r3.ShowDialog();
        }
    }
}
