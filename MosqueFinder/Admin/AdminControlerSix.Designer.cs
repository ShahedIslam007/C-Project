
namespace MyProject
{
    partial class AdminControlerSix
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(278, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "All Hadiths Information";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Salat",
            "Ramadan",
            "Hajj",
            "Jakat",
            "Ikram-e-muslim",
            "Takoa",
            "Akhlak",
            "Jannat",
            "Jahannam",
            "Death"});
            this.comboBox2.Location = new System.Drawing.Point(149, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 31);
            this.comboBox2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hadiths Topic";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(149, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 157);
            this.textBox1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hadith";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 278);
            this.dataGridView1.TabIndex = 35;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(491, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 40);
            this.button5.TabIndex = 121;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(351, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 40);
            this.button4.TabIndex = 122;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(212, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 40);
            this.button3.TabIndex = 120;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(68, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 119;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AdminControlerSix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminControlerSix";
            this.Size = new System.Drawing.Size(951, 499);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}
