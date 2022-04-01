using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shoppingList = new string[] { "elma", "salata", "domates" };
            Console.WriteLine(shoppingList[0]);
            Console.WriteLine($"ilk eleman {shoppingList[0]}");
            Console.WriteLine($"array içindeki toplam eleman: {shoppingList.Length}");
            Console.WriteLine($"array içindeki son eleman: {shoppingList[shoppingList.Length - 1]}");

            string[] participants = new string[38];
            participants[0] = "abdullah halit";
            participants[1] = "ahmad hamdan";
            participants[37] = "umut oku";

            //42 : girdi
            //kırk iki : çıktı

            Console.ReadLine();
        }


    }
}
