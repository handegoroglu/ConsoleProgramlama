using System;
namespace operatorler
{
    class program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("atama ve işlemli atama");
            // atama ve işlemli atama
            int x = 3;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y);

            y += 2;  //buna işlemli atama denir 2. yöntem
            Console.WriteLine(y);

            y /= 2;
            Console.WriteLine(y);

            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("mantıksal operatörler");

            //mantıksal operatörler
            //  ||, &&, !
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("mükemmel");

            if (isSuccess || isCompleted)
                Console.WriteLine("harika");

            if (isSuccess && !isCompleted)
                Console.WriteLine("iyi");

            Console.WriteLine("ilişkisel operatörler");
            //ilişkisel operatörler
            // > < >= <= == !=

            int a = 3;
            int b = 4;

            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = b == a;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmetik operatörler
            //  /, *, +, -
            Console.WriteLine("Aritmetik operatörler");



            int sayi = 10;
            int sayi1 = 5;

            int sonuc1 = sayi / sayi1;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi * sayi1;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi + sayi1;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi - sayi1;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi++;
            Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);





            Console.ReadLine();

        }
    }
}