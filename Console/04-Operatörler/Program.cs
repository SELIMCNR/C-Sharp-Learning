using System;

namespace _04_Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 1;
            sayi2 = 2;
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
         

           
            int number1, number2, toplam1;
            Console.WriteLine("****Toplama İşlemi******");


            Console.WriteLine("Birinci Sayıyı giriniz: ");
            number1 = Convert.ToInt32(Console.ReadLine());//Stringi integere dönüştürdük

            Console.WriteLine("İkinci Sayıyı giriniz:");
            number2 = Convert.ToInt32(Console.ReadLine());

            toplam = number1 + number2;



            //Tüm aritmetik işlemler
            int sayi11, sayi22, toplam11, fark11, carpim11, bolum11;
            Console.WriteLine("******Aritmetik İşlem*****");

            Console.WriteLine("1.Sayıyı Giriniz= ");
            sayi11 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayıyı Girinz= ");
            sayi22 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            toplam11 = sayi11 + sayi22;
            Console.WriteLine("Toplam= "+ toplam11);


            fark11 = sayi11 + sayi22;
            Console.WriteLine("Fark= "+fark11);

            carpim11 = sayi11 * sayi22;
            Console.WriteLine("Carpim= "+carpim11);

            bolum11 = sayi11 / sayi22;
            Console.WriteLine("Bolum: "+bolum11);

            //Karenin alan ve çevresini bulan program 
            int kenar, karealan, karecevre;
            int kısakenar, uzunkenar, dikalan, dikcevre;

            Console.WriteLine("*****Karenin Alan ve Çevresini Bulma***");

            Console.WriteLine("Karenin bir kenarını girin");    
            kenar = Convert.ToInt32(Console.ReadLine());
            karealan = kenar * kenar;
            karecevre = kenar * 4;

            Console.WriteLine("Kare Alan= "+karealan);
            Console.WriteLine("Kare Çevre="+karecevre);

            Console.WriteLine();
            Console.WriteLine("Dikdörtgenin Alan ve Çevresi ");
            Console.WriteLine("Kısa Kenarı girin=");
            kısakenar= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun Kenarı Girin=");
            uzunkenar = Convert.ToInt32(Console.ReadLine());

            dikalan = kısakenar * uzunkenar;
            dikcevre = 2 * (kısakenar + uzunkenar);


            Console.WriteLine("Dikdörtgen Alan= " + dikalan);
            Console.WriteLine("Dikdörtgen Çevre=" + dikcevre);


            Console.ReadKey();

        }
    }
}
