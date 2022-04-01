using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndOrCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mount name:");
            string mountName = Console.ReadLine();
            if (mountName == "december" || mountName == "january" || mountName == "february")
            {
                Console.WriteLine("winter");
            }
            else if (mountName == "march" || mountName == "april" || mountName == "may")
            {
                Console.WriteLine("spring");

            }
            Console.ReadLine();
            DateTime today = DateTime.Now;
            if (today.Month == 7 && today.Day == 1)
            {
                Console.WriteLine("türkay's birthdate!");
            }


        }
    }
}
