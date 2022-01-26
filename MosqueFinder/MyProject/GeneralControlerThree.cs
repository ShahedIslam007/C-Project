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
    public partial class GeneralControlerThree : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public GeneralControlerThree()
        {
            InitializeComponent();
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

            //Auto Size
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
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
                GridView();
            }
            else
            {
                MessageBox.Show("Information Insertion Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
