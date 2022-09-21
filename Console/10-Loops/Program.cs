using System;

namespace _10_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While

            //faktoriyel hesabı

            int sayi1;
            Console.WriteLine("Faktoriyeli alınacak sayıyı girin: ");
            sayi1 =Convert.ToInt16(Console.ReadLine());
            int faktoryel = 1;

            while(sayi1 > 1)
            {
                faktoryel = faktoryel * sayi1;
                sayi1--;
            }
            Console.WriteLine(faktoryel);





            //Tek sayı girilene kadar devam eden program
            int sayi;
            Console.WriteLine("Bir sayı girin: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            while (sayi %2 == 0)
            {
                Console.WriteLine("Bir sayı girin");
                sayi = Convert.ToInt16(Console.ReadLine());

            }
            Console.WriteLine("Tek sayı girdiniz");

            int j;
            j = 1;
            while(j <= 500)
            {
                Console.WriteLine(j);
                j++;
            }



            int i;
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Merhaba Kahramanmaraş");
                i++;
            }




            ForLoops3();
            tekÇiftToplam();
            sayılarınToplamı();
            forLoops2();
            forLoops1();
            Console.ReadKey();

        }

        private static void ForLoops3()
        {
            //Fibonacci serisi
            int a = 1;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int l = 1; l <= 8; l++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            //9 ve 9'un katlarınını toplamı
            int i;
            for (i = 0; i <= 100; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // 120 'nin tam bölenlerini yazdırma
            int sayi = 120;
            for (int j = 1; j <= 120; j++)
            {
                if (sayi % j == 0)
                {
                    Console.WriteLine(j);
                }
            }
        }

        private static void sayılarınToplamı()
        {

            //Girilen sayıların toplamı uygulaması
            int i;
            int toplam = 0;
            for (i = 1; i <= 10; i++)
            {
                toplam = toplam + i;

            }
            Console.WriteLine("Sayıların toplamı = " + toplam);
        }

        private static void tekÇiftToplam()
        {
            //çift sayıların toplamı
            int n;
            int toplam2 = 0;
            for (n = 0; n <= 10; n += 2)
            {
                toplam2 = toplam2 + n;

            }
            Console.WriteLine("Sayıların toplamı = " + toplam2);

            //Tek sayıların toplamı
            int j;
            int toplam1 = 0;
            for (j = 1; j <= 10; j += 2)
            {
                toplam1 = toplam1 + j;

            }
            Console.WriteLine("Sayıların toplamı = " + toplam1);
        }

        private static void forLoops2()
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            int j;
            for (j = 0; j <= 20; j += 2) // j= j + 2;
            {
                Console.WriteLine(j);
            }

            int m;
            for (m = 0; m <= 20; m += 3) // m= m + 3;
            {
                Console.WriteLine(m);
            }
        }

        private static void forLoops1()
        {
            //For looops bunu birkere yaz defalarca yazılsın

            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");

            //For Loops
            int i;
            for (i = 1; i <= 10; i++) // for(Başlangıç değeri; bu sayıyakad ; artır yada azalt)
            {
                Console.WriteLine("Merhaba Dünya");
            }
        }
    }
}
