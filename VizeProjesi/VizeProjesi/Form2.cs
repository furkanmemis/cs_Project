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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string uyruk;
        public string isim;
        public string soyad;
        public string id;
        public DateTime dogumTarihi;
        public string vize;

        private void Form2_Load(object sender, EventArgs e)
        {
            label8.Text = uyruk;
            label9.Text = isim;
            label10.Text = soyad;
            label11.Text = id;
            label12.Text = dogumTarihi.ToString();
            label13.Text = vize;
        }
    }
}
