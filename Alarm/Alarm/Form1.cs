using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm
{
    public partial class Alarm : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Alarm()
        {
            InitializeComponent();
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime simdiki = DateTime.Now;
            DateTime alarm = dateTimePicker1.Value;

            if(simdiki.Hour == alarm.Hour && simdiki.Minute == alarm.Minute && simdiki.Second == alarm.Second && simdiki.Day == alarm.Day)
            {
                label2.Text = "Alarm Çalıyor";
                timer1.Stop();
                MessageBox.Show("Vakit Geldi");
                for(int i = 0; i < 10; i++)
                {
                    Console.Beep();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = "Alarm Kuruldu";
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Text = "Alarm Durduruldu";
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

  
    }
}
