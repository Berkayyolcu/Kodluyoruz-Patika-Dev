using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Atama ve islemli Atama
            int x = 3;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y); // cıktısı 5 olur
            y += 2;
            Console.WriteLine(y); // cıktısı 7 olur
            y /= 1;
            Console.WriteLine(y); // cıktısı 7 olur
            x *= 2;
            Console.WriteLine(x); // cıktısı 6 olur

            // Mantıksal Operatörler
            // ||, &&, !

            bool issucces = true;
            bool iscompleted = false;

            if (issucces && iscompleted)
                Console.WriteLine("Perfect!");

            if (issucces || iscompleted)
                Console.WriteLine("Great!");

            if (issucces && iscompleted)
                Console.WriteLine("Fine!");

            //İlişisel Operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc); // cıktısı true olur 
            sonuc = a > b;  
            Console.WriteLine(sonuc); // cıktısı false  olur
            sonuc = a >= b;
            Console.WriteLine(sonuc); // cıktısı false  olur
            sonuc = a <= b;
            Console.WriteLine(sonuc); // cıktısı true olur 
            sonuc = a == b;
            Console.WriteLine(sonuc); // cıktısı false  olur
            sonuc = a!= b;
            Console.WriteLine(sonuc);  // cıktısı true olur 


            Console.WriteLine("**** Aritmetik Operatörler ****");
            // /, *,+,-

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);   // cıktısı 2 olur 
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);   // cıktısı 50 olur
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);   // cıktısı 15 olur
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);   // cıktısı 5 olur
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);   // cıktısı 11 olur


            // %, mod alır
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2); // cıktısı 2 olur





        }
    }
}
