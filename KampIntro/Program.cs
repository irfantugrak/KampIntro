using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // kategoriEtiketi - Değer tutucu & ALIAS

            string kategoriEtiketi = "Kategoriler";
            int ogren ciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artıs butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            
            if (sistemeGirisYapmisMi == true)
            { 
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
