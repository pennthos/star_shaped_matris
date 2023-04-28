using System;

namespace yıldızntp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("bir sayı girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int bosluk = 0;
            int yildiz = 0;
            int basamak = 1;
            for (int i = 0; i < sayi; i++)
            {
                bosluk = 0;
                while (bosluk < sayi - i)
                {
                    Console.Write(" ");
                    bosluk++;
                }
                yildiz = 0;
                while (yildiz < basamak)
                {
                    Console.Write("*");
                    yildiz++;
                }
                Console.WriteLine();
                basamak = basamak + 2;
            }
            basamak = basamak - 4;
            for (int j = 0; j < sayi - 1; j++)
            {
                bosluk = 0;
                while (bosluk < j + 2)
                {
                    Console.Write(" ");
                    bosluk++;
                }
                yildiz = 0;
                while (yildiz < basamak)
                {
                    Console.Write("*");
                    yildiz++;
                }
                basamak = basamak - 2;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
