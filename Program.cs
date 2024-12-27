using System;

namespace Hesap_Makinesi
{
    public class Program
    {
        public static void Main()
        {
            int choice = Selamlama.GreetUser(); // Ask for user's choice

            Console.Write("İlk sayıyı giriniz: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            double num2 = double.Parse(Console.ReadLine());

            DörtIslem.Calculate(choice, num1, num2); // Perform the chosen calculation
        }
    }
}