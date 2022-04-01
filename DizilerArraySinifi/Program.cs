using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_2_Array_Sinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayidizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("***sırasız Dizi***");
            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("***Sıralı Liste***");
            Array.Sort(sayidizisi);

            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);

            //clear
            //sayı dizisi elemanlarınnı kullanara 2. indexten itibaren 2 tane elemanı sıfırlar.
            Console.WriteLine("***array clear***");
            Array.Clear(sayidizisi, 2, 2);

            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);
            Console.WriteLine("***array reverse***");
            //reverse
            //diziyi ortadan itibaren aynalar gibi yer değiştirir.
            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);

            //indexof 
            Console.WriteLine("***indexof***");
            Console.WriteLine(Array.IndexOf(sayidizisi, 23));

            //resize
            Console.WriteLine("***resize***");
            Array.Resize<int>(ref sayidizisi, 9);
            sayidizisi[8] = 99;
            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);



        }
    }
}