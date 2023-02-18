using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotoverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // out parametreler

            String sayi = "999";
            int outSayi;


           bool sonuc =  int.TryParse(sayi, out  outSayi);

            if (sonuc)
            {
                Console.WriteLine("Basarılı ! ");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Basarısız ! ");
            }


            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamsonuc2);
            Console.WriteLine("Toplam : " + toplamsonuc2); // 9



            //Metot Asırı Yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade)); // string : 999
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Ziktriye","Ürkmez");


            // Metot İmzası
            //metot adı + parametre sayisi + parametre



        }
    }


    class Metotlar
    {

        public void Topla(int a, int b, out int toplam)
        {

            toplam = a + b;

        }

        public void EkranaYazdir(String veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }


    }

}
