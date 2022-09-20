using System;

namespace _09_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch Case Çok fazla if else yerine kullanılır

            //Konuma göre diğer şehirler uzaklık
            string sehir;
            Console.WriteLine("Lütfen şehir giriniz: ");
            sehir = Console.ReadLine();

            switch (sehir)
            {
                case "Kahramanmaraş":
                    Console.WriteLine("İstanbul ilinin Kahramanmaraş'a uzaklığı 1030 km 'dir");
                        break;
                case "Ankara":
                    Console.WriteLine("İstanbul ilinin Ankara ' ya uzaklığı 453 km 'dir ");
                    break;
                case "Bursa":
                    Console.WriteLine("İstanbul ilinin Bursa'ya uzaklığı 243 km 'dir");
                    break;
                case "Elazığ":
                    Console.WriteLine("İstanbul ilinin Elazığ'a uzaklığı 1232 km'dir ");
                    break;
                case "İzmir":
                    Console.WriteLine("İstanbul ilinin İzmir'e uzaklığı 561 km'dir");
                    break;
                case "Malatya":
                    Console.WriteLine("İstanbul ilinin Malatya'ya uzaklığı 1114 km 'dir");
                    break;
                case "Trabzon":
                    Console.WriteLine("İstanbul ilinin Trabzon'a uzaklığı 1070 km'dir ");
                    break;
                case "Artvin":
                    Console.WriteLine("İstanbul ilinin Artvin'e uzaklığı 1284 km'dir");
                    break;
                case "Gaziantep":
                    Console.WriteLine("İstanbul ilinin Gaziantep'e uzaklığı 1141 km 'dir");
                    break;
                case "Şanlıurfa":
                    Console.WriteLine("İstanbul ilinin Şanlıurfa'ya uzaklığı 1283 km'dir ");
                    break;
                case "Mardin":
                    Console.WriteLine("İstanbul ilinin Mardin'e uzaklığı 1474 km'dir");
                    break;
                case "Eskişehir":
                    Console.WriteLine("İstanbul ilinin Eskişehir'e uzaklığı 305 km 'dir");
                    break;
                case "Karabük":
                    Console.WriteLine("İstanbul ilinin Karanük'e uzaklığı 404 km'dir ");
                    break;
                case "Sivas":
                    Console.WriteLine("İstanbul ilinin Sivas'a uzaklığı 881 km'dir");
                    break;

                case "Diyarbakır":
                    Console.WriteLine("İstanbul ilinin Diyarbakıra'a uzaklığı 1338 km 'dir");
                    break;
                case "Rize":
                    Console.WriteLine("İstanbul ilinin Rize'ye uzaklığı 1135 km'dir ");
                    break;
                case "Osmaniye":
                    Console.WriteLine("İstanbul ilinin Osmaniye'e uzaklığı 1015 km'dir");
                    break;

                case "Yozgat":
                    Console.WriteLine("İstanbul ilinin Yozgat'a uzaklığı 657 km 'dir");
                    break;
                case "Kastamonu":
                    Console.WriteLine("İstanbul ilinin Kastomun'ya uzaklığı 508 km'dir ");
                    break;
                case "Kırıkkale":
                    Console.WriteLine("İstanbul ilinin Kırıkkale'ye uzaklığı 521 km'dir");
                    break;
                case "Aksaray":
                    Console.WriteLine("İstanbul ilinin Aksara'ya uzaklığı 667 km 'dir");
                    break;
                case "Bartın":
                    Console.WriteLine("İstanbul ilinin Bartın'a uzaklığı 435 km'dir ");
                    break;
                case "Isparta":
                    Console.WriteLine("İstanbul ilinin Isparta'ya uzaklığı 573 km'dir");
                    break;
                case "Hakkari":
                    Console.WriteLine("İstanbul ilinin Hakkari'ye uzaklığı 1824 km'dir");
                    break;


            }


            mevsimlerGöreaylar();
            haftaGünleriUygulaması();
            Console.ReadKey();
        }

        private static void mevsimlerGöreaylar()
        {
            //Mevsimlere göre ayları yazdırma
            string mevsim;
            Console.WriteLine("Lütfen mevsimi küçük harflerle giriniz:");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "yaz":
                    Console.WriteLine("Yaz mevsimi ayları : Haziran ,Temmuz ,Ağustos");
                    break;
                case "sonbahar":
                    Console.WriteLine("Sonbahar mevsimi ayları: Eylül ,Ekim,Kasım");
                    break;
                case "kış":
                    Console.WriteLine("Kış mevsimi ayları: Aralık,Ocak,Şubat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("İlkbahar mevsimi ayları: Mart,Nisan,Mayı");
                    break;
                default:
                    Console.WriteLine("Hatalı Mevsim Girişi ");
                    break;
            }
        }

        private static void haftaGünleriUygulaması()
        {
            //Klavyede girilen güne göre gün ismini veren program

            int sayi;
            Console.WriteLine("1 ile 7 arasında bir sayı giriniz:");
            sayi = Convert.ToInt16(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Bugün pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Bugün salı");
                    break;
                case 3:
                    Console.WriteLine("Bugün çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Bugün perşembe");
                    break;
                case 5:
                    Console.WriteLine("Bugün cuma");
                    break;
                case 6:
                    Console.WriteLine("Bugün cumaertesi");
                    break;
                case 7:
                    Console.WriteLine("Bugün pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı gün girişi ");
                    break;
            }
        }
    }
}
