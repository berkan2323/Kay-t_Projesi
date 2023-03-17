using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_bir_kayıt_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, meslek;
            int yas, maas;

            ad = textBox1.Text;
            soyad = textBox2.Text;
            meslek = textBox3.Text;
            yas = Convert.ToInt32(textBox3.Text);
            maas = Convert.ToInt32(textBox5.Text);

            listBox1.Items.Add("Adınız : " + ad);
            listBox1.Items.Add("Soyadınız : " + soyad);
            listBox1.Items.Add("Yaşınız : " + yas);
            listBox1.Items.Add("Mesleğiniz : " + meslek);
            listBox1.Items.Add("Maaşınız : " + maas);
            listBox1.Items.Add("T.C.Kimlik Numaranız : " + maskedTextBox1.Text);
            listBox1.Items.Add("Telefon Numaranız : 0" + maskedTextBox2.Text);
            listBox1.Items.Add("Doğum Tarihiniz : " + dateTimePicker1.Text);
            listBox1.Items.Add("Doğum  Saatiniz : " + maskedTextBox3.Text);
            listBox1.Items.Add(" Doğduğunuz Şehir : " + comboBox1.SelectedItem);
        }
    }
}
