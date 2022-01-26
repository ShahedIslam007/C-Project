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
    public partial class AdminControlerFour : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminControlerFour()
        {
            InitializeComponent();
            GridView();
        }

        private void ResetData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        void GridView()
        {
            //Connection Between GridView & Database
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from doners_One";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //Data in GridView
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();   
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into doners_One values(@Name,@District,@Area,@Mosque,@Amount,@Via)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@District", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Area", textBox2.Text);
            cmd.Parameters.AddWithValue("@Mosque", textBox4.Text);
            cmd.Parameters.AddWithValue("@Amount", textBox3.Text);
            cmd.Parameters.AddWithValue("@Via", comboBox1.Text);

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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update doners_One set Name=@Name, District=@District, Area=@Area, Mosque=@Mosque, Amount=@Amount, Via=@Via where Name=@Name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@District", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@Area", textBox2.Text);
            cmd.Parameters.AddWithValue("@Mosque", textBox4.Text);
            cmd.Parameters.AddWithValue("@Amount", textBox3.Text);
            cmd.Parameters.AddWithValue("@Via", comboBox1.SelectedItem);

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
            string query = "delete from doners_One where Name=@Name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);

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
