using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while
            // 1den baslayarak konsoldan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp konsola yazdıran program

                Console.WriteLine("Bir sayı giriniz");
                int sayi = int.Parse(Console.ReadLine());
                int sayac = 1;
                int toplam = 0;
                
                while (sayac<=sayi)
                {
                    toplam += sayac;
                    sayac++;
                   
                }
                Console.WriteLine( "Girdiginiz sayı " + sayi + " ortalaması : " + toplam/sayi);


            Console.WriteLine("\n");

            // a dan z ye kadar tüm harfleri konsola yazdır

            char character = 'a';
            while(character < 'z')
            {
                Console.WriteLine(character);
                character ++;

            }


            Console.WriteLine("\n  *****  Foreach ***** ");
            string[] arabalar = {"BMW","FORD","TOYOTA","NİSSAN" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);

            }



        }
    }
}
