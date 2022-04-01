using System;
namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try //hata olacabilecek kod bloğu
            //  {
            //      Console.WriteLine("bir sayı giriniz");
            //      int sayi = Convert.ToInt32(Console.ReadLine());
            //      Console.WriteLine("girmiş olduğunuz sayı: " + sayi);
            //  }
            //  catch(Exception ex) //hatayı yakalayan ve sebebini vermek istersen bu bloğu kullan
            //  {
            //      Console.WriteLine("hata: "+ ex.Message.ToString());

            //  }
            //  finally // kullanımı zorunlu değil hata olsada olmasada dünüş verir.
            //  {
            //     Console.WriteLine("işlem tamamlandı");



            //  }

            try
            {
                // int a = int.Parse(null);
                //int a = int.Parse("test");   
                int a = int.Parse("-2345678910");
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil.");
                Console.WriteLine(ex);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("çok küçük yada çok büyük bir değer girdiniz");
                Console.WriteLine(ex);

            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı.");
                Console.ReadLine();
            }

        }
    }
}