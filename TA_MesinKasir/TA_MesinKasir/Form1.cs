using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_MesinKasir
{
    public partial class Form1 : Form
     {
        int pilihan, harga, totalHarga, jumlahBarang, kembalian, uang = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pilihan = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)
            {
                harga = 9359000;
                jumlahBarang = comboBox2.SelectedIndex + 1;
                totalHarga = harga * jumlahBarang;
                textBox1.Text = totalHarga.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                harga = 10559000;
                jumlahBarang = comboBox2.SelectedIndex + 1;
                totalHarga = harga * jumlahBarang;
                textBox1.Text = totalHarga.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                harga = 10970000;
                jumlahBarang = comboBox2.SelectedIndex + 1;
                totalHarga = harga * jumlahBarang;
                textBox1.Text = totalHarga.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                harga = 11640000;
                jumlahBarang = comboBox2.SelectedIndex + 1;
                totalHarga = harga * jumlahBarang;
                textBox1.Text = totalHarga.ToString();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                harga = 12999000;
                jumlahBarang = comboBox2.SelectedIndex + 1;
                totalHarga = harga * jumlahBarang;
                textBox1.Text = totalHarga.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out uang);
            kembalian = uang - totalHarga;
            textBox3.Text = kembalian.ToString();
            if (uang > totalHarga)
            {
                textBox4.Text = "Terimakasih telah berbelanja di toko Kami, Semoga Anda Senang :-) #TokoLaptop";
            }
            else
            {
                textBox4.Text = "Maaf, nominal uang yang anda masukan kurang. Silahkan masukan nominal uang Anda kembali";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}