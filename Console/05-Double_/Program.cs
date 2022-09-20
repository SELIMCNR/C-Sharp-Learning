using System;

namespace _05_Double_
{
 
        internal class Program
        {
            static void Main(string[] args)
            {
                //Double onadalıklı sayı değişkenleri

                Console.WriteLine("Öğrenci Not Hesaplama");
                //Tanımlama
                double sınav1, sınav2, sınav3, proje, ort;
                string ad, soyad, numara;
                Console.WriteLine();
                Console.WriteLine("*****Öğrenci kimlik bilgileri*****");
                Console.WriteLine();

                Console.WriteLine("Adınız: ");
                ad = Console.ReadLine();  //Dışardan veri ekletir

                Console.WriteLine("Soyadınızı= ");
                soyad = Console.ReadLine();

                Console.WriteLine("Numaranız = ");
                numara = Console.ReadLine();

                Console.WriteLine("******Öğrenci Sınav Bilgileri ");
                Console.WriteLine();

                Console.WriteLine("Birinci sınav= ");
                sınav1 = Convert.ToDouble(Console.ReadLine()); //Dışardan gelen değeri double a döndür ve değişkene ata

                Console.WriteLine("İkinci sınav=  ");
                sınav2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ücüncü sınav= ");
                sınav3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Proje notunuz= ");
                proje = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("***** Ortalama Değeri ");
                Console.WriteLine();

                ort = (sınav1 + sınav2 + sınav3) / 3;
                Console.WriteLine("Ortalama " + ort);

                Console.Write("Ad  Soyad " + ad + soyad);

                Console.WriteLine("Ortalama : " + ort);


            }
        }
}
