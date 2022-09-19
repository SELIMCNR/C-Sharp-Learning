using System;

namespace _03_Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2 = 6;
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
     

            int a, b, c;
            a = 8;
            b = 7;
            c = a * b;
            Console.WriteLine("a * b = " + c);

            int deger1, deger2, bolum;
            deger1 = 12;
            deger2 = 22;
            bolum = (deger1 + deger2) / 2;
            Console.WriteLine(bolum);

            //Sınavları girilen öğrencinin ortalaması
            string ad, soyad, numara;
            int sınav1, sınav2, sınav3, proje, ortalama;
            Console.WriteLine("*****Öğrenci bilgi ****");
            ad = "Selim";
            soyad = "Çınar";
            numara = "123456789";
            Console.WriteLine("Ad: "+ad);
            Console.WriteLine("Soyad: "+soyad);
            Console.WriteLine("Numara: "+numara);

            Console.WriteLine();
            Console.WriteLine("**** Not Bilgi ****");
            Console.WriteLine();

            sınav1 = 60;
            sınav2 = 70;
            sınav3 = 100;
            proje = 90;

            Console.WriteLine("Sınav 1 = "+sınav1);
            Console.WriteLine("Sınav 2 = "+sınav2);
            Console.WriteLine("Sınav 3 = "+sınav3);
            Console.WriteLine("Proje Notu= "+proje);

            Console.WriteLine();
            Console.WriteLine("*****Ortalama Bilgi*****");

            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;

            Console.WriteLine("Ortalama= "+ortalama);

            Console.ReadKey();
        }
    }
}
