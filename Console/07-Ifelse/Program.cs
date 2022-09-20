using System;

namespace _07_Ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && Ve sembolü 
            // % Mod alma

            //5'e tam bolunuyormu

            int sayi;
            Console.WriteLine("Sayi Girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            
            if(sayi %5 == 0)
            {
                Console.WriteLine("Sayı 5'e tam bölünür. ");
            }
            else
            {
                Console.WriteLine("Sayı 5'e tam bolunmez");
            }

            TekCift();
            OrtalamaHesaplama();
            Console.ReadLine();
        }

        private static void TekCift()
        {
            //Tek çift
            int sayi;
            Console.WriteLine("Sayıyı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
        }

        private static void OrtalamaHesaplama()
        {
            int sınav1, sınav2, proje, ortalama;

            Console.WriteLine("1.sınav : ");
            sınav1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sınav: ");
            sınav2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Proje Notunuzu giriniz: ");
            proje = Convert.ToInt32(Console.ReadLine());

            ortalama = (sınav1 + sınav2 + proje) / 3;

            Console.WriteLine("Ortalama : " + ortalama);

            if (ortalama > 0 && ortalama < 30)
            {
                Console.WriteLine("Durum: Vasat ");
            }

            else if (ortalama >= 30 && ortalama < 50)
            {
                Console.WriteLine("Dudum: İyi değil");
            }

            else if (ortalama >= 50 && ortalama < 75)
            {
                Console.WriteLine("Durum: İyi ");
            }
            else if (ortalama >= 75 && ortalama < 90)
            {
                Console.WriteLine("Durum: Çok iyi");
            }
            else if (ortalama >= 90 && ortalama <= 100)
            {
                Console.WriteLine("Durum: Harika");
            }
        }
    }
}
