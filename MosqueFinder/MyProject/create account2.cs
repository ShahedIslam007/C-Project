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
using System.IO;

namespace MyProject
{
    public partial class create_account2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public create_account2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Applicant_SignUp values(@name,@email,@phone,@addr,@district,@area,@pass,@img)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@addr", textBox4.Text);
            cmd.Parameters.AddWithValue("@district", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@area", textBox7.Text);
            cmd.Parameters.AddWithValue("@pass", textBox6.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Account Created Successfully");
                this.Hide();
                Sign_in_form2 s2 = new Sign_in_form2();
                s2.ShowDialog();
            }

            else
            {
                MessageBox.Show("Failed!!");
            }
            con.Close();

        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Sign_up_form ss = new Sign_up_form();
                this.Hide();
                ss.ShowDialog();
                Application.Exit();


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; .bmp)|.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
    }
}
