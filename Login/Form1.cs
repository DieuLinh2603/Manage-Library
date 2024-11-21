using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        LVNDataContext dataContext = new LVNDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            button3.Visible = true;
            txtPass.UseSystemPasswordChar = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            txtPass.UseSystemPasswordChar = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
          
            System.Diagnostics.Process.Start("https://www.facebook.com/thuviendhqn");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://lib.qnu.edu.vn/");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.instagram.com/explore/locations/976795252400690/thu-vien-truong-ai-hoc-quy-nhon");
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
