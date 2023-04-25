using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication
{
    public class CarpimTablosu
    {
        public void Calistir()
        {
            bool cikis = false;
            while (!cikis)
            {
                Console.WriteLine("Merhabalar, n boyutunda çarpım tablosu");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Çıkmak için q ya basınız");
                cikis = Console.ReadLine().Trim().ToLower() == "q";
                Console.Clear();
            }


        }
    }
}
