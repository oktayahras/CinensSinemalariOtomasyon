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
    public partial class Kontrol_2 : UserControl
    {
        public Kontrol_2()
        {
            InitializeComponent();
        }
        int sivil = 0;
        int fiyat = 0;
        int öğrenci = 0;
        int öğrencifiyat = 0;
        int mısır = 0;
        int mısırfiyat = 0;
        int kola = 0;
        int kolafiyat = 0;
        int su = 0;
        int sufiyat = 0;
        int hesapla = 0;    

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {
            sivil++;
            fiyat = fiyat + 50;
            textBox1.Text = sivil.ToString();
            textBox2.Text = fiyat.ToString();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            
            sivil--;
            fiyat = fiyat - 50;
            textBox1.Text = sivil.ToString();
            textBox2.Text = fiyat.ToString();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            öğrenci++;
            öğrencifiyat = öğrencifiyat + 35;
            textBox3.Text = öğrenci.ToString();
            textBox4.Text = öğrencifiyat.ToString();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            öğrenci--;
            öğrencifiyat = öğrencifiyat - 35;
            textBox3.Text = öğrenci.ToString();
            textBox4.Text = öğrencifiyat.ToString();

        }

        private void button61_Click(object sender, EventArgs e)
        {
            mısır++;
            mısırfiyat = mısırfiyat + 40;
            textBox5.Text = mısır.ToString();
            textBox6.Text = mısırfiyat.ToString();

        }

        private void button62_Click(object sender, EventArgs e)
        {
            mısır--;
            mısırfiyat = mısırfiyat - 40;
            textBox5.Text = mısır.ToString();
            textBox6.Text = mısırfiyat.ToString();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            kola++;
            kolafiyat = kolafiyat + 25;
            textBox7.Text = kola.ToString();
            textBox8.Text = kolafiyat.ToString();

        }

        private void button64_Click(object sender, EventArgs e)
        {
            kola--;
            kolafiyat = kolafiyat - 25;
            textBox7.Text = kola.ToString();
            textBox8.Text = kolafiyat.ToString();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            su++;
            sufiyat = sufiyat + 5;
            textBox9.Text = su.ToString();
            textBox10.Text = sufiyat.ToString();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            su--;
            sufiyat = sufiyat - 5;
            textBox9.Text = su.ToString();
            textBox10.Text = sufiyat.ToString();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            hesapla = fiyat + öğrencifiyat + mısırfiyat + sufiyat + kolafiyat;
            textBox15.Text = hesapla.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Green;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Green;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Green;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Green;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Green;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Green;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Green;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Green;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Green;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Green;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.Green;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.Green;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Green;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.Green;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Green;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Green;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.Green;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Green;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.Green;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.Green;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Green;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.Green;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackColor = Color.Green;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Green;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.BackColor = Color.Green;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.BackColor = Color.Green;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Green;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.Green;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.BackColor = Color.Green;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Green;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.BackColor = Color.Green;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.BackColor = Color.Green;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Green;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.BackColor = Color.Green;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.BackColor = Color.Green;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Green;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.BackColor = Color.Green;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.BackColor = Color.Green;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.BackColor = Color.Green;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.BackColor = Color.Green;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.BackColor = Color.Green;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.BackColor = Color.Green;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.BackColor = Color.Green;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.BackColor = Color.Green;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.BackColor = Color.Green;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödemeniz Alınmıştır Lütfen Fişinizi Alınız!");
        }
    }
}
