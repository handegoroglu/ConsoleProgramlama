using System;
namespace donguler_while_forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while(sayac<= sayi)
            // {
            //     toplam+= sayac;
            //     sayac ++;

            // }
            // Console.WriteLine(toplam/sayi);
            // char character = 'a';
            // while (character < 'z')
            // {
            //     Console.Write(character);
            //     character ++;

            // }
            Console.Write("**** foreach ****");
            string[] arabalar = { "bmw", "ford", "toyota", "nissan" };

            foreach (var araba in arabalar)
                Console.WriteLine(araba);

        }

    }
}