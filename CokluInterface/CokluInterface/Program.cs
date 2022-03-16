using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci("furkan","memiş",20,"16-in","erkek",401,90);
            ogrenci[] dizi = new ogrenci[5];
            {
                Console.WriteLine("Ogrenci");
                Console.WriteLine("-----");

                ogrenci1.yemek();
                Console.WriteLine("-----");

                ogrenci1.kos();
                Console.WriteLine("-----");

                ogrenci1.calis();
                Console.WriteLine("-----");

                ogrenci1.bilgi();
                Console.WriteLine("-----");

                ogrenci1.sosyal();
                Console.WriteLine("-----");
                Console.WriteLine("-----");
                Console.WriteLine("-----");


            }
            cita cita1 = new cita("alex","stark",13,"143-3","erkek",5,"afrika");
            cita[] dizi1 = new cita[4];
            {
                Console.WriteLine("Cita");
                Console.WriteLine("-----");

                cita1.avlan();
                Console.WriteLine("-----");

                cita1.saldir();
                Console.WriteLine("-----");

                cita1.kac();
                Console.WriteLine("-----");

                cita1.bilgi();
                Console.WriteLine("-----");

            }

            foreach(var k in dizi)
            {
                Console.WriteLine(k);
            }
            foreach(var k in dizi1)
            {
                Console.WriteLine(k);
            }

            Console.ReadLine();

        }
    }
}
