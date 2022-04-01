using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayısal veri tipleri
            byte age = 255;  //- olamaz //8bit
            sbyte negativenumber = -4; //- olabilen byte

            short lenght = -32768;
            ushort usingnedShort = 65535;

            int totalYear = 1000000000;

            long watchCount = 100000000000000000;

            double pi = 3.14;
            float discount = 0.15f; //f koymazsan double değşken olarak algılar
            decimal formulaConstant = 0.0000000001M; //en büyük yer kaplayan en hassas değişken


            //sözel
            char character = 'p';
            string word = "bumin kaan baysan";


            //mantıksal
            bool isClosed = true;


            /* 
             * amaç kullanıcının boy ve kilosuna göre BMI hesaplamak
             */
            try
            {
                Console.WriteLine("your weight");
                string weightValue = Console.ReadLine();
                int weight = Convert.ToInt32(weightValue);

                Console.WriteLine("your tall(meter unit)");
                double height = Convert.ToDouble(Console.ReadLine());

                double bmi = weight / (height * height);
                Console.WriteLine("your bmi value is " + bmi);
                if (bmi < 18.5)
                {
                    Console.WriteLine("you are obese");
                }
                else if (bmi < 24.9)
                {
                    Console.WriteLine("you are normal weight");
                }
                else if (bmi < 29.9)
                {
                    Console.WriteLine("you are over weight");
                }
                else
                {
                    Console.WriteLine("you are obese");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("plase give values with true format");


            }

            Console.WriteLine();


        }
    }
}
