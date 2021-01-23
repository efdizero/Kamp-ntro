using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            // sayı 1 ve 2yi eşit al dediğinde sayi 1 otomatik olarak 30 oluyor 2 değişmiyor. Daha sonra 2 yi 65 yapıyor 2 değişiyor ama 1 i ellemiyor ve 1 30 olarak kalıyor.
            
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);
            Console.WriteLine(sayi1);
            //
        }
    }
}
