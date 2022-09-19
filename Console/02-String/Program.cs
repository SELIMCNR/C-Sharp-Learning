using System;

namespace _02_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Metin verileri tutan değişken
            //Tanımlama
            string isim;
            isim = "Selim";
            string sehir;
            sehir = "İstanbul";

            //Yazdırma
            Console.WriteLine(isim);
            Console.WriteLine(sehir);
            Console.Read();

            string soyisim;
            Console.WriteLine("İsminizi giriniz: ");
            soyisim = Console.ReadLine(); //Dışardan veri alır
            Console.WriteLine("Hoşgeldiniz: " + soyisim);

            //tanımlama
            string ad, soyad, yas, meslek, şehir;
            //değer girme
            ad=Console.ReadLine();
            soyad=Console.ReadLine();   
            yas=Console.ReadLine();
            meslek=Console.ReadLine();
            şehir=Console.ReadLine();
            //yazdırma
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad "+soyad);
            Console.WriteLine("Yas: "+soyad);
            Console.WriteLine("Meslek: "+meslek);
            Console.WriteLine("Şehir: "+şehir);

            String name;
            Console.WriteLine("Lütfen isminizi Girin: ");
            name = Console.ReadLine();
            Console.WriteLine("Merhaba : {0}",name);
            Console.Read();

            String name1, surname1, city;
            Console.WriteLine("Ad: ");
            name1 = Console.ReadLine();
            Console.WriteLine("Soyadınızı girin: ");
            surname1 = Console.ReadLine();
            Console.WriteLine("Şehrinizi Girin: ");
            city = Console.ReadLine();

            Console.WriteLine("Name - Surname - Şehir {0} {1} {2}",name1,surname1,city);

        }
    }
}
