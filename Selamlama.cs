using System;

namespace Hesap_Makinesi
{
    public class Selamlama
    {
        public static int GreetUser()
        {
            int choice;

            while (true)
            {
                Console.WriteLine("Merhabalar efendim, hangi işlemi yapmak istersiniz?");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkarma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");
                Console.Write("Lütfen bir seçim yapınız (1-4): ");

                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı bir sayı girdiniz. Lütfen 1 ile 4 arasında bir seçim yapınız.");
                }
            }

            return choice;
        }
    }
}