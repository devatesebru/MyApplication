using System;

namespace MyApplication
{
    public class SayiTahminOyunu
    {
        public void Calistir()
        {
            bool cikis = false;
            while (!cikis)
            {
                //bilgisayar sayı tutsun ben tahmin edeyim
                Console.WriteLine("Bu bir Sayı tahmin oyunudur lütfen hangi sayılar arası edeğer tutsun giriniz");
                int min = Convert.ToInt32(Console.ReadLine());
                int max = Convert.ToInt32(Console.ReadLine());
                Random rastgele = new Random();
                int sayi = rastgele.Next(min, max);

                bool dogruTahmin = false;
                while (!dogruTahmin)
                {
                    Console.WriteLine("lütfen bir sayı tahmin ediniz");
                    int tahmin = Convert.ToInt32(Console.ReadLine());
                    if (sayi == tahmin)
                    {
                        Console.WriteLine("TEBRİKLER DOĞRU BİLDİNİZ");
                        dogruTahmin = true;
                    }
                    else if (sayi > tahmin)
                    {
                        Console.WriteLine("ipucu : tahmininden daha büyük sayı olabilir :D");
                    }
                    else if (sayi < tahmin)
                    {
                        Console.WriteLine("ipucu : tahmininden daha küçük sayı olabilir :D");
                    }
                }
                Console.WriteLine("Çıkmak için q ya basınız");
                cikis = Console.ReadLine().Trim().ToLower() == "q";
                Console.Clear();
            }

        }



    }
}
