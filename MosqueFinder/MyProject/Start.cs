using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar2.Value = startpoint;
            if (progressBar2.Value == 100)
            {
                progressBar2.Value = 0;
                timer1.Stop();
                Login f = new Login();
                this.Hide();
                f.Show();
            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

      
    }
}
