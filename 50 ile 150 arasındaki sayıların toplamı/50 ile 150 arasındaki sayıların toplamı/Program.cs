using System;

class Program
{
    static void Main()
    {
        int baslangic = 51;
        int bitis = 150;
        int toplam = 0;

        for (int i = baslangic; i < bitis; i++)
        {
            toplam += i;
        }

        Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}" );
    }
}