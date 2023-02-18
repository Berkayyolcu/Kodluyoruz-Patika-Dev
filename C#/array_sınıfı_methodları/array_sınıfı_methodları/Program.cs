using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sınıfı_methodları
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //sort : sıralı bir sekilde sıralar

            int[] sayidizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("**** Sırasız Dizi ****");
            foreach (var sayi in sayidizisi) 
            Console.Write(sayi);
            //23-12-4-86-72-3-11-17

            Console.WriteLine("\n\n **** Sıralı Dizi ****");
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
                Console.Write(sayi);
            //3-4-11-12-17-23-72-86




            //clear : değeri sıfırlar baslangıc ve bitis değerine göre 2 indexten 2 tane elemanı 0'lar

            Console.WriteLine("\n\n **** Clear ****");

            Array.Clear(sayidizisi,2,2);
            foreach (var sayi in sayidizisi)
                Console.Write(sayi);
            //3-4-0-0-17-23-72-86




            //Reverse : Diziyi tersine cevirir

            Console.WriteLine("\n\n **** Reverse ****");

            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
                Console.Write(sayi);
            //86-72-23-17-0-0-4-3




            //IndexOf : verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.

            Console.WriteLine("\n\n **** IndexOf ****");

                Console.Write(Array.IndexOf(sayidizisi, 23)); // 2
                Console.Write(Array.IndexOf(sayidizisi, 2));  // -1 




            //Resize : Dizileri yeniden boyutlandırmak için kullanılır.

            Console.WriteLine("\n\n **** Resize ****");

            Array.Resize<int>(ref sayidizisi, 9);
            sayidizisi[8] = 99;
            foreach (var sayi in sayidizisi)
                Console.Write(sayi);
            //86-72-23-17-00-4-3-99


        }
    }
}
