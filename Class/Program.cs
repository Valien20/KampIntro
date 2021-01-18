using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c";
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOrani = 68;


            //onsole.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }


    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }
}
