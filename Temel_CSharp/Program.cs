using System;

namespace Temel_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string katogeriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine(dolarDun == dolarBugun);
            }

            if (sistemGirisYapmisMi == true)
            {
                Console.WriteLine("Kulanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(katogeriEtiketi);
        
        }

    }
}
