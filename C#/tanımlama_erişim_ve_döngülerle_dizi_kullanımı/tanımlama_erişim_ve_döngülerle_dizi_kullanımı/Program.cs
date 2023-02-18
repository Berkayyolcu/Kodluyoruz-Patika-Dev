using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanımlama_erişim_ve_döngülerle_dizi_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];




            // Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]); // Köpek
            Console.WriteLine(dizi[3]); // 10
            Console.WriteLine(renkler[0]); // Mavi




            //Döngülerle Dizi kullanımı
            // klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz :");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunlugu];

            for(int i=0; i<diziuzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısı giriniz",i+1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayidizisi) 
                toplam += sayi;


            Console.WriteLine("Ortalama : " + toplam/diziuzunlugu);
            

        }
    }
}
