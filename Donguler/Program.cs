using System;

namespace Donguler
{
    class Program
    {
        class Program
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            //array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs","Java", "Python","C#"};

                
            for (int i = 0; i <kurslar.Length; i++) //i 1 den başlıyor diğeri şart diğeride bir bir ekle diyo
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Kurs bitti");

            foreach (string k in kurslar)
            {
                Console.WriteLine(k);

            }

            Console.WriteLine("Sayfa sonu - footer");

        }
    }
}
