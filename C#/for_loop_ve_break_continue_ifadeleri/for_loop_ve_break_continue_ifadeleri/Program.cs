    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace for_loop_ve_break_continue_ifadeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            Console.WriteLine("Bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for(int i =0; i <= sayac; i++)
            {

                if (i % 2 == 1)
                    Console.WriteLine(i);

            }


            Console.WriteLine("\n");



            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tektoplam += i; // tektoplam = tektoplam + 1;
                else

                    cifttoplam += i; // cifttoplam = cifttoplam + 1;

            }


            Console.WriteLine("Tek sayılar toplamı : " + tektoplam );
            Console.WriteLine("Cift sayılar toplamı : " + cifttoplam);


            Console.WriteLine("\n");
            // break, continue

            for (int i = 1; i < 10; i++)
            {

                if (i == 4)
                    break;
                Console.WriteLine(i); // 3 e kadar yazar bitirie

            }

            Console.WriteLine("\n");

            for (int i = 1; i < 10; i++)
            {

                if (i == 4)
                    continue;
                Console.WriteLine(i); // 4ü atlar devam eder

               }

            }
       }
}
