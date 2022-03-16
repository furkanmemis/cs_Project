using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluInterface
{
    internal interface Interface
    {
        string isim { get; set; }
        string soyisim { get; set; }
        int yas { get; set; }
        string ıd { get; set; }
        string cinsiyet { get; set; }

        void bilgi();
    }
}
