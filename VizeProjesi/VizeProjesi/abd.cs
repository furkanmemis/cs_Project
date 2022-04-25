using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeProjesi
{
    internal class abd
    {
        private string isim;
        private string soyisim;
        private string Id;
        private DateTime dt;

        public abd(string a, string s, string ı,DateTime d)
        {
            this.isim = a;
            this.soyisim = s;
            this.Id = ı;
            this.dt = d;
        }

        public string VizeDurum()
        {
            return "Vize Alabilir";
        }
        public string getIsım()
        {
            return this.isim;
        }
        public string getSoyisim()
        {
            return this.soyisim;
        }
        public string getID()
        {
            return this.Id;
        }
        public DateTime getDt()
        {
            return this.dt;
        }
    }
}
