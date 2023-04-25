using System;

namespace MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uygulama;
            while (true)
            {
                Console.WriteLine("Lütfen Yapmak istediğiniz uygulamayı seçiniz!");
                Console.WriteLine("1 - Hesap Makinesi");
                Console.WriteLine("2 - Çarpım Tablosu");
                Console.WriteLine("3 - Sayı Tahmin Oyunu");
                Console.WriteLine("4 - Yıldızlarla Yıldız çizdirme");

                uygulama = Convert.ToInt32(Console.ReadLine());

                switch (uygulama)
                {
                    case 1:
                        HesapMakinesi hesapMakinesi = new HesapMakinesi();
                        hesapMakinesi.Calistir();

                        break;
                        
                    case 2:
                        CarpimTablosu carpimTablosu = new CarpimTablosu();
                        carpimTablosu.Calistir();

                        break;
                    case 3:
                        SayiTahminOyunu sayiTahminOyunu = new SayiTahminOyunu();
                        sayiTahminOyunu.Calistir();
                        break;
                    case 4:
                        YildizGosterimi yildizGosterimi = new YildizGosterimi();
                        yildizGosterimi.Calistir();

                        break;
                    default:

                        break;
                }
            }
        }
    }
}
