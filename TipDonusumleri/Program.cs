using System;

namespace tip_dönüsümleri
{
    class program
    {
        static void Main(string[] args)
        {
            // iImplicit Conversion (Bilinçsiz ya da kapalı dönüşüm)
            Console.WriteLine("****iImplicit Conversion (Bilinçsiz ya da kapalı dönüşüm)*****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "hande";
            char f = 'k';
            object g = e + d + f;
            Console.WriteLine("g" + g);

            //Explicit Conversion (Bilinçli ya da açık dönüşüm)

            Console.WriteLine("****Explicit Conversion (Bilinçli ya da açık dönüşüm)*****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // ToString Methodu:
            Console.WriteLine("****ToString Methodu*****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz" + zz);

            // System.Convert

            Console.WriteLine("**** System.Convert Sınıfı*****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            // Parse 
            Console.WriteLine("**** Parse Methodu *****");
            ParseMethod();


        }


        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double1:" + double1);

            Console.ReadLine();

        }

    }
}