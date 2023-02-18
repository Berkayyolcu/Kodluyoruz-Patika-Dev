using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rekürsif_ve__extension_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Rekürsif - Öz yinemeli
            //3^4

            int result = 1;
            for(int i=1; i<5; i++)
            {
                result = result * 3;
                Console.WriteLine(result); // 3-9-27-81-81 for da belirtdigimiz gibi 5 kere döndürür bu islemi tekrar eder
            }


            Islemler instance =new Islemler();
            Console.WriteLine(instance.expo(3,4));



            // Extension Metotlar
            string ifade = "Zikriye Ürkmez Cengiz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)         
                Console.WriteLine(ifade.RemoveWhiteSpaces());// Zikriye-Ürkmez-Cengiz
                Console.WriteLine(ifade.MakeUpperCase());  // ZİKRİYE ÜRKMEZ CENGİZ
                Console.WriteLine(ifade.MakeLowerCase());  // zikriye ürkmez cengiz


             int[] dizi = {9,3,6,2,1,5,0};
             dizi.SortArray();
             dizi.EkranaYazdir(); // 0 1 2 3 5 6 9


            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber()); // False


            Console.WriteLine(ifade.GetFirstCharacter()); // Z

        }
    }


    public class Islemler
    {
        public int expo(int sayi, int üs)
        {

            if (üs < 2)
                return sayi;
            return expo(sayi, üs - 1) * sayi;
        }

        //Expo (3,4)
        //Expor(3,3)*3
        //Expo (3,2)*3*3;
        //Expo (3-1)*3*3*3;
        // 3*3*3*3 =3^4;

    }


    public static class Extension
    {

        public static bool CheckSpaces(this string param)
        {
            return param.Contains("");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split();
            return string.Join("-", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }


        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;  
        }


        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;

        }

        public static string GetFirstCharacter(this string param)
        {

            return param.Substring(0,1);

        }

    }
}
