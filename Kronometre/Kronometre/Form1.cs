using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {

        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        int salise = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if(salise == 100)
            {
                salise = 0;
                saniye++;
            }
            if(saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if(dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            label5.Text = saat.ToString();
            label6.Text = dakika.ToString();
            label7.Text = saniye.ToString();
            label8.Text = salise.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //başlat
            timer1.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //tur
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + ":" + salise);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //reset
            timer1.Stop();
            saat = 0;
            dakika = 0;
            saniye = 0;
            salise = 0;

            label5.Text = "0";
            label6.Text="0";
            label7.Text="0";
            label8.Text="0";

            listBox1.Items.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //durdur

            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString()+"/" +DateTime.Now.Year.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
