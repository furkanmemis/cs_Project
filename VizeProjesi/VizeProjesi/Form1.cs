using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text.ToString();
            string soyad = textBox2.Text.ToString();
            string tcNo = textBox3.Text.ToString();
            DateTime dt = Convert.ToDateTime(textBox4.Text);


            
            tc vatandas = new tc(ad,soyad,tcNo,dt);

            Form2 f =new Form2();
      
            f.isim = vatandas.getIsim().ToString();
            f.uyruk = "Türkiye Cumhuriyeti";
            f.soyad = vatandas.getSoyad().ToString();
            f.id = vatandas.getTc().ToString();
            f.dogumTarihi = vatandas.getDT();
            f.vize = vatandas.vizeKontrol().ToString();
            f.Show();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text.ToString();
            string soyad = textBox2.Text.ToString();
            string id = textBox3.Text.ToString();
            DateTime dt = Convert.ToDateTime(textBox4.Text);

            abd vatandas = new abd(ad, soyad, id, dt);

            Form2 f = new Form2();

            f.isim = vatandas.getIsım();
            f.uyruk = "Amerika Birleşik Devletleri";
            f.soyad = vatandas.getSoyisim();
            f.id = vatandas.getID();
            f.dogumTarihi = vatandas.getDt();
            f.vize = vatandas.VizeDurum();

            f.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
