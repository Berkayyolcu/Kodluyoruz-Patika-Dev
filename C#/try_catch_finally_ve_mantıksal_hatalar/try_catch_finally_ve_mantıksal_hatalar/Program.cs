
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_finally_ve_mantıksal_hatalar
{
    internal class Program
    {
        static void Main(string[] args)
        {




            try
            {

                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);

                // integer deger girilirse burası sorunsuz calısır
                // string değer girilirse bu kod blogu hataya düser ve catch blogu calısır 

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());
            }

            finally
            {

                Console.WriteLine("İslem tamamlandı");

            }


            Console.WriteLine("\n*************************\n");


            try
            {

                //int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-20000000000");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine("Hata : " + ex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Format tipi uygun değil");
                Console.WriteLine("Hata : " + ex);
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz");
                Console.WriteLine("Hata : " + ex);
            }

            finally
            {
                Console.WriteLine("İslem basarıyla tamamlandı");
            }



        }
    }
}
