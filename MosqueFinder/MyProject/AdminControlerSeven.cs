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
    public partial class AdminControlerSeven : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminControlerSeven()
        {
            InitializeComponent();
            GridView();
        }

        void GridView()
        {
            //Connection Between GridView & Database
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Nearby_Mosque";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //Data in GridView
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            //Auto Size
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ResetData()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox2.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Nearby_Mosque values(@Name,@District,@Area)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@District", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Area", textBox1.Text);

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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update Nearby_Mosque set Name=@Name, District=@District, Area=@Area where Name=@Name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@District", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Area", textBox1.Text);

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
            string query = "delete from Nearby_Mosque where Name=@Name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);

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

        private void button5_Click(object sender, EventArgs e)
        {
            ResetData();
        }
    }
}
