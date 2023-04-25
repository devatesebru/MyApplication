using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication
{
    public class YildizGosterimi
    {
        public void Calistir()
        {
            Console.WriteLine("lütfen yıldız boyutunu girin düzgün şekil çıkması için tek sayı giriniz ");
            int boyut =Convert.ToInt32(Console.ReadLine()); // Çarpı işaretinin boyutu
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    if (i == j || i + j == boyut-1) // Çarpı işaretinin köşeleri
                    {
                        Console.Write("* ");
                    }
                    else if (i == boyut / 2)
                    {
                       
                            Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
