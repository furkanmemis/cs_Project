using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluInterface
{
    internal class ogrenci:insan,Interface
    {
        private int okul_no { get; set; }
        private int not { get; set; }

        public string isim { get; set; }
        public string soyisim { get; set; }
        public int yas { get; set; }
        public string ıd { get; set; }
        public string cinsiyet { get; set; }

        public ogrenci(string isim,string soyisim,int yas,string ıd,string cinsiyet,int okul_no,int not)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.yas = yas;
            this.ıd = ıd;
            this.cinsiyet = cinsiyet;
            this.okul_no = okul_no;
            this.not = not;

        }
        public void yemek()
        {
            base.yemek();
        }
        public void kos()
        {
            base.kos();
        }
        public void calis()
        {
            base.calis();
        }

        public void bilgi()
        {
            Console.WriteLine("isim: {0}\nsoy isim: {1}\nyas: {2}\nıd: {3}\ncinsiyet:{4}", isim, soyisim, yas, ıd, cinsiyet);
            Console.WriteLine("okul no: {0}\nnot: {1}", okul_no, not);
        }
        public void sosyal()
        {
            kulüp.etkinlik();
        }
        
        
    }
}
