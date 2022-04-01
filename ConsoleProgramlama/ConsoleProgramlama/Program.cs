using System;


namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("isminizi giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("merhaba " + name + " " + surname);

            Console.ReadLine();
        }
    }
}