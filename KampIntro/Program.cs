using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGiris = false;

            if (sistemeGiris==true)
            {
                Console.WriteLine("ayarlar butonu");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
