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
    public partial class AdminControlerThree : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminControlerThree()
        {
            InitializeComponent();
            GridView();
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

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Generals values(@name,@email,@phone,@addr,@district,@area,@img)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox5.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@addr", textBox2.Text);
            cmd.Parameters.AddWithValue("@district", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@area", textBox1.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Informations Inserted Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridView();
                ResetData();
            }
            else
            {
                MessageBox.Show("Information Insertion Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        void GridView()
        {
            //Connection Between GridView & Database
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Generals";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //Data in GridView
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            //Image Column
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[6];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //Auto Size
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Image Row Height
            dataGridView1.RowTemplate.Height = 60;
        }

        private void ResetData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.Refresh();
            pictureBox1.Image = Properties.Resources.profile_icon_34378;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[6].Value);
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update Generals set Name=@name, Email=@email, Phone=@phone, Address=@addr, District=@district, Area=@area, Picture=@img where Name=@name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox5.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@addr", textBox2.Text);
            cmd.Parameters.AddWithValue("@district", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@area", textBox1.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Informations Updated Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridView();
                ResetData();
            }
            else
            {
                MessageBox.Show("Information Updation Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from Generals where Name=@name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox5.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Informations Deleted Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridView();
                ResetData();
            }
            else
            {
                MessageBox.Show("Information Deletion Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
