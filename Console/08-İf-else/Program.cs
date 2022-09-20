using System;

namespace _08_İf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kitap dükani uygulaması
            Console.WriteLine("*****Kitapci dükkani");

            double x, indirim, odenecek;
            Console.Write("Alışveriş Tutarını Giriniz: ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x < 100)
            {
                indirim = x * 10 / 100; //tutardan %10 indirimi çıkarır
                Console.WriteLine("İndirim miktarı: "+indirim);
                odenecek = x - indirim;
            
                Console.WriteLine("Toplam Miktar: "+odenecek);
            }
            if(x >= 100 && x < 150)
            {
                indirim = x * 15 / 100;
                Console.WriteLine("İndirim miktarı: "+indirim);
                odenecek = x - indirim;
                Console.WriteLine("Toplam Miktar: "+odenecek);
            }
            if(x >= 150 && x <= 200)
            {
                indirim = x * 20 / 100;
                Console.WriteLine("İndirim miktarı: "+indirim);
                odenecek= x - indirim;
                Console.WriteLine("Toplam Miktar: "+odenecek);
            }


            mevsimUygulaması();
            Console.ReadKey();
        }

        private static void mevsimUygulaması()
        {
            //Klavyeden girilen mevsime göre mevsimin aylarını yazdır

            string mevsim;
            Console.WriteLine("Lütfen bir mevsim giriniz: ");
            mevsim = Console.ReadLine();

            if (mevsim == "kış")
            {
                Console.Write("Kış mevsim ayları : Aralık ,Ocak, Şubat");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("İlkbahar mevsim ayları: Mart ,Nisan ,Mayıs");
            }
            else if (mevsim == "yaz")
            {
                Console.WriteLine("Yaz mevsim ayları: Haziran,Temmuz,Ağustos");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine("Sonbahar mevsim ayları: Eylül,Ekim,Kasım");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız");
            }
        }
    }
}
