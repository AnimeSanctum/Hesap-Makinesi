using System;

namespace Hesap_Makinesi
{
    public class DörtIslem
    {
        public static void Calculate(int choice, double num1, double num2)
        {
            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Sonuç: {num1} + {num2} = {result}");
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Sonuç: {num1} - {num2} = {result}");
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Sonuç: {num1} * {num2} = {result}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Sonuç: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Sıfıra bölme yapılamaz.");
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen 1-4 arasında bir sayı giriniz.");
                    break;
            }
        }
    }
}