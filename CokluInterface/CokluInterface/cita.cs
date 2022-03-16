using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluInterface
{
    internal class cita:hayvan,Interface
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int yas { get; set; }
        public string ıd { get; set; }
        public string cinsiyet { get; set; }

        private int yavru_sayisi { get; set; }
        private string yasadigi_yer { get; set; }

        
        public cita(string isim,string soyisim,int yas,string ıd,string cinsiyet,int yavru_sayisi,string yasadigi_yer)
        {
            this.isim= isim;
            this.soyisim= soyisim;
            this.yas = yas;
            this.ıd = ıd;
            this.cinsiyet = cinsiyet;
            this.yavru_sayisi = yavru_sayisi;
            this.yasadigi_yer = yasadigi_yer;
        }
        public void avlan()
        {
            base.avlan();
        }
        public void saldir()
        {
            base.saldir();
        }
        public void kac()
        {
            base.kac();
        }


        public void bilgi()
        {
            Console.WriteLine("isim: {0}\nsoy isim: {1}\nyas: {2}\nıd: {3}\ncinsiyet:{4}", isim, soyisim, yas, ıd, cinsiyet);

        }
    }
}
