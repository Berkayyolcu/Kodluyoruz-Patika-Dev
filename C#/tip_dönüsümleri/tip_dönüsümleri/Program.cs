using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tip_dönüsümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Implicit Conversion (Biliçsiz Dönüsüm)
            Console.WriteLine("***** Implicit Conversion *****");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d : " +d); // 45 

            long h = d;
            Console.WriteLine("h : " + h); // 45

            float i = h;
            Console.WriteLine("i : " + i); // 45

            string e = "zikriye";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g : " + g); // zikriyek45




            // Explicit Conversion (Bilinçli Dönüsüm) 
            Console.WriteLine(" \n ***** Explicit Conversion *****");
            // \n bir alt satıra gec 

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y : " + y); // 4 

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t : " + t); // 100

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v : " + v); // 10



            // ***** ToString Methodu ***** 
            Console.WriteLine(" \n ***** ToString Methodu *****");
            // \n bir alt satıra gec 

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy); // 6

            string zz = 12.5f.ToString();
            Console.WriteLine("zz : " + zz); // 12,5




            //System.Convert
            Console.WriteLine(" \n ***** System.Convert *****");
            // \n bir alt satıra gec 

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam); // 30




            //Parse
            Console.WriteLine(" \n ***** Parse *****");
            // \n bir alt satıra gec 
            ParseMethod();

        }


        public static void ParseMethod()
        {

            string metin1 = "10";
            string metin2 = "10,25";

            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 : " + rakam1); // 10
            Console.WriteLine("double1 : " + double1); // 10,25

        }
    }
}
