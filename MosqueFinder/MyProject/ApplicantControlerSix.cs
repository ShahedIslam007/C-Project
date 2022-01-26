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
    public partial class ApplicantControlerSix : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public ApplicantControlerSix()
        {
            InitializeComponent();
        }

        void GridView()
        {
            //Connection Between GridView & Database
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Prayer_Time";
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
            string query = "select * from Prayer_Time where Day=@Day and Month=@Month";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Day",numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@Month", comboBox2.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                GridView();
            }
            else
            {
                MessageBox.Show("Data Not Found !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
