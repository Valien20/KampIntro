using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılım1", "yazılım2", "yazılım3", "yazılım4" };

            for (int i =0; i <kurslar.Length; i++)

            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurslar);
                Console.WriteLine("ZEHRABUREA");
            }

            
        }
    }
}
