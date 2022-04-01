using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };
            int[] dizi;
            dizi = new int[5];
            //dizilere değer atama ve erişim
            renkler[0] = "mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngülerle dizi
            // klavyeden girilen n tane sayının ortalamasını yazdıran program
            Console.WriteLine("diinin eleman sayısını girinniz");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayıdizisi = new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.WriteLine("lütfen {0}. sayısını giriniz.", i + 1);
                sayıdizisi[i] = int.Parse(Console.ReadLine());

            }
            int toplam = 0;
            foreach (var sayi in sayıdizisi)

                toplam += sayi;
            Console.WriteLine("ortalama :" + toplam / diziuzunlugu);



            Console.ReadLine();

        }
    }
}