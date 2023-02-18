using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace metot_tanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // erisim_belirteci geri_dönüs_tipi metot adi(parametrelistesi/arguman)
            /*
            {
             komutlar;
            }
            */

            int a = 2;
            int b = 3;

            Console.WriteLine(a+b); // 5

            
            int sonuc = Topla(a, b); // a:2 ve b:3 
            Console.WriteLine("Topla Metotu : "+sonuc); // a+b=5


            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(" Metotlar Classı EkranaYazdir : " + Convert.ToString(sonuc));// 5

            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdir(" Metotlar Classı ArttırVeTopla : " + Convert.ToString(sonuc2)); // 7
            ornek.EkranaYazdir(" Metotlar Classı  : " + Convert.ToString(a+b));  // 7

        }

         static int Topla(int deger1, int deger2)
        {

            return (deger1+deger2);

        }

    }



    class Metotlar
    {

         public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }


        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;

        }

    }


}
