using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol_denemeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int deger = 2;
            Console.WriteLine(deger); //ekrana 2 yazdırır

            string degisken = null;  
            Console.WriteLine(degisken); //bos(null) bir değer atıyoruz 

            byte b = 5;  // 1 byte yer kaplar
            sbyte c = 5; // 1 byte yer kaplar

            short s = 5;   // 2 byte yer kaplar
            ushort us = 5; // 2 byte yer kaplar

            Int16 i16 = 2;  // 2 byte yer kaplar
            int i = 2;      // 4 byte yer kaplar
            Int32 i32 = 2;  // 4 byte yer kaplar
            Int64 i64 = 2;  // 8 byte yer kaplar

            uint ui = 2;    // 4 byte yer kaplar
            long l = 4;     // 8 byte yer kaplar
            ulong ul = 4;   // 8 byte yer kaplar

            // Reel Sayılar
            float f = 5;    // 4 byte yer kaplar
            double d = 5;   // 8 byte yer kaplar
            decimal de = 5; // 16 byte yer kaplar

            char ch = '2';          // 2 byte byte yer kaplar
            string str = "Zikriye"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt); // o anki tarih ve saat bilgilerini gösterir

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;
            // object ile her türden veriyi alabilir

            // String İfadeler
            string str1 = string.Empty;
            str1 = "Zikriye Ürkmer";
            String ad = "Zikriye";
            String soyad = "Ürkmer";
            String tamisim = ad + " " + soyad;

            // integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean
            bool bool1 = 10 < 2;  // false döner
            bool bool2 = 10 > 2;  // true döner

            // Değisken Dönüsümleri
            String str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger);
            /* int20 degiskeni Stringe cevirdigimiz icin ekran cıktısı 2020 olur */


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);
            /* str20 degiskeni inte cevirdigimiz icin ekran cıktısı 40 
            iki sayı sayısal deger olur ve bunları toplar */

            int int22 = int20 + int.Parse(str20); // cıktısı 40 olur 

            // datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime); // cıktısı 12.02.2023 tarih olur

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);  // cıktısı 12/02/2023 tarih olur

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour); // cıktısı 03:56 saat olur


        }
    }
}
