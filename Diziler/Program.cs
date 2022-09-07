using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler=new string[5];

            string[] hayvanlar={"kedi","köpek","kuş","fil"};
            int[] dizi;
            dizi=new int[5];

            //Dizilere değer atama ve erişim
            renkler[0]="mavi";
            dizi[3]=10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            //Döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Lütfen dizi eleman sayısını giriniz: ");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int[] sayiDizisi=new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz: ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
            toplam+=sayi;
            }
            Console.WriteLine("Ortalama: "+ toplam/diziUzunlugu);
        }
    }
}
