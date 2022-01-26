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
    public partial class FirstControler : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public FirstControler()
        {
            InitializeComponent();
        }

        void GridView()
        {
            //Connection Between GridView & Database
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Apply";
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Apply where ApplyAs=@ApplyAs and District=@District";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@District", comboBox2.Text);
            cmd.Parameters.AddWithValue("@ApplyAs", comboBox1.Text);

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
