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
    public partial class GeneralControlerSix : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public GeneralControlerSix()
        {
            InitializeComponent();
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into General_Pofile values(@Name,@Email,@Phone,@Address,@District,@Area,@Picture)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Address", textBox2.Text);
            cmd.Parameters.AddWithValue("@District", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Area", textBox1.Text);
            cmd.Parameters.AddWithValue("@Picture", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Informations Submited Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Information Submition Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
