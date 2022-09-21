using System;

namespace _11___Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diziler 2

            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear(); //Öğrenci ad ve puandan sonra siler

                Console.WriteLine(i + 1 + "Öğrencinin Adı: ");
                isim[i] = Console.ReadLine();

                Console.WriteLine(i+1+"Sınav: ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(i+1+"Sınav2: ");
                s2[i] = Convert.ToInt32(Console.ReadLine());

                ort[i] = (s1[i] + s2[i]) / 2;

            }
            Console.WriteLine("Öğrenci  Sınav  Sınav2  Ortalama");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("   " + isim[i]+"   " + s1[i] + "    " + s2[i]+"   " + ort[i]);
            }
            enBuyuk();
            Dizi();
            Console.ReadKey();
        }

        private static void enBuyuk()
        {
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{(i + 1).ToString()}.Sayıyıyı girin: ");
                sayilar[i] = Convert.ToInt16(Console.ReadLine());

            }
            int enbuyuk;
            enbuyuk = sayilar[0];
            for (int i = 1; i < 5; i++)
            {
                if (enbuyuk < sayilar[i])
                {
                    enbuyuk = sayilar[i];
                }

            }
            Console.WriteLine(enbuyuk);
        }

        private static void Dizi()
        {
            //Diziler 
            int[] sayilar = { 10, 45, 21, 35, 64, 75, 84, 26 };
            Console.WriteLine(sayilar[0]);//dizinin ilk başta indeks değeri
            Console.WriteLine(sayilar[7]); //dizinin en son indeks değeri 7

            string[] isimler = { "Selim", "Ali", "Ahmet", "Emel", "Ayşe", "Baran" };
            Console.WriteLine(isimler[3]);

            string[] sehirler1 = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Şehir: ");
                sehirler1[i] = Console.ReadLine();
            }

            Console.WriteLine("******Şehirler Listesi*****");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler1[i]);
            }

            string[] ogrenciler = new string[30];
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Öğrenci: ");
                ogrenciler[i] = Console.ReadLine();
                Console.WriteLine("Öğrenci ad soyad:" + ogrenciler[i]);
            }
        }
    }
}
