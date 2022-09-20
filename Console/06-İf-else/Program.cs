using System;

namespace _06_İf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ortalamaya göre kaldımı geçtimi
            
            int sınav1, sınav2, ortalama;
            
            Console.WriteLine("Sınav 1 = ");
            sınav1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sınav 2 = ");
            sınav2 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sınav1 + sınav2) / 2;

            Console.WriteLine("Ortalama = "+ortalama);

            if (ortalama > 50)
            {
                Console.WriteLine("Öğrenci dersi geçti");
            }
            else
            {
                Console.WriteLine("Öğrenci dersten kaldı");
            }


            Ifelse3();
            Ifelse2();
            Ifelse1(); 
            Console.ReadKey();


        }

        private static void Ifelse3()
        {
            //Pozitif mi Negatif mi
            int numara;
            Console.WriteLine("Lütfen sayı Giriniz");
            numara = Convert.ToInt32(Console.ReadLine());

            if (numara >= 0)
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else
            {
                Console.WriteLine("Sayı Negatif");
            }
        }

        private static void Ifelse2()
        {
            string sehir;
            Console.WriteLine("Türkiye ' nin başkenti neresidir= ");
            sehir = Console.ReadLine();

            if (sehir == "Kahramanmaraş")
            {
                Console.WriteLine("Tebrikler Doğru Bildiniz");
            }
            else
            {
                Console.WriteLine("Yanlış Cevap");
            }
        }

        private static void Ifelse1()
        {
            string isim = "Selim";

            if (isim == "Selim")
            {
                Console.Write("Doğru isim Girişi");
            }
            else
            {
                Console.Write("Hatalı İsim");
            }

            string name;
            Console.WriteLine("İsminizi Girin: ");
            name = Console.ReadLine();

            if (name == "Selim")
            {
                Console.WriteLine("Doğru isim Girişi");
            }
            else
            {
                Console.WriteLine("Hatalı İsim Girişi Yaptınız");
            }
        }
    }
}
