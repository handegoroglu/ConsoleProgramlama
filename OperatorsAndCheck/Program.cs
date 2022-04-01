using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = (3 * 5) + 8;
            string newWord = "Bootcamp" + 134;
            Console.WriteLine(newWord);
            Console.WriteLine(x.ToString());

            byte bigNumber = 254;
            byte smallNumber = 3;

            try
            {
                checked
                {
                    byte total = (byte)(bigNumber + smallNumber);
                    Console.WriteLine(total);

                }
                //byte'? ba?a sard??? için sonuç 1 olur
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine("total value cannot cast to byte data type");
            }

            Console.WriteLine("number 1 is:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number 2 is");
            int number2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int division = number1 / number2;
                Console.WriteLine($"result {division}");

            }
            catch (FormatException)
            {
                Console.WriteLine("please just give digits");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("number 2 cannot be 0");
            }


            Console.ReadLine();

        }
    }
}
