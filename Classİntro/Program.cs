using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 35;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitimen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitimen = "Kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitimen = "Berkay";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitimen = "Murat";
            kurs4.IzlenmeOrani = 100;



            // Console.WriteLine(kurs1.IzlenmeOrani + " " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitimen);
            }

        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }
        public string Egitimen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
