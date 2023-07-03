using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinensSinemalariOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kontrol_11_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           kontrol1.Show();
            kontrol_11.Hide();
            kontrol_21.Hide();
            kontrol1.BringToFront();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol1.Show();
            kontrol_11.Hide();
            kontrol_21.Hide();
            kontrol1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrol1.Hide();
            kontrol_11.Show();
            kontrol_21.Hide();
            kontrol_11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontrol1.Hide();
            kontrol_11.Hide();
            kontrol_21.Show();
            kontrol_21.BringToFront();
        }

        private void kontrol1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void kontrol_21_Load(object sender, EventArgs e)
        {

        }
    }
}
