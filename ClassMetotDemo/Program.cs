using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Yaman";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 124;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Demir";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine("--------");


            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            {

            }
        }
    }
}
