using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication
{
    public class HesapMakinesi
    {
       public void Calistir()
        {
            int a, b, islemTuru;
            bool cikis = false;
            while (!cikis)
            {
                Console.WriteLine("Merhabalar İşlem Yapmak istediğiniz sayıları giriniz");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yapmak isteiğiniz işlemi seçiniz ve yanındaki sayı değerini girip enter e basınız. ");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Çıkarma");
                Console.WriteLine("3 - Çarpma");
                Console.WriteLine("4 - Bölme");
                islemTuru = Convert.ToInt32(Console.ReadLine());
                switch (islemTuru)
                {
                    case 1:
                        Console.WriteLine(a + b);
                        break;
                    case 2:
                        Console.WriteLine(a - b);
                        break;
                    case 3:
                        Console.WriteLine(a * b);
                        break;
                    case 4:
                        Console.WriteLine(a / b);
                        break;                   
                    default:
                        Console.WriteLine("Lütfen İşlem Türünü Dikkatli Seçiniz.");
                        break;
                }
                Console.WriteLine("Çıkmak için q ya basınız");                
                cikis=Console.ReadLine().Trim().ToLower() == "q";
                Console.Clear();

            }
        }
    }
}
